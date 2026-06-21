namespace Tmds2.DBus.Protocol;

sealed class ObserverDisposedException : ObjectDisposedException
{
    public ObserverDisposedException() : base("Tmds2.DBus.Protocol.Observer")
    { }
}
