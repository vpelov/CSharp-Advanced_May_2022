using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl
{
    public interface IBuyer
    {
        public int Food { get; set; }

        public void BuyFood();

    }
}
