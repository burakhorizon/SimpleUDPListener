using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public static class DataBindingHandlers
    {
        public static bool Delegator(Control ctl, Binding binding)
        {
            // Add the delegates to the event.
            bool retVal = true;
            if (ctl.AccessibleDescription == "currency")
            {
                binding.Format += new ConvertEventHandler(UInt32ToCurrencyString);
                binding.Parse += new ConvertEventHandler(CurrencyStringToUInt32);
            }
            else if (ctl.AccessibleDescription == "doubleCurrency")
            {
                binding.Format += new ConvertEventHandler(DoubleToCurrencyString);
                binding.Parse += new ConvertEventHandler(CurrencyStringToDouble);
            }
            else if (ctl.AccessibleDescription == "meters")
            {
                binding.Format += new ConvertEventHandler(ByteToMetersString);
                binding.Parse += new ConvertEventHandler(MetersStringToBye);
            }
            else if (ctl.AccessibleDescription == "doubleMeters")
            {
                binding.Format += new ConvertEventHandler(DoubleToMetersString);
                binding.Parse += new ConvertEventHandler(MetersStringToDouble);
            }
            else if (ctl.AccessibleDescription == "speed")
            {
                binding.Format += new ConvertEventHandler(ByteToSpeedString);
                binding.Parse += new ConvertEventHandler(SpeedStringToByte);
            }
            else if (ctl.AccessibleDescription == "doubleSpeed")
            {
                binding.Format += new ConvertEventHandler(DoubleToSpeedString);
                binding.Parse += new ConvertEventHandler(SpeedStringToDouble);
            }
            else if (ctl.AccessibleDescription == "minutes")
            {
                binding.Format += new ConvertEventHandler(UInt16ToMinutesString);
                binding.Parse += new ConvertEventHandler(MinutesStringToUInt16);
            }
            else if (ctl.AccessibleDescription == "doubleMinutes")
            {
                binding.Format += new ConvertEventHandler(DoubleToMinutesString);
                binding.Parse += new ConvertEventHandler(MinutesStringToDouble);
            }
            else if (ctl.AccessibleDescription == "seconds")
            {
                binding.Format += new ConvertEventHandler(UInt16ToSecondsString);
                binding.Parse += new ConvertEventHandler(SecondsStringToUInt16);
            }
            else if (ctl.AccessibleDescription == "doubleSeconds")
            {
                binding.Format += new ConvertEventHandler(DoubleToSecondsString);
                binding.Parse += new ConvertEventHandler(SecondsStringToDouble);
            }
            else if (ctl.AccessibleDescription == "ratio")
            {
                binding.Format += new ConvertEventHandler(ByteToRatioString);
                binding.Parse += new ConvertEventHandler(RatioStringToByte);
            }
            else if (ctl.AccessibleDescription == "UInt16")
            {
                binding.Format += new ConvertEventHandler(UInt16ToString);
                binding.Parse += new ConvertEventHandler(StringToUInt16);
            }
            else if (ctl.AccessibleDescription == "Int16")
            {
                binding.Format += new ConvertEventHandler(Int16ToString);
                binding.Parse += new ConvertEventHandler(StringToInt16);
            }
            else if (ctl.AccessibleDescription == "Int64")
            {
                binding.Format += new ConvertEventHandler(Int64ToString);
                binding.Parse += new ConvertEventHandler(StringToInt64);
            }
            else if (ctl.AccessibleDescription == "UInt32")
            {
                binding.Format += new ConvertEventHandler(UInt32ToString);
                binding.Parse += new ConvertEventHandler(StringToUInt32);
            }
            else if (ctl.AccessibleDescription == "Int32")
            {
                binding.Format += new ConvertEventHandler(Int32ToString);
                binding.Parse += new ConvertEventHandler(StringToInt32);
            }
            else if (ctl.AccessibleDescription == "byte" || ctl.AccessibleDescription == "Byte")
            {
                binding.Format += new ConvertEventHandler(ByteToString);
                binding.Parse += new ConvertEventHandler(StringToByte);
            }
            else if (ctl.AccessibleDescription == "Char")
            {
                binding.Format += new ConvertEventHandler(CharToString);
                binding.Parse += new ConvertEventHandler(StringToChar);
            }
            else if (ctl.AccessibleDescription == "unixEpoch")
            {
                binding.Format += new ConvertEventHandler(UnixEpochToDateTime);
                binding.Parse += new ConvertEventHandler(DateTimeToUnixEpoch);
            }
            else if (ctl.AccessibleDescription == "Bool")
            {
                binding.Format += new ConvertEventHandler(BoolToChecked);
                binding.Parse += new ConvertEventHandler(CheckedToBool);
            }
            else if (ctl.AccessibleDescription == "String")
            {
                binding.Format += new ConvertEventHandler(StringToString);
                binding.Parse += new ConvertEventHandler(StringToString);
            }
            else if (ctl.AccessibleDescription == "Single")
            {
                binding.Format += new ConvertEventHandler(SingleToString);
                binding.Parse += new ConvertEventHandler(StringToSingle);
            }
            else
            {
                retVal = false;
            }

            return retVal;
        }

        private static void BoolToChecked(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(bool)) return;

            // Use the ToString method to format the value as currency ("C4").

            if (cevent.Value.GetType() == typeof(int))
            {
                cevent.Value = ((int)cevent.Value == 0 ? false : true);
            }
            else if (cevent.Value.GetType() == typeof(bool))
            {
                cevent.Value = ((bool)cevent.Value);
            }
        }
        private static void CheckedToBool(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(bool)) return;

            // Use the ToString method to format the value as currency ("C4").

            cevent.Value = ((bool)cevent.Value);
        }

        public static decimal TruncateDecimal(this decimal value, int decimalPlaces)
        {
            decimal integralValue = Math.Truncate(value);

            decimal fraction = value - integralValue;

            decimal factor = (decimal)Math.Pow(10, decimalPlaces);

            decimal truncatedFraction = Math.Truncate(fraction * factor) / factor;

            decimal result = integralValue + truncatedFraction;

            return result;
        }

        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static ulong GetCurrentUnixTimestampMillis(DateTime dateTime)
        {
            return (ulong)(dateTime /* DateTime.UtcNow */ - UnixEpoch).TotalMilliseconds;
        }
        public static ulong GetCurrentUnixTimestampSeconds(DateTime dateTime)
        {
            return (ulong)(dateTime/* DateTime.UtcNow */ - UnixEpoch).TotalSeconds;
        }
        public static DateTime DateTimeFromUnixTimestampMillis(ulong millis)
        {
            return UnixEpoch.AddMilliseconds(millis);
        }
        public static DateTime DateTimeFromUnixTimestampSeconds(ulong seconds)
        {
            return UnixEpoch.AddSeconds(seconds);
        }

        public static void UInt32ToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            if ((uint)cevent.Value > 999)
            {
                cevent.Value = 0;
            }
            cevent.Value = ((UInt32)cevent.Value).ToString("C");
        }
        public static void CurrencyStringToUInt32(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(UInt32)) return;

            // Converts the string back to uint using the static Parse method.
            if ((UInt32)cevent.Value > 999)
            {
                cevent.Value = 0;
            }
            cevent.Value = Math.Truncate((decimal)cevent.Value);
        }
        public static void StringToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            //if ((uint)cevent.Value > 999)
            //{
            //    cevent.Value = 0;
            //}
            if (cevent.Value != null)
            {
                cevent.Value = (cevent.Value).ToString();
            }
        }
        public static void DoubleToCurrencyString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            if ((double)cevent.Value > 999.999)
            {
                cevent.Value = 0;
            }
            cevent.Value = (double.Parse(cevent.Value.ToString())).ToString("C4");
        }
        public static void CurrencyStringToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(double) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4) >
                (Decimal)999.999)
            {
                cevent.Value = 0;
            }
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }

        public static void ByteToMetersString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((byte)cevent.Value).ToString("0 m") + ".";
        }
        public static void MetersStringToBye(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(byte) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt16.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value) > byte.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = byte.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value);
            }
        }
        public static void DoubleToMetersString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((double)cevent.Value).ToString("##0.0000 m") + ".";
        }
        public static void MetersStringToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(double) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.                       
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }
        public static void DoubleToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((double)cevent.Value).ToString();
        }
        public static void StringToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(double) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.                       
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }

        public static void SingleToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((float)cevent.Value).ToString();
        }
        public static void StringToSingle(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(float) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.                       
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }


        public static void ByteToSpeedString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((byte)cevent.Value).ToString("0 Km/h") + ".";
        }
        public static void SpeedStringToByte(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(byte) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt16.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value) > byte.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = byte.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value);
            }
        }
        public static void DoubleToSpeedString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((double)cevent.Value).ToString("##0.0000 Km/h") + ".";
        }
        public static void SpeedStringToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(double) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }

        public static void UInt16ToMinutesString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((UInt16)cevent.Value).ToString("0 min") + ".";
        }
        public static void MinutesStringToUInt16(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(UInt16) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt32.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value) > UInt16.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = UInt16.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value);
            }
        }

        public static void DoubleToMinutesString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((double)cevent.Value).ToString("##0.0000 min") + ".";
        }
        public static void MinutesStringToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(double)) return;

            // Converts the string back to double using the static Parse method.
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }

        public static void UInt16ToSecondsString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((UInt16)cevent.Value).ToString("0 sec") + ".";
        }
        public static void SecondsStringToUInt16(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(UInt16) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt32.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value) > UInt16.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = UInt16.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value);
            }
        }
        public static void DoubleToSecondsString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((double)cevent.Value).ToString("##0.0000 sec") + ".";
        }
        public static void SecondsStringToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(double) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            cevent.Value = TruncateDecimal(Decimal.Parse(Regex.Match(cevent.Value.ToString(), @"[0-9]+(?:\.[0-9]+)?").Value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture), 4);
        }

        public static void ByteToRatioString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((byte)cevent.Value).ToString("#0") + " %";
        }
        public static void RatioStringToByte(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(byte)) return;

            // Converts the string back to double using the static Parse method.            
            if (UInt16.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value) > byte.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = byte.Parse(Regex.Match(cevent.Value.ToString(), @"\d+").Value);
            }
        }

        public static void UInt16ToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((UInt16)cevent.Value).ToString();
        }
        public static void StringToUInt16(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(UInt16) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt16.Parse(cevent.Value.ToString()) > UInt16.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = UInt16.Parse(cevent.Value.ToString());
            }
        }
        public static void Int16ToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((Int16)cevent.Value).ToString();
        }
        public static void StringToInt16(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(Int16) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (Int16.Parse(cevent.Value.ToString()) > Int16.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = Int16.Parse(cevent.Value.ToString());
            }
        }
        private static void Int64ToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((Int64)cevent.Value).ToString();
        }
        private static void StringToInt64(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(Int64) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (Int64.Parse(cevent.Value.ToString()) > Int64.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = Int64.Parse(cevent.Value.ToString());
            }
        }
        private static void Int32ToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((Int32)cevent.Value).ToString();
        }
        private static void StringToInt32(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(Int32) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (Int64.Parse(cevent.Value.ToString()) > Int32.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = Int32.Parse(cevent.Value.ToString());
            }
        }
        private static void UInt32ToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((UInt32)cevent.Value).ToString();
        }
        private static void StringToUInt32(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(UInt32) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt32.Parse(cevent.Value.ToString()) > UInt32.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = UInt32.Parse(cevent.Value.ToString());
            }
        }
        public static void ByteToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((byte)cevent.Value).ToString();
        }
        public static void StringToByte(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(byte) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt16.Parse(cevent.Value.ToString()) > byte.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = byte.Parse(cevent.Value.ToString());
            }
        }

        public static void CharToString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = ((Char)cevent.Value).ToString();
        }
        public static void StringToChar(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to double type only. 
            if (cevent.DesiredType != typeof(Char) || (string)cevent.Value == "") return;

            // Converts the string back to double using the static Parse method.
            if (UInt16.Parse(cevent.Value.ToString()) > Char.MaxValue)
            {
                cevent.Value = 0;
            }
            else
            {
                cevent.Value = Char.Parse(cevent.Value.ToString());
            }
        }

        private static void UnixEpochToDateTime(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(DateTime)) return;

            // Use the ToString method to format the value as currency ("C4").
            cevent.Value = DateTimeFromUnixTimestampSeconds((ulong)cevent.Value);
        }
        private static void DateTimeToUnixEpoch(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(UInt64)) return;

            // Converts the string back to double using the static Parse method.
            cevent.Value = GetCurrentUnixTimestampSeconds(DateTime.Parse(cevent.Value.ToString()));
        }

    }
}
