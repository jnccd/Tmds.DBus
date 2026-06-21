namespace Tmds2.DBus.Protocol;

interface IMethodHandlerDictionary
{
    void AddMethodHandlers(IReadOnlyList<IPathMethodHandler> methodHandlers);
    void AddMethodHandler(IPathMethodHandler methodHandler);
    void RemoveMethodHandler(string path);
    void RemoveMethodHandlers(IEnumerable<string> paths);
}