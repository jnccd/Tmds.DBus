namespace Tmds2.DBus.Protocol;

enum RequestNameReply : uint
{
    PrimaryOwner = 1,
    InQueue,
    Exists,
    AlreadyOwner,
}
