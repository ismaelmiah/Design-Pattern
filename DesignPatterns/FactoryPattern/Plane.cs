namespace FactoryPattern
{
    class Plane : Transport
    {
        public override ITransportTask FactoryMethod()
        {
            return new PlaneTransport();
        }
    }
}
