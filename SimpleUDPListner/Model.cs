using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUDPListner
{
    public class ModelTypeDef
    {
        public ModelTypeDef(PropertyInfo pi)
        {
            propertyInfo = pi;
            InitClass();
        }

        private void InitClass()
        {
            propertyName = propertyInfo.Name;
            groupName = propertyInfo.DeclaringType.ToString();
            propertyType = propertyInfo.PropertyType.IsClass ? "class" : "data";
            dataType = propertyInfo.PropertyType.Name.ToString();
            maxLength = 10;
            maxValue = Int32.MaxValue;            
        }

        public string propertyName;
        public string groupName;
        public string propertyType;
        public string dataType;
        public int maxLength;
        public int maxValue;

        private PropertyInfo propertyInfo;
    }

    class Model
    {
        private bool disposed_;

        public Model()
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!disposed_)
            {
                if (disposing)
                {
                    
                }

                disposed_ = true;
            }
        }
        public void ThrowExceptionIfDisposed()
        {
            if (disposed_)
            {
                throw new ObjectDisposedException("The model is disposed");
            }
        }
    }
}
