namespace DependencyInjection.Services
{
    public class DIService : ITransientService, IScopedService, ISingletonService
    {
        readonly Guid id;
        public DIService()
        {
            this.id = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return id;
        }
    }
}
