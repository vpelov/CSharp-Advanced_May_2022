using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Telephony
{
    public class StationaryPhone : IDial
    {
        private string number;

        public StationaryPhone(string number)
        {
            this.Number = number;
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public string Dial()
        {
            return $"Dialing... {this.number}";
        }
    }
}
