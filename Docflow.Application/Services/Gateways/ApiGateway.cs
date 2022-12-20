namespace Docflow.Application.Services.Gateways
{
    public abstract class ApiGateway : IDisposable
    {
        private bool _disposed = false;

        protected HttpClient Client { get; }

        public ApiGateway(HttpClient client)
        {
            Client = client;
        }

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Client?.Dispose();
                }
            }

            _disposed = true;
        }

        ~ApiGateway()
        {
            CleanUp(false);
        }
    }
}
