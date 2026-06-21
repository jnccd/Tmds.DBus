using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tmds2.DBus.Tests
{
    [DBusInterface("Tmds2.DBus.tests.StringOperations")]
    public interface IStringOperations : IDBusObject
    {
        Task<string> ConcatAsync(string s1, string s2);
    }
}