using System;

namespace FactoryPattern
{
    class RunTransport
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the Truck.");
            ClientCode(new Truck());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the Ship.");
            ClientCode(new Ship());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the Plane.");
            ClientCode(new Plane());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Transport creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.GetTransport());
            // ...
        }
    }
}
