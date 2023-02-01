namespace FactoryPattern
{
    class Ship : Transport
    {
        public override ITransportTask FactoryMethod()
        {
            return new ShipTransport();
        }
    }
}
