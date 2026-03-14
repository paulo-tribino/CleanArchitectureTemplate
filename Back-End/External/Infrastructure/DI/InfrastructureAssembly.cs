using System.Reflection;

namespace Infrastructure.DI;

public static class InfrastructureAssembly
{
    public static readonly Assembly Assembly = typeof(InfrastructureAssembly).Assembly;
}
