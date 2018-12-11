using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleUDPListner
{
    class UDPListener
    {
        private int m_portToListen;
        private volatile bool listening;
        Thread m_ListeningThread;
        public event EventHandler<MyMessageArgs> NewMessageReceived;
        UdpClient listener;
        IPEndPoint groupEP;

        //constructor
        public UDPListener(int port)
        {
            this.listening = false;
            m_portToListen = port;
        }

        public void StartListener(EventHandler<MyMessageArgs> e) // int exceptedMessageLength)
        {
            if (!this.listening)
            {
                this.NewMessageReceived += e;
                this.listening = true;
                m_ListeningThread = new Thread(new ThreadStart(ListenForUDPPackages));
                m_ListeningThread.IsBackground = true;                
                m_ListeningThread.Start();
            }
        }

        public void StopListener()
        {
            this.listening = false;
            if (listener != null)
            {
                listener.Close();
            }
        }

        public void ListenForUDPPackages()
        {
            listener = null;
            try
            {
                listener = new UdpClient(m_portToListen);
            }
            catch (SocketException)
            {
                //do nothing
            }

            if (listener != null)
            {
                groupEP = new IPEndPoint(IPAddress.Any, m_portToListen);

                try
                {
                    while (this.listening)
                    {
                        Console.WriteLine("Waiting for UDP broadcast to port " + m_portToListen);
                        byte[] bytes = listener.Receive(ref groupEP);

                        //raise event                        
                        NewMessageReceived(this, new MyMessageArgs(bytes));
                    }
                }
                catch (Exception e)
                {
                    if (this.listening)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                finally
                {
                    if(NewMessageReceived != null)
                    {
                        // first disconnect the event
                        this.NewMessageReceived -= NewMessageReceived;
                    }
                    if (listener != null)
                    {                       
                        listener.Close();
                    }
                    Console.WriteLine("Done listening for UDP broadcast");
                }
            }
        }
    }

    public class MyMessageArgs : EventArgs
    {
        public byte[] data { get; set; }

        public MyMessageArgs(byte[] newData)
        {
            data = newData;
        }
    }
}
