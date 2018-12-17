using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUDPListner
{
    [Serializable]
    public class Telemetry : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [Serializable]
        public class TimeStamp : INotifyPropertyChanged
        {
            [field: NonSerialized]
            public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            [Serializable]
            public class Date : INotifyPropertyChanged
            {
                [field: NonSerialized]
                public event PropertyChangedEventHandler PropertyChanged;                
                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                {
                    if (PropertyChanged != null)
                    {
                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    }
                }
                
                private byte _WeekDay;
                public byte WeekDay
                {
                    get { return this._WeekDay; }
                    set { if (value != this._WeekDay) { this._WeekDay = value; NotifyPropertyChanged(); } }
                }

                private byte _Month;
                public byte Month
                {
                    get { return this._Month; }
                    set { if (value != this._Month) { this._Month = value; NotifyPropertyChanged(); } }
                }

                private byte _Day;
                public byte Day
                {
                    get { return this._Day; }
                    set { if (value != this._Day) { this._Day = value; NotifyPropertyChanged(); } }
                }

                private byte _Year;
                public byte Year
                {
                    get { return this._Year; }
                    set { if (value != this._Year) { this._Year = value; NotifyPropertyChanged(); } }
                }

                //public Date()
                //{
                //    // Empty constructor required to compile.
                //}
                // Implement this method to serialize data. The method is called 
                // on serialization.
                //public void GetObjectData(SerializationInfo info, StreamingContext context)
                //{
                //    // Use the AddValue method to specify serialized values.
                //    info.AddValue("props", _WeekDay, typeof(byte));
                //    info.AddValue("props", _Month, typeof(byte));
                //    info.AddValue("props", _Day, typeof(byte));
                //    info.AddValue("props", _Year, typeof(byte));

                //}
                //// The special constructor is used to deserialize values.
                //public Date(SerializationInfo info, StreamingContext context)
                //{
                //    // Reset the property value using the GetValue method.
                //    _WeekDay = (byte)info.GetValue("props", typeof(byte));
                //    _Month = (byte)info.GetValue("props", typeof(byte));
                //    _Day = (byte)info.GetValue("props", typeof(byte));
                //    _Year = (byte)info.GetValue("props", typeof(byte));
                //}

            }
            [Serializable]
            public class Time : INotifyPropertyChanged
            {
                [field: NonSerialized]
                public event PropertyChangedEventHandler PropertyChanged;                
                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                {
                    if (PropertyChanged != null)
                    {
                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    }
                }

                private byte _Hour;
                public byte Hour
                {
                    get { return this._Hour; }
                    set { if (value != this._Hour) { this._Hour = value; NotifyPropertyChanged(); } }
                }

                private byte _Minute;
                public byte Minute
                {
                    get { return this._Minute; }
                    set { if (value != this._Minute) { this._Minute = value; NotifyPropertyChanged(); } }
                }

                private byte _Second;
                public byte Second
                {
                    get { return this._Second; }
                    set { if (value != this._Second) { this._Second = value; NotifyPropertyChanged(); } }
                }

                //public Time()
                //{
                //    // Empty constructor required to compile.
                //}
                // Implement this method to serialize data. The method is called 
                // on serialization.
                //public void GetObjectData(SerializationInfo info, StreamingContext context)
                //{
                //    // Use the AddValue method to specify serialized values.
                //    info.AddValue("props", _Hour, typeof(byte));
                //    info.AddValue("props", _Minute, typeof(byte));
                //    info.AddValue("props", _Second, typeof(byte));
                //}
                //// The special constructor is used to deserialize values.
                //public Time(SerializationInfo info, StreamingContext context)
                //{
                //    // Reset the property value using the GetValue method.
                //    _Hour = (byte)info.GetValue("props", typeof(byte));
                //    _Minute = (byte)info.GetValue("props", typeof(byte));
                //    _Second = (byte)info.GetValue("props", typeof(byte));
                //}
            }

            //[field: NonSerialized]
            //public Date date = new Date();
            //[field: NonSerialized]
            //public Time time = new Time();

            [field: NonSerialized]
            private Date _date;
            public Date date
            {
                get { return this._date; }
                set { if (value != this._date) { this._date = value; NotifyPropertyChanged(); } }
            }

            [field: NonSerialized]
            private Time _time;
            public Time time
            {
                get { return this._time; }
                set { if (value != this._time) { this._time = value; NotifyPropertyChanged(); } }
            }

            [field: NonSerialized]
            public TimeStamp()
            {
                _date = new Date();
                _time = new Time();
            }
            // Implement this method to serialize data. The method is called 
            // on serialization.
            //public void GetObjectData(SerializationInfo info, StreamingContext context)
            //{
            //    // Use the AddValue method to specify serialized values.
            //    info.AddValue("props", _date, typeof(Date));
            //    info.AddValue("props", _time, typeof(Time));

            //}
            //// The special constructor is used to deserialize values.
            //public TimeStamp(SerializationInfo info, StreamingContext context)
            //{
            //    // Reset the property value using the GetValue method.
            //    _date = (Date)info.GetValue("props", typeof(Date));
            //    _time = (Time)info.GetValue("props", typeof(Time));
            //}
        }
        [Serializable]
        public class Modules : INotifyPropertyChanged
        {
            [field: NonSerialized]
            public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            [Serializable]
            public class Canbus : INotifyPropertyChanged
            {
                [field: NonSerialized]
                public event PropertyChangedEventHandler PropertyChanged;
                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                {
                    if (PropertyChanged != null)
                    {
                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    }
                }
                
                private string _Identification_Number;
                public string Identification_Number
                {
                    get { return this._Identification_Number; }
                    set { if (value != this._Identification_Number) { this._Identification_Number = value; NotifyPropertyChanged(); } }
                }

                private byte _Calculated_Engine_Load;
                public byte Calculated_Engine_Load
                {
                    get { return this._Calculated_Engine_Load; }
                    set { if (value != this._Calculated_Engine_Load) { this._Calculated_Engine_Load = value; NotifyPropertyChanged(); } }
                }

                private byte _Engine_Temperature;
                public byte Engine_Temperature
                {
                    get { return this._Engine_Temperature; }
                    set { if (value != this._Engine_Temperature) { this._Engine_Temperature = value; NotifyPropertyChanged(); } }
                }

                private byte _Fuel_Level;
                public byte Fuel_Level
                {
                    get { return this._Fuel_Level; }
                    set { if (value != this._Fuel_Level) { this._Fuel_Level = value; NotifyPropertyChanged(); } }
                }

                private byte _Speed;
                public byte Speed
                {
                    get { return this._Speed; }
                    set { if (value != this._Speed) { this._Speed = value; NotifyPropertyChanged(); } }
                }

                private byte _Throttle_Position_B;
                public byte Throttle_Position_B
                {
                    get { return this._Throttle_Position_B; }
                    set { if (value != this._Throttle_Position_B) { this._Throttle_Position_B = value; NotifyPropertyChanged(); } }
                }

                private byte _Throttle_Position_C;
                public byte Throttle_Position_C
                {
                    get { return this._Throttle_Position_C; }
                    set { if (value != this._Throttle_Position_C) { this._Throttle_Position_C = value; NotifyPropertyChanged(); } }
                }

                private byte _Intake_Manifold_Pressure;
                public byte Intake_Manifold_Pressure
                {
                    get { return this._Intake_Manifold_Pressure; }
                    set { if (value != this._Intake_Manifold_Pressure) { this._Intake_Manifold_Pressure = value; NotifyPropertyChanged(); } }
                }

                private byte _Fuel_Consumption;
                public byte Fuel_Consumption
                {
                    get { return this._Fuel_Consumption; }
                    set { if (value != this._Fuel_Consumption) { this._Fuel_Consumption = value; NotifyPropertyChanged(); } }
                }

                private byte _RealTime_Fuel_Consumption;
                public byte RealTime_Fuel_Consumption
                {
                    get { return this._RealTime_Fuel_Consumption; }
                    set { if (value != this._RealTime_Fuel_Consumption) { this._RealTime_Fuel_Consumption = value; NotifyPropertyChanged(); } }
                }

                private byte _Spark_Advance_Angle;
                public byte Spark_Advance_Angle
                {
                    get { return this._Spark_Advance_Angle; }
                    set { if (value != this._Spark_Advance_Angle) { this._Spark_Advance_Angle = value; NotifyPropertyChanged(); } }
                }

                private byte _Fuel_Correction_Value;
                public byte Fuel_Correction_Value
                {
                    get { return this._Fuel_Correction_Value; }
                    set { if (value != this._Fuel_Correction_Value) { this._Fuel_Correction_Value = value; NotifyPropertyChanged(); } }
                }

                private UInt16 _RPM;
                public UInt16 RPM
                {
                    get { return this._RPM; }
                    set { if (value != this._RPM) { this._RPM = value; NotifyPropertyChanged(); } }
                }

                private Int16 _Intake_Air_Temperature;
                public Int16 Intake_Air_Temperature
                {
                    get { return this._Intake_Air_Temperature; }
                    set { if (value != this._Intake_Air_Temperature) { this._Intake_Air_Temperature = value; NotifyPropertyChanged(); } }
                }

                private UInt16 _Mass_Air_Flow_Rate;
                public UInt16 Mass_Air_Flow_Rate
                {
                    get { return this._Mass_Air_Flow_Rate; }
                    set { if (value != this._Mass_Air_Flow_Rate) { this._Mass_Air_Flow_Rate = value; NotifyPropertyChanged(); } }
                }

                private UInt16 _Total_Distance;
                public UInt16 Total_Distance
                {
                    get { return this._Total_Distance; }
                    set { if (value != this._Total_Distance) { this._Total_Distance = value; NotifyPropertyChanged(); } }
                }

                private UInt16 _Control_Module_Voltage;
                public UInt16 Control_Module_Voltage
                {
                    get { return this._Control_Module_Voltage; }
                    set { if (value != this._Control_Module_Voltage) { this._Control_Module_Voltage = value; NotifyPropertyChanged(); } }
                }

                //public Canbus()
                //{
                //    // Empty constructor required to compile.
                //}
                // Implement this method to serialize data. The method is called 
                // on serialization.
                //public void GetObjectData(SerializationInfo info, StreamingContext context)
                //{
                //    // Use the AddValue method to specify serialized values.
                //    info.AddValue("props", _Identification_Number, typeof(string));
                //    info.AddValue("props", _Calculated_Engine_Load, typeof(byte));
                //    info.AddValue("props", _Engine_Temperature, typeof(byte));
                //    info.AddValue("props", _Fuel_Level, typeof(byte));
                //    info.AddValue("props", _Speed, typeof(byte));
                //    info.AddValue("props", _Throttle_Position_B, typeof(byte));
                //    info.AddValue("props", _Throttle_Position_C, typeof(byte));
                //    info.AddValue("props", _Intake_Manifold_Pressure, typeof(byte));
                //    info.AddValue("props", _Fuel_Consumption, typeof(byte));
                //    info.AddValue("props", _RealTime_Fuel_Consumption, typeof(byte));
                //    info.AddValue("props", _Spark_Advance_Angle, typeof(byte));
                //    info.AddValue("props", _Fuel_Correction_Value, typeof(byte));
                //    info.AddValue("props", _RPM, typeof(UInt16));
                //    info.AddValue("props", _Intake_Air_Temperature, typeof(Int16));
                //    info.AddValue("props", _Mass_Air_Flow_Rate, typeof(UInt16));
                //    info.AddValue("props", _Total_Distance, typeof(UInt16));
                //    info.AddValue("props", _Control_Module_Voltage, typeof(UInt16));

                //}
                //// The special constructor is used to deserialize values.
                //public Canbus(SerializationInfo info, StreamingContext context)
                //{
                //    // Reset the property value using the GetValue method.
                //    _Identification_Number = (string)info.GetValue("props", typeof(string));
                //    _Calculated_Engine_Load = (byte)info.GetValue("props", typeof(byte));
                //    _Engine_Temperature = (byte)info.GetValue("props", typeof(byte));
                //    _Fuel_Level = (byte)info.GetValue("props", typeof(byte));
                //    _Speed = (byte)info.GetValue("props", typeof(byte));
                //    _Throttle_Position_B = (byte)info.GetValue("props", typeof(byte));
                //    _Throttle_Position_C = (byte)info.GetValue("props", typeof(byte));
                //    _Intake_Manifold_Pressure = (byte)info.GetValue("props", typeof(byte));
                //    _Fuel_Consumption = (byte)info.GetValue("props", typeof(byte));
                //    _RealTime_Fuel_Consumption = (byte)info.GetValue("props", typeof(byte));
                //    _Spark_Advance_Angle = (byte)info.GetValue("props", typeof(byte));
                //    _Fuel_Correction_Value = (byte)info.GetValue("props", typeof(byte));
                //    _RPM = (UInt16)info.GetValue("props", typeof(UInt16));
                //    _Intake_Air_Temperature = (Int16)info.GetValue("props", typeof(Int16));
                //    _Mass_Air_Flow_Rate = (UInt16)info.GetValue("props", typeof(UInt16));
                //    _Total_Distance = (UInt16)info.GetValue("props", typeof(UInt16));
                //    _Control_Module_Voltage = (UInt16)info.GetValue("props", typeof(UInt16));
                //}
            }

            [Serializable]
            public class MEMs : INotifyPropertyChanged
            {
                [field: NonSerialized]
                public event PropertyChangedEventHandler PropertyChanged;
                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                {
                    if (PropertyChanged != null)
                    {
                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    }
                }

                [Serializable]
                public class Acce : INotifyPropertyChanged
                {
                    [field:NonSerialized]
                    public event PropertyChangedEventHandler PropertyChanged;
                    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                    {
                        if (PropertyChanged != null)
                        {
                            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                        }
                    }
                                       
                    private Int32 _Ax;
                    public Int32 Ax
                    {
                        get { return this._Ax; }
                        set { if (value != this._Ax) { this._Ax = value; NotifyPropertyChanged(); } }
                    }

                    private Int32 _Ay;
                    public Int32 Ay
                    {
                        get { return this._Ay; }
                        set { if (value != this._Ay) { this._Ay = value; NotifyPropertyChanged(); } }
                    }

                    private Int32 _Az;
                    public Int32 Az
                    {
                        get { return this._Az; }
                        set { if (value != this._Az) { this._Az = value; NotifyPropertyChanged(); } }
                    }

                    //public Acce()
                    //{
                    //    // Empty constructor required to compile.
                    //}
                    // Implement this method to serialize data. The method is called 
                    // on serialization.
                    //public void GetObjectData(SerializationInfo info, StreamingContext context)
                    //{
                    //    // Use the AddValue method to specify serialized values.
                    //    info.AddValue("props", _Ax, typeof(Int32));
                    //    info.AddValue("props", _Ay, typeof(Int32));
                    //    info.AddValue("props", _Az, typeof(Int32));
                    //}
                    //// The special constructor is used to deserialize values.
                    //public Acce(SerializationInfo info, StreamingContext context)
                    //{
                    //    // Reset the property value using the GetValue method.
                    //    _Ax = (Int32)info.GetValue("props", typeof(Int32));
                    //    _Ay = (Int32)info.GetValue("props", typeof(Int32));
                    //    _Az = (Int32)info.GetValue("props", typeof(Int32));
                    //}
                }
                [Serializable]
                public class Gyro : INotifyPropertyChanged
                {
                    [field: NonSerialized]
                    public event PropertyChangedEventHandler PropertyChanged;
                    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                    {
                        if (PropertyChanged != null)
                        {
                            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                        }
                    }
                    
                    private Int32 _Gx;
                    public Int32 Gx
                    {
                        get { return this._Gx; }
                        set { if (value != this._Gx) { this._Gx = value; NotifyPropertyChanged(); } }
                    }

                    private Int32 _Gy;
                    public Int32 Gy
                    {
                        get { return this._Gy; }
                        set { if (value != this._Gy) { this._Gy = value; NotifyPropertyChanged(); } }
                    }

                    private Int32 _Gz;
                    public Int32 Gz
                    {
                        get { return this._Gz; }
                        set { if (value != this._Gz) { this._Gz = value; NotifyPropertyChanged(); } }
                    }

                    //public Gyro()
                    //{
                    //    // Empty constructor required to compile.
                    //}
                    // Implement this method to serialize data. The method is called 
                    // on serialization.
                    //public void GetObjectData(SerializationInfo info, StreamingContext context)
                    //{
                    //    // Use the AddValue method to specify serialized values.
                    //    info.AddValue("props", _Gx, typeof(Int32));
                    //    info.AddValue("props", _Gy, typeof(Int32));
                    //    info.AddValue("props", _Gz, typeof(Int32));
                    //}
                    //// The special constructor is used to deserialize values.
                    //public Gyro(SerializationInfo info, StreamingContext context)
                    //{
                    //    // Reset the property value using the GetValue method.
                    //    _Gx = (Int32)info.GetValue("props", typeof(Int32));
                    //    _Gy = (Int32)info.GetValue("props", typeof(Int32));
                    //    _Gz = (Int32)info.GetValue("props", typeof(Int32));
                    //}
                }

                [Serializable]
                public class Magne : INotifyPropertyChanged
                {
                    [field: NonSerialized]
                    public event PropertyChangedEventHandler PropertyChanged;
                    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                    {
                        if (PropertyChanged != null)
                        {
                            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                        }
                    }
                    
                    private Int32 _Mx;
                    public Int32 Mx
                    {
                        get { return this._Mx; }
                        set { if (value != this._Mx) { this._Mx = value; NotifyPropertyChanged(); } }
                    }

                    private Int32 _My;
                    public Int32 My
                    {
                        get { return this._My; }
                        set { if (value != this._My) { this._My = value; NotifyPropertyChanged(); } }
                    }

                    private Int32 _Mz;
                    public Int32 Mz
                    {
                        get { return this._Mz; }
                        set { if (value != this._Mz) { this._Mz = value; NotifyPropertyChanged(); } }
                    }

                    //public Magne()
                    //{
                    //    // Empty constructor required to compile.
                    //}
                    // Implement this method to serialize data. The method is called 
                    // on serialization.
                    //public void GetObjectData(SerializationInfo info, StreamingContext context)
                    //{
                    //    // Use the AddValue method to specify serialized values.
                    //    info.AddValue("props", _Mx, typeof(Int32));
                    //    info.AddValue("props", _My, typeof(Int32));
                    //    info.AddValue("props", _Mz, typeof(Int32));
                    //}
                    //// The special constructor is used to deserialize values.
                    //public Magne(SerializationInfo info, StreamingContext context)
                    //{
                    //    // Reset the property value using the GetValue method.
                    //    _Mx = (Int32)info.GetValue("props", typeof(Int32));
                    //    _My = (Int32)info.GetValue("props", typeof(Int32));
                    //    _Mz = (Int32)info.GetValue("props", typeof(Int32));
                    //}
                }

                //[field: NonSerialized]
                //public Acce acce = new Acce();
                //[field: NonSerialized]
                //public Gyro gyro = new Gyro();
                //[field: NonSerialized]
                //public Magne magne = new Magne();

                [field: NonSerialized]
                private Acce _acce;
                public Acce acce
                {
                    get { return this._acce; }
                    set { if (value != this._acce) { this._acce = value; NotifyPropertyChanged(); } }
                }

                [field: NonSerialized]
                private Gyro _gyro;
                public Gyro gyro
                {
                    get { return this._gyro; }
                    set { if (value != this._gyro) { this._gyro = value; NotifyPropertyChanged(); } }
                }

                [field: NonSerialized]
                private Magne _magne;
                public Magne magne
                {
                    get { return this._magne; }
                    set { if (value != this._magne) { this._magne = value; NotifyPropertyChanged(); } }
                }

                [field: NonSerialized]
                public MEMs()
                {
                    _acce = new Acce();
                    _gyro = new Gyro();
                    _magne = new Magne();
                }
                // Implement this method to serialize data. The method is called 
                // on serialization.
                //public void GetObjectData(SerializationInfo info, StreamingContext context)
                //{
                //    // Use the AddValue method to specify serialized values.
                //    info.AddValue("props", _acce, typeof(Acce));
                //    info.AddValue("props", _gyro, typeof(Gyro));
                //    info.AddValue("props", _magne, typeof(Magne));

                //}
                //// The special constructor is used to deserialize values.
                //public MEMs(SerializationInfo info, StreamingContext context)
                //{
                //    // Reset the property value using the GetValue method.
                //    _acce = (Acce)info.GetValue("props", typeof(Acce));
                //    _gyro = (Gyro)info.GetValue("props", typeof(Gyro));
                //    _magne = (Magne)info.GetValue("props", typeof(Magne));
                //}
            }

            [Serializable]
            public class GPS : INotifyPropertyChanged
            {
                [field: NonSerialized]
                public event PropertyChangedEventHandler PropertyChanged;
                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
                {
                    if (PropertyChanged != null)
                    {
                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    }
                }
                
                private byte _hour;
                public byte hour
                {
                    get { return this._hour; }
                    set { if (value != this._hour) { this._hour = value; NotifyPropertyChanged(); } }
                }

                private byte _minute;
                public byte minute
                {
                    get { return this._minute; }
                    set { if (value != this._minute) { this._minute = value; NotifyPropertyChanged(); } }
                }

                private byte _seconds;
                public byte seconds
                {
                    get { return this._seconds; }
                    set { if (value != this._seconds) { this._seconds = value; NotifyPropertyChanged(); } }
                }

                private byte _year;
                public byte year
                {
                    get { return this._year; }
                    set { if (value != this._year) { this._year = value; NotifyPropertyChanged(); } }
                }

                private byte _month;
                public byte month
                {
                    get { return this._month; }
                    set { if (value != this._month) { this._month = value; NotifyPropertyChanged(); } }
                }

                private byte _day;
                public byte day
                {
                    get { return this._day; }
                    set { if (value != this._day) { this._day = value; NotifyPropertyChanged(); } }
                }

                private UInt16 _milliseconds;
                public UInt16 milliseconds
                {
                    get { return this._milliseconds; }
                    set { if (value != this._milliseconds) { this._milliseconds = value; NotifyPropertyChanged(); } }
                }

                private float _latitude;
                public float latitude
                {
                    get { return this._latitude; }
                    set { if (value != this._latitude) { this._latitude = value; NotifyPropertyChanged(); } }
                }

                private float _longitude;
                public float longitude
                {
                    get { return this._longitude; }
                    set { if (value != this._longitude) { this._longitude = value; NotifyPropertyChanged(); } }
                }

                private Int32 _latitude_fixed;
                public Int32 latitude_fixed
                {
                    get { return this._latitude_fixed; }
                    set { if (value != this._latitude_fixed) { this._latitude_fixed = value; NotifyPropertyChanged(); } }
                }

                private Int32 _longitude_fixed;
                public Int32 longitude_fixed
                {
                    get { return this._longitude_fixed; }
                    set { if (value != this._longitude_fixed) { this._longitude_fixed = value; NotifyPropertyChanged(); } }
                }

                private float _latitudeDegrees;
                public float latitudeDegrees
                {
                    get { return this._latitudeDegrees; }
                    set { if (value != this._latitudeDegrees) { this._latitudeDegrees = value; NotifyPropertyChanged(); } }
                }

                private float _longitudeDegrees;
                public float longitudeDegrees
                {
                    get { return this._longitudeDegrees; }
                    set { if (value != this._longitudeDegrees) { this._longitudeDegrees = value; NotifyPropertyChanged(); } }
                }

                private float _geoidheight;
                public float geoidheight
                {
                    get { return this._geoidheight; }
                    set { if (value != this._geoidheight) { this._geoidheight = value; NotifyPropertyChanged(); } }
                }

                private float _altitude;
                public float altitude
                {
                    get { return this._altitude; }
                    set { if (value != this._altitude) { this._altitude = value; NotifyPropertyChanged(); } }
                }

                private float _speed;
                public float speed
                {
                    get { return this._speed; }
                    set { if (value != this._speed) { this._speed = value; NotifyPropertyChanged(); } }
                }

                private float _angle;
                public float angle
                {
                    get { return this._angle; }
                    set { if (value != this._angle) { this._angle = value; NotifyPropertyChanged(); } }
                }

                private float _magvariation;
                public float magvariation
                {
                    get { return this._magvariation; }
                    set { if (value != this._magvariation) { this._magvariation = value; NotifyPropertyChanged(); } }
                }

                private float _HDOP;
                public float HDOP
                {
                    get { return this._HDOP; }
                    set { if (value != this._HDOP) { this._HDOP = value; NotifyPropertyChanged(); } }
                }

                private char _lat;
                public char lat
                {
                    get { return this._lat; }
                    set { if (value != this._lat) { this._lat = value; NotifyPropertyChanged(); } }
                }

                private char _lon;
                public char lon
                {
                    get { return this._lon; }
                    set { if (value != this._lon) { this._lon = value; NotifyPropertyChanged(); } }
                }

                private char _mag;
                public char mag
                {
                    get { return this._mag; }
                    set { if (value != this._mag) { this._mag = value; NotifyPropertyChanged(); } }
                }

                private byte _fixquality;
                public byte fixquality
                {
                    get { return this._fixquality; }
                    set { if (value != this._fixquality) { this._fixquality = value; NotifyPropertyChanged(); } }
                }

                private byte _satellites;
                public byte satellites
                {
                    get { return this._satellites; }
                    set { if (value != this._satellites) { this._satellites = value; NotifyPropertyChanged(); } }
                }

                //public GPS()
                //{
                //    // Empty constructor required to compile.
                //}
                // Implement this method to serialize data. The method is called 
                // on serialization.
                //public void GetObjectData(SerializationInfo info, StreamingContext context)
                //{
                //    // Use the AddValue method to specify serialized values.
                //    info.AddValue("props", _hour, typeof(byte));
                //    info.AddValue("props", _minute, typeof(byte));
                //    info.AddValue("props", _seconds, typeof(byte));
                //    info.AddValue("props", _year, typeof(byte));
                //    info.AddValue("props", _month, typeof(byte));
                //    info.AddValue("props", _day, typeof(byte));
                //    info.AddValue("props", _milliseconds, typeof(UInt16));
                //    info.AddValue("props", _latitude, typeof(float));
                //    info.AddValue("props", _longitude, typeof(float));
                //    info.AddValue("props", _latitude_fixed, typeof(Int32));
                //    info.AddValue("props", _longitude_fixed, typeof(Int32));
                //    info.AddValue("props", _latitudeDegrees, typeof(float));
                //    info.AddValue("props", _longitudeDegrees, typeof(float));
                //    info.AddValue("props", _geoidheight, typeof(float));
                //    info.AddValue("props", _altitude, typeof(float));
                //    info.AddValue("props", _speed, typeof(float));
                //    info.AddValue("props", _angle, typeof(float));
                //    info.AddValue("props", _magvariation, typeof(float));
                //    info.AddValue("props", _HDOP, typeof(float));
                //    info.AddValue("props", _lat, typeof(char));
                //    info.AddValue("props", _lon, typeof(char));
                //    info.AddValue("props", _mag, typeof(char));
                //    info.AddValue("props", _fixquality, typeof(byte));
                //    info.AddValue("props", _satellites, typeof(byte));
                //}
                //// The special constructor is used to deserialize values.
                //public GPS(SerializationInfo info, StreamingContext context)
                //{
                //    // Reset the property value using the GetValue method.
                //    _hour = (byte)info.GetValue("props", typeof(byte));
                //    _minute = (byte)info.GetValue("props", typeof(byte));
                //    _seconds = (byte)info.GetValue("props", typeof(byte));
                //    _year = (byte)info.GetValue("props", typeof(byte));
                //    _month = (byte)info.GetValue("props", typeof(byte));
                //    _day = (byte)info.GetValue("props", typeof(byte));
                //    _milliseconds = (UInt16)info.GetValue("props", typeof(UInt16));
                //    _latitude = (float)info.GetValue("props", typeof(float));
                //    _longitude = (float)info.GetValue("props", typeof(float));
                //    _latitude_fixed = (Int32)info.GetValue("props", typeof(Int32));
                //    _longitude_fixed = (Int32)info.GetValue("props", typeof(Int32));
                //    _latitudeDegrees = (float)info.GetValue("props", typeof(float));
                //    _longitudeDegrees = (float)info.GetValue("props", typeof(float));
                //    _geoidheight = (float)info.GetValue("props", typeof(float));
                //    _altitude = (float)info.GetValue("props", typeof(float));
                //    _speed = (float)info.GetValue("props", typeof(float));
                //    _angle = (float)info.GetValue("props", typeof(float));
                //    _magvariation = (float)info.GetValue("props", typeof(float));
                //    _HDOP = (float)info.GetValue("props", typeof(float));
                //    _lat = (char)info.GetValue("props", typeof(char));
                //    _lon = (char)info.GetValue("props", typeof(char));
                //    _mag = (char)info.GetValue("props", typeof(char));
                //    _fixquality = (byte)info.GetValue("props", typeof(byte));
                //    _satellites = (byte)info.GetValue("props", typeof(byte));
                //}
            }

            [field: NonSerialized]
            private Canbus _canbus;
            public Canbus canbus
            {
                get { return this._canbus; }
                set { if (value != this._canbus) { this._canbus = value; NotifyPropertyChanged(); } }
            }

            [field: NonSerialized]
            private MEMs _mems;
            public MEMs mems
            {
                get { return this._mems; }
                set { if (value != this._mems) { this._mems = value; NotifyPropertyChanged(); } }
            }

            [field: NonSerialized]
            private GPS _gps;
            public GPS gps
            {
                get { return this._gps; }
                set { if (value != this._gps) { this._gps = value; NotifyPropertyChanged(); } }
            }

            [field: NonSerialized]
            public Modules()
            {
                _canbus = new Canbus();
                _mems = new MEMs();
                _gps = new GPS();
            }
            // Implement this method to serialize data. The method is called 
            // on serialization.
            //public void GetObjectData(SerializationInfo info, StreamingContext context)
            //{
            //    // Use the AddValue method to specify serialized values.
            //    info.AddValue("props", _canbus, typeof(Canbus));
            //    info.AddValue("props", _mems, typeof(MEMs));
            //    info.AddValue("props", _gps, typeof(GPS));

            //}
            //// The special constructor is used to deserialize values.
            //public Modules(SerializationInfo info, StreamingContext context)
            //{
            //    // Reset the property value using the GetValue method.
            //    _canbus = (Canbus)info.GetValue("props", typeof(Canbus));
            //    _mems = (MEMs)info.GetValue("props", typeof(MEMs));
            //    _gps = (GPS)info.GetValue("props", typeof(GPS));
            //}
        }

        //[field: NonSerialized]
        //public TimeStamp timeStamp = new TimeStamp();
        //[field: NonSerialized]
        //public  Modules modules = new Modules();

        [field: NonSerialized]
        private TimeStamp _timeStamp;
        public TimeStamp timeStamp
        {
            get { return this._timeStamp; }
            set { if (value != this._timeStamp) { this._timeStamp = value; NotifyPropertyChanged(); } }
        }

        [field: NonSerialized]
        private Modules _modules;
        public Modules modules
        {
            get { return this._modules; }
            set { if (value != this._modules) { this._modules = value; NotifyPropertyChanged(); } }
        }

        // Implement this method to serialize data. The method is called 
        // on serialization.
        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    // Use the AddValue method to specify serialized values.
        //    info.AddValue("props", _timeStamp, typeof(TimeStamp));
        //    info.AddValue("props", _modules, typeof(Modules));

        //}
        //// The special constructor is used to deserialize values.
        //public Telemetry(SerializationInfo info, StreamingContext context)
        //{
        //    // Reset the property value using the GetValue method.
        //    _timeStamp = (TimeStamp)info.GetValue("props", typeof(TimeStamp));
        //    _modules = (Modules)info.GetValue("props", typeof(Modules));
        //}
        [field: NonSerialized]
        public Telemetry()
        {
            _timeStamp = new TimeStamp();
            _modules = new Modules();
        }
       
        public void CopyByteArrayToThis(byte[] byteArray)
        {
            if (byteArray.Length >= Utils.Utils.SerializeToByteArray(this).Length)
            {
                ////TimeStamp
                int i = 0;
                this.timeStamp.date.WeekDay = byteArray[i++];
                this.timeStamp.date.Month = byteArray[i++];
                this.timeStamp.date.Day = byteArray[i++];
                this.timeStamp.date.Year = byteArray[i++];

                this.timeStamp.time.Hour = byteArray[i++];
                this.timeStamp.time.Minute = byteArray[i++];
                this.timeStamp.time.Second = byteArray[i++];

                /////CanBus
                this.modules.canbus.Identification_Number = System.Text.Encoding.UTF8.GetString(byteArray, i, 17);
                i += 17;
                this.modules.canbus.Calculated_Engine_Load = byteArray[i++]; // (byte)((int)((int)255 * (int)byteArray[i++]) / (int)100);
                this.modules.canbus.Engine_Temperature = byteArray[i++];
                this.modules.canbus.Fuel_Level = byteArray[i++];
                this.modules.canbus.Speed = byteArray[i++];
                this.modules.canbus.Throttle_Position_B = byteArray[i++];
                this.modules.canbus.Throttle_Position_C = byteArray[i++];
                this.modules.canbus.Intake_Manifold_Pressure = byteArray[i++];
                this.modules.canbus.Fuel_Consumption = byteArray[i++];
                this.modules.canbus.RealTime_Fuel_Consumption = byteArray[i++];
                this.modules.canbus.Spark_Advance_Angle = byteArray[i++];
                this.modules.canbus.Fuel_Correction_Value = byteArray[i++];
                this.modules.canbus.RPM = BitConverter.ToUInt16(byteArray, i);
                i += 2;
                this.modules.canbus.Intake_Air_Temperature = BitConverter.ToInt16(byteArray, i);
                i += 2;
                this.modules.canbus.Mass_Air_Flow_Rate = BitConverter.ToUInt16(byteArray, i);
                i += 2;
                this.modules.canbus.Total_Distance = BitConverter.ToUInt16(byteArray, i);
                i += 2;
                this.modules.canbus.Control_Module_Voltage = BitConverter.ToUInt16(byteArray, i);
                i += 2;

                //////MEMs
                this.modules.mems.acce.Ax = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.mems.acce.Ay = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.mems.acce.Az = BitConverter.ToInt32(byteArray, i);
                i += 4;

                this.modules.mems.gyro.Gx = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.mems.gyro.Gy = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.mems.gyro.Gz = BitConverter.ToInt32(byteArray, i);
                i += 4;

                this.modules.mems.magne.Mx = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.mems.magne.My = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.mems.magne.Mz = BitConverter.ToInt32(byteArray, i);
                i += 4;

                ////GPS

                this.modules.gps.hour = byteArray[i++];
                this.modules.gps.minute = byteArray[i++];
                this.modules.gps.seconds = byteArray[i++];
                this.modules.gps.year = byteArray[i++];
                this.modules.gps.month = byteArray[i++];
                this.modules.gps.day = byteArray[i++];
                this.modules.gps.hour = byteArray[i++];
                this.modules.gps.hour = byteArray[i++];
                this.modules.gps.milliseconds = BitConverter.ToUInt16(byteArray, i);
                i += 2;

                this.modules.gps.latitude = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.longitude = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.latitude_fixed = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.gps.longitude_fixed = BitConverter.ToInt32(byteArray, i);
                i += 4;
                this.modules.gps.latitudeDegrees = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.longitudeDegrees = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.geoidheight = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.altitude = BitConverter.ToSingle(byteArray, i);
                i += 4;

                this.modules.gps.speed = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.angle = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.magvariation = BitConverter.ToSingle(byteArray, i);
                i += 4;
                this.modules.gps.HDOP = BitConverter.ToSingle(byteArray, i);
                i += 4;

                this.modules.gps.lat = (char)byteArray[i++];
                this.modules.gps.lon = (char)byteArray[i++];
                this.modules.gps.mag = (char)byteArray[i++];

                this.modules.gps.fixquality = byteArray[i++];
                this.modules.gps.satellites = byteArray[i++];
            }
        }
        public Dictionary<PropertyInfo, object> GetAllInstancePropertyInfos()
        {
            Dictionary<PropertyInfo, object> pis = new Dictionary<PropertyInfo, object>();

            BindingFlags bindingFlags = BindingFlags.Public /* | */
                                                            /*  BindingFlags.NonPublic | */
                                                            /* BindingFlags.Instance */ /* |
                                                             BindingFlags.Static */ ;

            List<object> instances = GetInstances(this, bindingFlags);

            foreach (object i in instances)
            {
                Dictionary<PropertyInfo, object> ps = GetPropertyInfos(i, null);
                foreach (var v in ps)
                {
                    pis.Add(v.Key, i);
                }
            }

            return pis;
        }
        private List<object> GetInstances(object myInstance, BindingFlags bindingFlags)
        {
            List<object> objects = new List<object>();
            //myObjects.AddRange(tempObjs);

            foreach (object o in myInstance.GetType().GetFields(bindingFlags).Select(field => field.GetValue(myInstance)).ToList())
            {
                objects.Add(o);
                List<object> os = GetInstances(o, bindingFlags);
                if (os.Count != 0)
                {
                    objects.AddRange(os);
                }
            }

            return objects;
        }
        public Dictionary<PropertyInfo, object> GetPropertyInfos(object myClass, List<string> Exceptions)
        {
            Dictionary<PropertyInfo, object> propertyInfos = new Dictionary<PropertyInfo, object>();
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
        public void Reset()
        {
            //Dictionary<PropertyInfo, object> pis = GetAllInstancePropertyInfos(); 
            //foreach(KeyValuePair<PropertyInfo, object> kvp in pis)
            //{
            //    var resetValue = 0;
            //    kvp.Key.SetValue(kvp.Value, null);
            //}

            Dictionary<PropertyInfo, object> instanceProps = this.GetPropertyInfos(this, null);
            foreach (KeyValuePair<PropertyInfo, object> entry in instanceProps)
            {
                entry.Key.SetValue(entry.Value, null);
            }
        }
        //public byte[] ObjectToByteArray(Object obj)
        //{
        //    if (obj == null)
        //        return null;
        //    BinaryFormatter bf = new BinaryFormatter();
        //    MemoryStream ms = new MemoryStream();
        //    bf.Serialize(ms, obj);
        //    return ms.ToArray();
        //}
        //public dynamic ByteArrayToObject(byte[] arrBytes)
        //{
        //    MemoryStream memStream = new MemoryStream();
        //    BinaryFormatter binForm = new BinaryFormatter();
        //    memStream.Write(arrBytes, 0, arrBytes.Length);
        //    memStream.Seek(0, SeekOrigin.Begin);
        //    var obj = binForm.Deserialize(memStream);
        //    return obj;
        //    //return Convert.ChangeType(obj, typ);
        //}
        public void Serialize()
        {
            string fileName = "dataStuff.myData";

            // Use a BinaryFormatter or SoapFormatter.
            IFormatter formatter = new BinaryFormatter();
            //IFormatter formatter = new SoapFormatter();

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, this);
            s.Close();
        }
        public void DeserializeItem()
        {
            string fileName = "dataStuff.myData";

            // Use a BinaryFormatter or SoapFormatter.
            IFormatter formatter = new BinaryFormatter();
            //IFormatter formatter = new SoapFormatter();

            FileStream s = new FileStream(fileName, FileMode.Open);
            Telemetry ttt  = (Telemetry)formatter.Deserialize(s);
            //Console.WriteLine(t.MyProperty);
        }

        public byte[] SerializeObject<T>(T serializableObject)
        {
            T obj = serializableObject;

            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        public T DeserializeObject<T>(byte[] serilizedBytes)
        {
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream(serilizedBytes))
            {
                return (T)formatter.Deserialize(stream);
            }
        }
    }

    public static class ObjectExtension
    {
        public static T CopyObject<T>(this object objSource)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, objSource);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }

        }
    }
}




































































////////////////using System;
////////////////using System.Collections;
////////////////using System.Collections.Generic;
////////////////using System.ComponentModel;
////////////////using System.IO;
////////////////using System.Linq;
////////////////using System.Reflection;
////////////////using System.Runtime.CompilerServices;
////////////////using System.Runtime.Serialization;
////////////////using System.Runtime.Serialization.Formatters.Binary;
////////////////using System.Text;
////////////////using System.Threading.Tasks;

////////////////namespace SimpleUDPListner
////////////////{
////////////////    public class Telemetry : INotifyPropertyChanged
////////////////    {
////////////////        public event PropertyChangedEventHandler PropertyChanged;
////////////////        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////        {
////////////////            if (PropertyChanged != null)
////////////////            {
////////////////                //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////            }
////////////////        }
        
////////////////        public class TimeStamp : INotifyPropertyChanged
////////////////        {
////////////////            public event PropertyChangedEventHandler PropertyChanged;
////////////////            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////            {
////////////////                if (PropertyChanged != null)
////////////////                {
////////////////                    //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                }
////////////////            }
            
////////////////            public class Date : INotifyPropertyChanged
////////////////            {
////////////////                public event PropertyChangedEventHandler PropertyChanged;                
////////////////                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                {
////////////////                    if (PropertyChanged != null)
////////////////                    {
////////////////                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                    }
////////////////                }
                
////////////////                private byte _WeekDay;
////////////////                public byte WeekDay
////////////////                {
////////////////                    get { return this._WeekDay; }
////////////////                    set { if (value != this._WeekDay) { this._WeekDay = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Month;
////////////////                public byte Month
////////////////                {
////////////////                    get { return this._Month; }
////////////////                    set { if (value != this._Month) { this._Month = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Day;
////////////////                public byte Day
////////////////                {
////////////////                    get { return this._Day; }
////////////////                    set { if (value != this._Day) { this._Day = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Year;
////////////////                public byte Year
////////////////                {
////////////////                    get { return this._Year; }
////////////////                    set { if (value != this._Year) { this._Year = value; NotifyPropertyChanged(); } }
////////////////                }
////////////////            }
            
////////////////            public class Time : INotifyPropertyChanged
////////////////            {
////////////////                public event PropertyChangedEventHandler PropertyChanged;                
////////////////                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                {
////////////////                    if (PropertyChanged != null)
////////////////                    {
////////////////                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                    }
////////////////                }

////////////////                private byte _Hour;
////////////////                public byte Hour
////////////////                {
////////////////                    get { return this._Hour; }
////////////////                    set { if (value != this._Hour) { this._Hour = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Minute;
////////////////                public byte Minute
////////////////                {
////////////////                    get { return this._Minute; }
////////////////                    set { if (value != this._Minute) { this._Minute = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Second;
////////////////                public byte Second
////////////////                {
////////////////                    get { return this._Second; }
////////////////                    set { if (value != this._Second) { this._Second = value; NotifyPropertyChanged(); } }
////////////////                }
////////////////            }
            
////////////////            public Date date = new Date();
////////////////            public Time time = new Time();
////////////////        }
        
////////////////        public class Modules : INotifyPropertyChanged
////////////////        {
////////////////            public event PropertyChangedEventHandler PropertyChanged;
////////////////            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////            {
////////////////                if (PropertyChanged != null)
////////////////                {
////////////////                    //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                }
////////////////            }
            
////////////////            public class Canbus : INotifyPropertyChanged
////////////////            {
////////////////                public event PropertyChangedEventHandler PropertyChanged;
////////////////                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                {
////////////////                    if (PropertyChanged != null)
////////////////                    {
////////////////                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                    }
////////////////                }
                
////////////////                private string _Identification_Number;
////////////////                public string Identification_Number
////////////////                {
////////////////                    get { return this._Identification_Number; }
////////////////                    set { if (value != this._Identification_Number) { this._Identification_Number = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Calculated_Engine_Load;
////////////////                public byte Calculated_Engine_Load
////////////////                {
////////////////                    get { return this._Calculated_Engine_Load; }
////////////////                    set { if (value != this._Calculated_Engine_Load) { this._Calculated_Engine_Load = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Engine_Temperature;
////////////////                public byte Engine_Temperature
////////////////                {
////////////////                    get { return this._Engine_Temperature; }
////////////////                    set { if (value != this._Engine_Temperature) { this._Engine_Temperature = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Fuel_Level;
////////////////                public byte Fuel_Level
////////////////                {
////////////////                    get { return this._Fuel_Level; }
////////////////                    set { if (value != this._Fuel_Level) { this._Fuel_Level = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Speed;
////////////////                public byte Speed
////////////////                {
////////////////                    get { return this._Speed; }
////////////////                    set { if (value != this._Speed) { this._Speed = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Throttle_Position_B;
////////////////                public byte Throttle_Position_B
////////////////                {
////////////////                    get { return this._Throttle_Position_B; }
////////////////                    set { if (value != this._Throttle_Position_B) { this._Throttle_Position_B = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Throttle_Position_C;
////////////////                public byte Throttle_Position_C
////////////////                {
////////////////                    get { return this._Throttle_Position_C; }
////////////////                    set { if (value != this._Throttle_Position_C) { this._Throttle_Position_C = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Intake_Manifold_Pressure;
////////////////                public byte Intake_Manifold_Pressure
////////////////                {
////////////////                    get { return this._Intake_Manifold_Pressure; }
////////////////                    set { if (value != this._Intake_Manifold_Pressure) { this._Intake_Manifold_Pressure = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Fuel_Consumption;
////////////////                public byte Fuel_Consumption
////////////////                {
////////////////                    get { return this._Fuel_Consumption; }
////////////////                    set { if (value != this._Fuel_Consumption) { this._Fuel_Consumption = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _RealTime_Fuel_Consumption;
////////////////                public byte RealTime_Fuel_Consumption
////////////////                {
////////////////                    get { return this._RealTime_Fuel_Consumption; }
////////////////                    set { if (value != this._RealTime_Fuel_Consumption) { this._RealTime_Fuel_Consumption = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Spark_Advance_Angle;
////////////////                public byte Spark_Advance_Angle
////////////////                {
////////////////                    get { return this._Spark_Advance_Angle; }
////////////////                    set { if (value != this._Spark_Advance_Angle) { this._Spark_Advance_Angle = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _Fuel_Correction_Value;
////////////////                public byte Fuel_Correction_Value
////////////////                {
////////////////                    get { return this._Fuel_Correction_Value; }
////////////////                    set { if (value != this._Fuel_Correction_Value) { this._Fuel_Correction_Value = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private UInt16 _RPM;
////////////////                public UInt16 RPM
////////////////                {
////////////////                    get { return this._RPM; }
////////////////                    set { if (value != this._RPM) { this._RPM = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private Int16 _Intake_Air_Temperature;
////////////////                public Int16 Intake_Air_Temperature
////////////////                {
////////////////                    get { return this._Intake_Air_Temperature; }
////////////////                    set { if (value != this._Intake_Air_Temperature) { this._Intake_Air_Temperature = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private UInt16 _Mass_Air_Flow_Rate;
////////////////                public UInt16 Mass_Air_Flow_Rate
////////////////                {
////////////////                    get { return this._Mass_Air_Flow_Rate; }
////////////////                    set { if (value != this._Mass_Air_Flow_Rate) { this._Mass_Air_Flow_Rate = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private UInt16 _Total_Distance;
////////////////                public UInt16 Total_Distance
////////////////                {
////////////////                    get { return this._Total_Distance; }
////////////////                    set { if (value != this._Total_Distance) { this._Total_Distance = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private UInt16 _Control_Module_Voltage;
////////////////                public UInt16 Control_Module_Voltage
////////////////                {
////////////////                    get { return this._Control_Module_Voltage; }
////////////////                    set { if (value != this._Control_Module_Voltage) { this._Control_Module_Voltage = value; NotifyPropertyChanged(); } }
////////////////                }
////////////////            }
            
////////////////            public class MEMs : INotifyPropertyChanged
////////////////            {
////////////////                public event PropertyChangedEventHandler PropertyChanged;
////////////////                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                {
////////////////                    if (PropertyChanged != null)
////////////////                    {
////////////////                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                    }
////////////////                }
                
////////////////                public class Acce : INotifyPropertyChanged
////////////////                {
////////////////                    [field:NonSerialized]
////////////////                    public event PropertyChangedEventHandler PropertyChanged;
////////////////                    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                    {
////////////////                        if (PropertyChanged != null)
////////////////                        {
////////////////                            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                        }
////////////////                    }
                                       
////////////////                    private Int32 _Ax;
////////////////                    public Int32 Ax
////////////////                    {
////////////////                        get { return this._Ax; }
////////////////                        set { if (value != this._Ax) { this._Ax = value; NotifyPropertyChanged(); } }
////////////////                    }

////////////////                    private Int32 _Ay;
////////////////                    public Int32 Ay
////////////////                    {
////////////////                        get { return this._Ay; }
////////////////                        set { if (value != this._Ay) { this._Ay = value; NotifyPropertyChanged(); } }
////////////////                    }

////////////////                    private Int32 _Az;
////////////////                    public Int32 Az
////////////////                    {
////////////////                        get { return this._Az; }
////////////////                        set { if (value != this._Az) { this._Az = value; NotifyPropertyChanged(); } }
////////////////                    }
////////////////                }
                
////////////////                public class Gyro : INotifyPropertyChanged
////////////////                {
////////////////                    public event PropertyChangedEventHandler PropertyChanged;
////////////////                    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                    {
////////////////                        if (PropertyChanged != null)
////////////////                        {
////////////////                            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                        }
////////////////                    }
                    
////////////////                    private Int32 _Gx;
////////////////                    public Int32 Gx
////////////////                    {
////////////////                        get { return this._Gx; }
////////////////                        set { if (value != this._Gx) { this._Gx = value; NotifyPropertyChanged(); } }
////////////////                    }

////////////////                    private Int32 _Gy;
////////////////                    public Int32 Gy
////////////////                    {
////////////////                        get { return this._Gy; }
////////////////                        set { if (value != this._Gy) { this._Gy = value; NotifyPropertyChanged(); } }
////////////////                    }

////////////////                    private Int32 _Gz;
////////////////                    public Int32 Gz
////////////////                    {
////////////////                        get { return this._Gz; }
////////////////                        set { if (value != this._Gz) { this._Gz = value; NotifyPropertyChanged(); } }
////////////////                    }
////////////////                }
                
////////////////                public class Magne : INotifyPropertyChanged
////////////////                {
////////////////                    public event PropertyChangedEventHandler PropertyChanged;
////////////////                    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                    {
////////////////                        if (PropertyChanged != null)
////////////////                        {
////////////////                            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                        }
////////////////                    }
                    
////////////////                    private Int32 _Mx;
////////////////                    public Int32 Mx
////////////////                    {
////////////////                        get { return this._Mx; }
////////////////                        set { if (value != this._Mx) { this._Mx = value; NotifyPropertyChanged(); } }
////////////////                    }

////////////////                    private Int32 _My;
////////////////                    public Int32 My
////////////////                    {
////////////////                        get { return this._My; }
////////////////                        set { if (value != this._My) { this._My = value; NotifyPropertyChanged(); } }
////////////////                    }

////////////////                    private Int32 _Mz;
////////////////                    public Int32 Mz
////////////////                    {
////////////////                        get { return this._Mz; }
////////////////                        set { if (value != this._Mz) { this._Mz = value; NotifyPropertyChanged(); } }
////////////////                    }
////////////////                }

////////////////                public Acce acce = new Acce();
////////////////                public Gyro gyro = new Gyro();
////////////////                public Magne magne = new Magne();
////////////////            }
            
////////////////            public class GPS : INotifyPropertyChanged
////////////////            {
////////////////                public event PropertyChangedEventHandler PropertyChanged;
////////////////                private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
////////////////                {
////////////////                    if (PropertyChanged != null)
////////////////                    {
////////////////                        //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
////////////////                    }
////////////////                }
                
////////////////                private byte _hour;
////////////////                public byte hour
////////////////                {
////////////////                    get { return this._hour; }
////////////////                    set { if (value != this._hour) { this._hour = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _minute;
////////////////                public byte minute
////////////////                {
////////////////                    get { return this._minute; }
////////////////                    set { if (value != this._minute) { this._minute = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _seconds;
////////////////                public byte seconds
////////////////                {
////////////////                    get { return this._seconds; }
////////////////                    set { if (value != this._seconds) { this._seconds = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _year;
////////////////                public byte year
////////////////                {
////////////////                    get { return this._year; }
////////////////                    set { if (value != this._year) { this._year = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _month;
////////////////                public byte month
////////////////                {
////////////////                    get { return this._month; }
////////////////                    set { if (value != this._month) { this._month = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _day;
////////////////                public byte day
////////////////                {
////////////////                    get { return this._day; }
////////////////                    set { if (value != this._day) { this._day = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private UInt16 _milliseconds;
////////////////                public UInt16 milliseconds
////////////////                {
////////////////                    get { return this._milliseconds; }
////////////////                    set { if (value != this._milliseconds) { this._milliseconds = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _latitude;
////////////////                public float latitude
////////////////                {
////////////////                    get { return this._longitude; }
////////////////                    set { if (value != this._longitude) { this._longitude = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _longitude;
////////////////                public float longitude
////////////////                {
////////////////                    get { return this._longitude; }
////////////////                    set { if (value != this._longitude) { this._longitude = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private Int32 _latitude_fixed;
////////////////                public Int32 latitude_fixed
////////////////                {
////////////////                    get { return this._longitude_fixed; }
////////////////                    set { if (value != this._longitude_fixed) { this._longitude_fixed = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private Int32 _longitude_fixed;
////////////////                public Int32 longitude_fixed
////////////////                {
////////////////                    get { return this._longitude_fixed; }
////////////////                    set { if (value != this._longitude_fixed) { this._longitude_fixed = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _latitudeDegrees;
////////////////                public float latitudeDegrees
////////////////                {
////////////////                    get { return this._latitudeDegrees; }
////////////////                    set { if (value != this._latitudeDegrees) { this._latitudeDegrees = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _longitudeDegrees;
////////////////                public float longitudeDegrees
////////////////                {
////////////////                    get { return this._longitudeDegrees; }
////////////////                    set { if (value != this._longitudeDegrees) { this._longitudeDegrees = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _geoidheight;
////////////////                public float geoidheight
////////////////                {
////////////////                    get { return this._geoidheight; }
////////////////                    set { if (value != this._geoidheight) { this._geoidheight = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _altitude;
////////////////                public float altitude
////////////////                {
////////////////                    get { return this._altitude; }
////////////////                    set { if (value != this._altitude) { this._altitude = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _speed;
////////////////                public float speed
////////////////                {
////////////////                    get { return this._speed; }
////////////////                    set { if (value != this._speed) { this._speed = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _angle;
////////////////                public float angle
////////////////                {
////////////////                    get { return this._angle; }
////////////////                    set { if (value != this._angle) { this._angle = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _magvariation;
////////////////                public float magvariation
////////////////                {
////////////////                    get { return this._magvariation; }
////////////////                    set { if (value != this._magvariation) { this._magvariation = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private float _HDOP;
////////////////                public float HDOP
////////////////                {
////////////////                    get { return this._HDOP; }
////////////////                    set { if (value != this._HDOP) { this._HDOP = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private char _lat;
////////////////                public char lat
////////////////                {
////////////////                    get { return this._lat; }
////////////////                    set { if (value != this._lat) { this._lat = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private char _lon;
////////////////                public char lon
////////////////                {
////////////////                    get { return this._lon; }
////////////////                    set { if (value != this._lon) { this._lon = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private char _mag;
////////////////                public char mag
////////////////                {
////////////////                    get { return this._mag; }
////////////////                    set { if (value != this._mag) { this._mag = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _fixquality;
////////////////                public byte fixquality
////////////////                {
////////////////                    get { return this._fixquality; }
////////////////                    set { if (value != this._fixquality) { this._fixquality = value; NotifyPropertyChanged(); } }
////////////////                }

////////////////                private byte _satellites;
////////////////                public byte satellites
////////////////                {
////////////////                    get { return this._satellites; }
////////////////                    set { if (value != this._satellites) { this._satellites = value; NotifyPropertyChanged(); } }
////////////////                }
////////////////            }

////////////////            public Canbus canbus = new Canbus();
////////////////            public MEMs mems = new MEMs();
////////////////            public GPS gps = new GPS();
////////////////        }

////////////////        public TimeStamp timeStamp = new TimeStamp();
////////////////        public Modules modules = new Modules();
        
////////////////        public void CopyByteArrayToThis(byte[] byteArray)
////////////////        {
////////////////            if (byteArray.Length >= Utils.Utils.SerializeToByteArray(this).Length)
////////////////            {
////////////////                ////TimeStamp
////////////////                int i = 0;
////////////////                this.timeStamp.date.WeekDay = byteArray[i++];
////////////////                this.timeStamp.date.Month = byteArray[i++];
////////////////                this.timeStamp.date.Day = byteArray[i++];
////////////////                this.timeStamp.date.Year = byteArray[i++];

////////////////                this.timeStamp.time.Hour = byteArray[i++];
////////////////                this.timeStamp.time.Minute = byteArray[i++];
////////////////                this.timeStamp.time.Second = byteArray[i++];

////////////////                /////CanBus
////////////////                this.modules.canbus.Identification_Number = System.Text.Encoding.UTF8.GetString(byteArray, i, 17);
////////////////                i += 17;
////////////////                this.modules.canbus.Calculated_Engine_Load = byteArray[i++]; // (byte)((int)((int)255 * (int)byteArray[i++]) / (int)100);
////////////////                this.modules.canbus.Engine_Temperature = byteArray[i++];
////////////////                this.modules.canbus.Fuel_Level = byteArray[i++];
////////////////                this.modules.canbus.Speed = byteArray[i++];
////////////////                this.modules.canbus.Throttle_Position_B = byteArray[i++];
////////////////                this.modules.canbus.Throttle_Position_C = byteArray[i++];
////////////////                this.modules.canbus.Intake_Manifold_Pressure = byteArray[i++];
////////////////                this.modules.canbus.Fuel_Consumption = byteArray[i++];
////////////////                this.modules.canbus.RealTime_Fuel_Consumption = byteArray[i++];
////////////////                this.modules.canbus.Spark_Advance_Angle = byteArray[i++];
////////////////                this.modules.canbus.Fuel_Correction_Value = byteArray[i++];
////////////////                this.modules.canbus.RPM = BitConverter.ToUInt16(byteArray, i);
////////////////                i += 2;
////////////////                this.modules.canbus.Intake_Air_Temperature = BitConverter.ToInt16(byteArray, i);
////////////////                i += 2;
////////////////                this.modules.canbus.Mass_Air_Flow_Rate = BitConverter.ToUInt16(byteArray, i);
////////////////                i += 2;
////////////////                this.modules.canbus.Total_Distance = BitConverter.ToUInt16(byteArray, i);
////////////////                i += 2;
////////////////                this.modules.canbus.Control_Module_Voltage = BitConverter.ToUInt16(byteArray, i);
////////////////                i += 2;

////////////////                //////MEMs
////////////////                this.modules.mems.acce.Ax = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.mems.acce.Ay = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.mems.acce.Az = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;

////////////////                this.modules.mems.gyro.Gx = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.mems.gyro.Gy = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.mems.gyro.Gz = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;

////////////////                this.modules.mems.magne.Mx = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.mems.magne.My = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.mems.magne.Mz = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;

////////////////                ////GPS

////////////////                this.modules.gps.hour = byteArray[i++];
////////////////                this.modules.gps.minute = byteArray[i++];
////////////////                this.modules.gps.seconds = byteArray[i++];
////////////////                this.modules.gps.year = byteArray[i++];
////////////////                this.modules.gps.month = byteArray[i++];
////////////////                this.modules.gps.day = byteArray[i++];
////////////////                this.modules.gps.hour = byteArray[i++];
////////////////                this.modules.gps.hour = byteArray[i++];
////////////////                this.modules.gps.milliseconds = BitConverter.ToUInt16(byteArray, i);
////////////////                i += 2;

////////////////                this.modules.gps.latitude = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.longitude = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.latitude_fixed = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.longitude_fixed = BitConverter.ToInt32(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.latitudeDegrees = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.longitudeDegrees = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.geoidheight = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.altitude = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;

////////////////                this.modules.gps.speed = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.angle = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.magvariation = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;
////////////////                this.modules.gps.HDOP = BitConverter.ToSingle(byteArray, i);
////////////////                i += 4;

////////////////                this.modules.gps.lat = (char)byteArray[i++];
////////////////                this.modules.gps.lon = (char)byteArray[i++];
////////////////                this.modules.gps.mag = (char)byteArray[i++];

////////////////                this.modules.gps.fixquality = byteArray[i++];
////////////////                this.modules.gps.satellites = byteArray[i++];
////////////////            }
////////////////        }
////////////////        public Dictionary<PropertyInfo, object> GetPropertyInfos(object myClass, List<string> Exceptions)
////////////////        {
////////////////            Dictionary<PropertyInfo, object> propertyInfos = new Dictionary<PropertyInfo, object>();
////////////////            Dictionary<PropertyInfo, object> pi2 = new Dictionary<PropertyInfo, object>();
////////////////            Type type = myClass.GetType();

////////////////            foreach (PropertyInfo pinf in type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public |
////////////////                                                                BindingFlags.NonPublic).Where(p => p.GetGetMethod(true) != null && p.GetSetMethod(true) != null).ToArray())
////////////////            {
////////////////                if (Exceptions == null || !Exceptions.Contains(pinf.Name))
////////////////                {
////////////////                    if (!pinf.PropertyType.IsClass || pinf.PropertyType == typeof(string))
////////////////                    {
////////////////                        propertyInfos.Add(pinf, myClass);
////////////////                    }
////////////////                    else if (!pinf.PropertyType.IsArray && pinf.PropertyType.IsClass)
////////////////                    {
////////////////                        pi2 = GetPropertyInfos(pinf.GetValue(myClass), Exceptions);
////////////////                        if (pi2 != null)
////////////////                        {
////////////////                            foreach (KeyValuePair<PropertyInfo, object> entry in pi2)
////////////////                            {
////////////////                                propertyInfos.Add(entry.Key, entry.Value);
////////////////                            }
////////////////                        }
////////////////                    }
////////////////                }
////////////////            }

////////////////            return propertyInfos;
////////////////        }
////////////////        private List<object> GetInstances(object myInstance, BindingFlags bindingFlags)
////////////////        {
////////////////            List<object> objects = new List<object>();

////////////////            foreach (object o in myInstance.GetType().GetFields(bindingFlags).Select(field => field.GetValue(myInstance)).ToList())
////////////////            {
////////////////                objects.Add(o);
////////////////                List<object> os = GetInstances(o, bindingFlags);
////////////////                if (os.Count != 0)
////////////////                {
////////////////                    objects.AddRange(os);
////////////////                }
////////////////            }

////////////////            return objects;
////////////////        }        
////////////////        public Dictionary<PropertyInfo, object> GetAllInstancePropertyInfos()
////////////////        {
////////////////            Dictionary<PropertyInfo, object> pis = new Dictionary<PropertyInfo, object>();

////////////////            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static ;

////////////////            List<object> instances = GetInstances(this, bindingFlags);

////////////////            foreach (object i in instances)
////////////////            {
////////////////                Dictionary<PropertyInfo, object> ps = GetPropertyInfos(i, null);
////////////////                foreach (var v in ps)
////////////////                {
////////////////                    pis.Add(v.Key, i);
////////////////                }
////////////////            }

////////////////            return pis;
////////////////        }
////////////////        public void Reset()
////////////////        {
////////////////            Dictionary<PropertyInfo, object> pis = GetAllInstancePropertyInfos(); 
////////////////            foreach(KeyValuePair<PropertyInfo, object> kvp in pis)
////////////////            {
////////////////                var resetValue = 0;
////////////////                kvp.Key.SetValue(kvp.Value, null);
////////////////            }
////////////////        }        
////////////////    }
////////////////}
