using Calculadora.Services;
using NuGet.Frameworks;

namespace CalculadoraTestes;
public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act - Acão
        int resultado = _calc.Somar(num1, num2);

        // Assert 
        Assert.Equal(15, resultado);
    }

     [Fact]
    public void DeveSomar10Com2ERetornar12()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act - Acão
        int resultado = _calc.Somar(num1, num2);

        // Assert 
        Assert.Equal(12, resultado);
    }

     [Fact]
    public void DeveMultiplicar10Com2ERetornar12()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act - Acão
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert 
        Assert.Equal(20, resultado);
    }

    
     [Fact]
    public void DeveDividir10Com2ERetornar5()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act - Acão
        int resultado = _calc.Dividir(num1, num2);

        // Assert 
        Assert.Equal(5, resultado);
    }
    
     [Fact]
    public void DeveSubtrair10Com2ERetornar8()
    {
        // Arrange
        int num1 = 10;
        int num2 = 2;

        // Act - Acão
        int resultado = _calc.Subtrair(num1, num2);

        // Assert 
        Assert.Equal(8, resultado);
    }

    //[Theory]
    //[InlineData(2)]
   // [InlineData(4)]
    //[InlineData(6)]
    //[InlineData(8)]
    //[InlineData(10)]
    //public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    //{
        // Arrange        
        // Act
    //    bool resultado = _calc.EhPar(numero);

        // Asset
    //    Assert.True(resultado);
   // }

    // Refatorando o teste acima

    [Theory]
    [InlineData(new int[] {2, 4, 6, 8, 10})]    
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Asset
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}