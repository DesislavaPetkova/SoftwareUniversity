namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Band : IBand
    {
        private List<string> members = new List<string>();

        private string name;

        private PerformerType type;

        private List<ISong> songs = new List<ISong>(); 

        public IList<string> Members
        {
            get
            {
                return this.members;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is required");
                }
                this.name = value;
            }
        }

        public PerformerType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (value.GetType() != typeof(PerformerType))
                {
                    throw new InvalidEnumArgumentException("Wrong performer");
                }
                this.type = value;
            }
        }

        public IList<ISong> Songs
        {
            get
            {
                return this.songs;
            }
        }

        public void AddMember(string memberName)
        {
            this.Members.Add(memberName);
        }
    }
}
