using System;

namespace Virtual_Abstract_Interface
{
    public class Item : BaseClass
    {
        public override void ShowText(string text)
        {
            Console.WriteLine("Item => " + text);
        }
    }
}
