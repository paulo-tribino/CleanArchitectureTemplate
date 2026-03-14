using System.Reflection;

namespace Infrastructure.DI;

public static class PresentationAssembly
{
    public static readonly Assembly Assembly = typeof(PresentationAssembly).Assembly;
}
