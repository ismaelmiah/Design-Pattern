namespace FactoryPattern
{
    class PlaneTransport : ITransportTask
    {
        public string Deliver()
        {
            return "{Result of Plane}";
        }
    }
}
