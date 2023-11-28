namespace Gymbo.Domain.Exceptions
{
    public class ConnectionStringNotFoundException : Exception
    {
        public ConnectionStringNotFoundException() : base("Connection string 'Default' could not be found.")
        {
        }
    }
}
