using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    public class StringDisperser :ICloneable,IComparable<StringDisperser>, IEnumerable
    {
        private string[] stringArr;


        public StringDisperser(params string[] stringArr)
        {
            this.StringArr = stringArr;
        }

        public StringDisperser()
        {
            // TODO: Complete member initialization
        }

        public string[] StringArr { get; set; }
        


        public override string ToString()
        {
            string result = String.Join("", this.StringArr);
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            StringDisperser target = obj as StringDisperser;
            if (obj == null)
            {
                return false;
            }
            if (!this.StringArr.Equals(target.StringArr))
            {
                return false;
            }
            return true;
        }

        public string ConcatanateText(string[] strings)
        {
            return String.Join("", this.StringArr);
        }

        public override int GetHashCode()
        {
            int hashCode = this.StringArr.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(StringDisperser firstString, StringDisperser secondString)
        {
            return StringDisperser.Equals(firstString, secondString);
        }
        public static bool operator !=(StringDisperser firstString, StringDisperser secondString)
        {
            return !StringDisperser.Equals(firstString, secondString);
        }

        public object Clone()
        {
            return new StringDisperser()
            {
                StringArr = this.StringArr
            };
        }

        

        public int CompareTo(StringDisperser other)
        {
            return this.ConcatanateText(this.StringArr).CompareTo(other.ConcatanateText(other.StringArr));
        }

        public IEnumerator GetEnumerator()
        {
            string result = this.ConcatanateText(this.StringArr);
            for (int i = 0; i < result.Length; i++)
            {
                yield return result[i];
            }
        }



        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
