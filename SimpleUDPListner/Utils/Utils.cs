using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public static class Utils
    {
        public static UInt64 lcmOfNumbers(UInt64 num1, UInt64 num2)
        {
            UInt64 temp = num1 > num2 ? num1 : num2;
            UInt64 tempInitial = temp;
            UInt64 counter = 1;
            while (!(temp % num1 == 0 && temp % num2 == 0))
            {
                temp = tempInitial * counter;
                counter++;
            }
            //Console.WriteLine("Answer: " + temp);
            return temp;
        }

        public static IEnumerable<Control> GetAllControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            if (ParentCntl.Name == NameToSearch)
                return ParentCntl;

            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                Control ResultCntl = GetControlByName(ChildCntl, NameToSearch);
                if (ResultCntl != null)
                    return ResultCntl;
            }
            return null;

        }
        
        public static void CopyUInt16ToByteList(ref List<byte> byteList, UInt16 value, UInt16 coeff)
        {
            byteList.AddRange(BitConverter.GetBytes((UInt16)(value * coeff)));
        }

        public static void CopyUInt32ToByteList(ref List<byte> byteList, UInt32 value, UInt32 coeff)
        {
            byteList.AddRange(BitConverter.GetBytes(value * coeff));
        }

        public static void CopyUInt64ToByteList(ref List<byte> byteList, UInt64 value, UInt32 coeff)
        {
            byteList.AddRange(BitConverter.GetBytes(value * coeff));
        }

        public static void CopyByteArryToByteList(ref List<byte> byteList, byte[] byteArray, int limit)
        {
            int i = 0;
            int lengthOfInput = byteArray.Length;
            for (i = 0; i < lengthOfInput && i < limit - 1; i++)
            {
                byteList.Add(byteArray[i]);
            }

            while (i++ < limit)
            {
                byteList.Add((byte)'\0');
            }
        }

        public static void AssignBitInByte(ref byte byt, byte bitPos, bool set)
        {
            if (set)
            {
                SetBitInByte(ref byt, bitPos);
            }
            else
            {
                ReSetBitInByte(ref byt, bitPos);
            }
        }

        private static void SetBitInByte(ref byte byt, byte bitPos)
        {
            byt |= (byte)(1 << bitPos);
        }

        private static void ReSetBitInByte(ref byte byt, byte bitPos)
        {
            byt &= (byte)(~(1 << bitPos));
        }

        public static PropertyInfo GetProperty(object inputClass, string propertyName, out object outClass)
        {
            object intermediateOutClass = null;
            object intermediateClass = null;
            PropertyInfo intermediatePropertyInfo = null;
            Type type = inputClass.GetType();

            foreach (PropertyInfo pinf in type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public |
                                                                BindingFlags.NonPublic).Where(p => p.GetGetMethod(true) != null &&
                                                                p.GetSetMethod(true) != null).ToArray())
            {
                if (pinf.Name == propertyName)
                {
                    outClass = inputClass;
                    return pinf;
                }
                if (type.Name != pinf.Name && !pinf.PropertyType.IsArray && pinf.PropertyType.IsClass)
                {
                    intermediateClass = pinf.GetValue(inputClass);
                    intermediatePropertyInfo = GetProperty(intermediateClass, propertyName, out intermediateOutClass);
                    if (intermediatePropertyInfo != null)
                    {
                        outClass = intermediateOutClass;
                        return intermediatePropertyInfo;
                    }
                }
            }

            outClass = intermediateOutClass;
            return (PropertyInfo)intermediateOutClass;
        }
        public static Dictionary<PropertyInfo, object> GetPropertyInfos(object myClass, List<string> Exceptions)
        {
            Dictionary<PropertyInfo, object> propertyInfos = new Dictionary<PropertyInfo, object>();
            //PropertyInfo pi = null;
            //object cls = null;
            Dictionary<PropertyInfo, object> pi2 = new Dictionary<PropertyInfo, object>();
            Type type = myClass.GetType();

            foreach (PropertyInfo pinf in type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public |
                                                                BindingFlags.NonPublic).Where(p => p.GetGetMethod(true) != null && p.GetSetMethod(true) != null).ToArray())
            {
                if (Exceptions == null || !Exceptions.Contains(pinf.Name))
                {
                    if (!pinf.PropertyType.IsClass || pinf.PropertyType == typeof(string))
                    {
                        propertyInfos.Add(pinf, myClass);
                    }
                    else if (!pinf.PropertyType.IsArray && pinf.PropertyType.IsClass)
                    {
                        pi2 = GetPropertyInfos(pinf.GetValue(myClass), Exceptions);
                        if (pi2 != null)
                        {
                            foreach (KeyValuePair<PropertyInfo, object> entry in pi2)
                            {
                                propertyInfos.Add(entry.Key, entry.Value);
                            }
                        }
                    }
                }
            }

            return propertyInfos;
        }
        public static Dictionary<PropertyInfo, object> GetPropertyInfos(Type myClassType, List<string> Exceptions)
        {
            Dictionary<PropertyInfo, object> propertyInfos = new Dictionary<PropertyInfo, object>();
            //PropertyInfo pi = null;
            //object cls = null;
            Dictionary<PropertyInfo, object> pi2 = new Dictionary<PropertyInfo, object>();
            Type type = myClassType; //.GetType();

            foreach (PropertyInfo pinf in type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public |
                                                                BindingFlags.NonPublic).Where(p => p.GetGetMethod(true) != null && p.GetSetMethod(true) != null).ToArray())
            {
                if (Exceptions == null || !Exceptions.Contains(pinf.Name))
                {
                    if ((!pinf.PropertyType.IsClass && pinf.PropertyType.GetNestedTypes().Length == 0) || pinf.PropertyType == typeof(string)) //!pinf.PropertyType.IsClass || pinf.PropertyType == typeof(string))
                    {
                        propertyInfos.Add(pinf, myClassType);
                    }
                    else if (!pinf.PropertyType.IsArray && pinf.PropertyType.IsClass)
                    {
                        pi2 = GetPropertyInfos(pinf.PropertyType /* pinf.GetValue(myClassType) */, Exceptions);
                        if (pi2 != null)
                        {
                            foreach (KeyValuePair<PropertyInfo, object> entry in pi2)
                            {
                                propertyInfos.Add(entry.Key, entry.Value);
                            }
                        }
                    }
                }
            }

            return propertyInfos;
        }
       
        public static List<Type> GetAllNestedTypes(Type typ)
        {
            ArrayList typeArrayList = new ArrayList(typ.GetNestedTypes(BindingFlags.Public));
            List<Type> typeList = typeArrayList.Cast<Type>().ToList();

            foreach (Type t in typeArrayList)
            {
                if (t.GetNestedTypes(BindingFlags.Public) != null)
                {
                    if (!typeList.Contains(t))
                    {
                        typeList.AddRange(t.GetNestedTypes());
                    }
                    typeList.AddRange(GetAllNestedTypes(t));
                }
            }

            return typeList;
        }


        public static void DetachControlsEventHandlers(Type ctlType, Control containerCtl, EventHandler Method)
        {
            foreach (Control ctl in containerCtl.Controls)
            {
                if (ctl.GetType() == ctlType)
                {
                    ctl.Validated -= Method;
                }
                else if (ctl.Controls.Count > 0)
                {
                    DetachControlsEventHandlers(ctlType, ctl, Method);
                }
            }
        }
        public static void AttachControlsEventHandlers(Type ctlType, Control containerCtl, EventHandler Method)
        {
            foreach (Control ctl in containerCtl.Controls)
            {
                if (ctl.GetType() == ctlType)
                {
                    ctl.Validated += Method;
                }
                else if (ctl.Controls.Count > 0)
                {
                    DetachControlsEventHandlers(ctlType, ctl, Method);
                }
            }
        }

        public static void ChangeBindingSourceUpdateMode(Type ctlType, Control containerCtl, DataSourceUpdateMode um)
        {
            foreach (Control ctl in containerCtl.Controls)
            {
                if (ctl.GetType() == ctlType)
                {
                    ctl.DataBindings.DefaultDataSourceUpdateMode = um;
                }
                else if (ctl.Controls.Count > 0)
                {
                    ChangeBindingSourceUpdateMode(ctlType, ctl, um);
                }
            }
        }

        public static DialogResult MultipleChoiceDialog(string textToDisplay)
        {
            // Create a new instance of the form.
            Form form1 = new Form();
            // Create two buttons to use as the accept and cancel buttons.
            Button button1 = new Button();
            Button button2 = new Button();

            // Set the text of button1 to "OK".
            button1.Text = "OK";
            // Set the position of the button on the form.
            button1.Location = new Point(10, 10);
            // Set the text of button2 to "Cancel".
            button2.Text = "Cancel";
            // Set the position of the button based on the location of button1.
            button2.Location
               = new Point(button1.Left, button1.Height + button1.Top + 10);
            // Make button1's dialog result OK.
            button1.DialogResult = DialogResult.OK;
            // Make button2's dialog result Cancel.
            button2.DialogResult = DialogResult.Cancel;
            // Set the caption bar text of the form.   
            form1.Text = textToDisplay;

            // Define the border style of the form to a dialog box.
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the accept button of the form to button1.
            form1.AcceptButton = button1;
            // Set the cancel button of the form to button2.
            form1.CancelButton = button2;
            // Set the start position of the form to the center of the screen.
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(button2);

            // Display the form as a modal dialog box.
            form1.ShowDialog();

            return form1.DialogResult;
            // Determine if the OK button was clicked on the dialog box.
            //if (form1.DialogResult == DialogResult.OK)
            //{
            //    // Display a message box indicating that the OK button was clicked.
            //    MessageBox.Show("The OK button on the form was clicked.");
            //    // Optional: Call the Dispose method when you are finished with the dialog box.
            //    form1.Dispose();
            //}
            //else
            //{
            //    // Display a message box indicating that the Cancel button was clicked.
            //    MessageBox.Show("The Cancel button on the form was clicked.");
            //    // Optional: Call the Dispose method when you are finished with the dialog box.
            //    form1.Dispose();
            //}
        }

        public static UInt32 Adler32(byte[] data, UInt16 len)
        {
            UInt32 a = 1, b = 0, MOD_ADLER = 65521;
            UInt16 index;

            // Process each byte of the data in order
            for (index = 0; index < len; ++index)
            {
                a = (a + data[index]) % MOD_ADLER;
                b = (b + a) % MOD_ADLER;
            }

            return (b << 16) | a;
        }

        //public string GetMemberDBTypeByName(string memberName)
        //{
        //    PropertyInfo[] allProperties = this.GetType().GetProperties();
        //    string retDBType = "";
        //    foreach (PropertyInfo pi in allProperties)
        //    {
        //        if (pi.Name == memberName)
        //        {
        //            if (pi.GetType() == typeof(bool))
        //            {
        //                retDBType = "BOOLEAN";
        //            }
        //            else if (pi.GetType() == typeof(string))
        //            {
        //                retDBType = "NVARCHAR(30)";
        //            }
        //            else if (pi.GetType() == typeof(UInt64))
        //            {
        //                retDBType = "UNSIGNED BIG INT";
        //            }
        //            else if (pi.GetType() == typeof(UInt32))
        //            {
        //                retDBType = "UNSIGNED INT";
        //            }
        //            else if (pi.GetType() == typeof(Int64))
        //            {
        //                retDBType = "BIG INT";
        //            }
        //            else if (pi.GetType() == typeof(Int32))
        //            {
        //                retDBType = "INT";
        //            }
        //            else if (pi.GetType() == typeof(double))
        //            {
        //                retDBType = "DOUBLE";
        //            }
        //            break;
        //        }
        //    }

        //    return retDBType;
        //}
        //public object GetMemberValueByName(string memberName)
        //{
        //    PropertyInfo[] allProperties = this.GetType().GetProperties();
        //    object retObj = null;
        //    foreach (PropertyInfo pi in allProperties)
        //    {
        //        if (pi.Name == memberName)
        //        {
        //            retObj = pi.GetValue(this);
        //            break;
        //        }
        //    }

        //    return retObj;
        //}
        //public string GetAllMembersAsString(string seperator)
        //{
        //    string retVal = null;

        //    PropertyInfo[] allProperties = this.GetType().GetProperties();
        //    foreach (PropertyInfo pi in allProperties)
        //    {
        //        retVal = retVal + (String.IsNullOrEmpty(retVal) ? "" : seperator) + pi.Name;
        //    }

        //    return retVal;
        //}
        //public int GetNumOfAllMembers()
        //{
        //    int i = 0;

        //    PropertyInfo[] allProperties = this.GetType().GetProperties();
        //    i = allProperties.Count();
        //    return i;
        //}
        //public void CopyTo(Telemetry t)
        //{
        //    foreach (var property in this.GetType().GetProperties())
        //    {
        //        PropertyInfo propertyS = t.GetType().GetProperty(property.Name);
        //        var value = property.GetValue(this, null);
        //        propertyS.SetValue(t, property.GetValue(this, null), null);
        //    }
        //}
        //public void CopyFrom(object t, object innerClass, bool CopyId)
        //{
        //    PropertyInfo propertyS = null;
        //    foreach (var property in (innerClass == null ? this.GetType().GetProperties() : innerClass.GetType().GetProperties()))
        //    {
        //        if ((property.Name == "Id" && CopyId) || property.Name != "Id")
        //        {
        //            propertyS = t.GetType().GetProperty(property.Name);
        //            if (!property.PropertyType.IsClass || property.PropertyType == typeof(string))
        //            {
        //                var value = property.GetValue(t, null);
        //                propertyS.SetValue(innerClass == null ? this : innerClass, property.GetValue(t, null));
        //            }
        //            else if (!property.PropertyType.IsArray && property.PropertyType.IsClass)
        //            {
        //                CopyFrom(property.GetValue(t, null), propertyS.GetValue(innerClass == null ? this : innerClass, null), CopyId);
        //            }
        //        }
        //    }
        //}
        //public bool Compare(Telemetry t)
        //{
        //    foreach (var property in this.GetType().GetProperties())
        //    {
        //        PropertyInfo propertyS = t.GetType().GetProperty(property.Name);
        //        var value = property.GetValue(this, null);
        //        var valueS = propertyS.GetValue(t, null);
        //        if ((value != null && valueS != null) && !value.Equals(valueS))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        public static Object ByteArrayToObject(byte[] arrBytes, int length)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, length == 0 ? arrBytes.Length : length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }

        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        public static byte[] SerializeToByteArray(this object obj)
        {
            if (obj == null)
            {
                return null;
            }
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static T Deserialize<T>(this byte[] byteArray, int len) where T : class
        {
            if (byteArray == null)
            {
                return null;
            }
            using (MemoryStream memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(byteArray, 0, len == 0 ? byteArray.Length : len);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = (T)binForm.Deserialize(memStream);
                return obj;
            }
        }
    }
}
