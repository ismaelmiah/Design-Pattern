namespace FactoryPattern
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class TruckTransport : ITransportTask
    {
        public string Deliver()
        {
            return "{Result of TruckTransport}";
        }
    }
}
