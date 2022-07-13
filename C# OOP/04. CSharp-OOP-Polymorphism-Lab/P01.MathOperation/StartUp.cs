using System;

namespace Operations
{
    public class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Start();
        }
    }
}
