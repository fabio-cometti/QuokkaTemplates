using NetArchTest.Rules;
using Quokka.Templates.Domain.Exceptions;
using System;
using Xunit;

namespace Quokka.Templates.ArchitecturalTests;

public class ArchitecturalTest1
{
    [Fact]
    public void ClassInDomainExceptionNamespasceShouldInheritApplicationException()
    {
        var result = Types.InAssembly((typeof(DomainException)).Assembly)
            .That()
            .ResideInNamespace("Quokka.Templates.Domain.Exceptions")
            .Should()
            .Inherit(typeof(ApplicationException))
            .GetResult()
            .IsSuccessful;

        Assert.True(result);
    }
}