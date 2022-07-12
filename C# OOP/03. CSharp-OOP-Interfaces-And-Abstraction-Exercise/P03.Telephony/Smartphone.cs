using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        private string number;
        private string url;

        public Smartphone(string number)
        {
            this.Number = number;
        }

       
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public string URL
        {
            get { return url; }
            set { url = value; }
        }


        public string Browsing()
        {
            return $"Browsing: {this.number}!";
        }

        public string Calling()
        {
            return $"Calling... {this.number}";
        }
    }
}
