namespace FactoryPattern
{
    class ShipTransport : ITransportTask
    {
        public string Deliver()
        {
            return "{Result of Ship}";
        }
    }
}
