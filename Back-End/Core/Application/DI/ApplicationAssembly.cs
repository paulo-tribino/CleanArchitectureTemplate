using System.Reflection;

namespace Application.DI;

public static class ApplicationAssembly
{
    public static readonly Assembly Assembly = typeof(ApplicationAssembly).Assembly;
}
