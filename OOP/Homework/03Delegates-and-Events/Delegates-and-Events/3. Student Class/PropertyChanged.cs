﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Student_Class
{
    class PropertyChanged
    {
         
        private string property;
        private string oldValue;
        private string newValue;

        
        public string Property
        {
            get { return this.property; }
        }

        public string OldValue
        {
            get { return this.oldValue; }
        }

        public string NewValue
        {
            get { return this.newValue; }
        }


        public PropertyChanged(string property, string oldValue, string newValue)
        {
            this.property = property;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }
    }
}
