using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator d = new Decorator(new Component());
            Console.WriteLine(d.Operation());
            Console.ReadKey();
        }
    }

    interface IComponent
    {
        string Operation();
    }

    class Component:IComponent
    {

        public string Operation()
        {
            return "Base component";
        }
    }

    class Decorator:IComponent
    {
        private IComponent component;

        public Decorator(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "Decorated function";
            return s;
        }
    }
}
