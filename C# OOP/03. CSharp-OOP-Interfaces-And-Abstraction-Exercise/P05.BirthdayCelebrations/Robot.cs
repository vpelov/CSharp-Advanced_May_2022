using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl
{
    public class Robot : IId, IName
    {
        private string name;
        private string id;

        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        { 
            get => this.name;
            set => this.name = value; 
        }

        public string Id 
        { 
            get => this.id;
            set => this.id = value;
        }
    }
}
