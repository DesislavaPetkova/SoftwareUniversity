using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, 
  AllowMultiple = true)]

    public class VersionAttribute :System.Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        public int Major 
        {
            get
            {
                return this.major;
            }

            private set
            {
                this.major = value;
            }
        }
        public int Minor
        {
            get
            {
                return this.minor;
            }

            private set
            {
                this.minor = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Major + "." + this.Minor);
            return result.ToString();
        }
    }   
}
