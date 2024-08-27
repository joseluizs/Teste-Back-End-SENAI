namespace atividade_imc_xunit;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC();

        i.peso = 80;
        i.altura = 1.60;

        i.Calcular_IMC();

        Assert.Equal(i.imc, imc_previsto);
    }

    [Theory]
    [InlineData("Abaixo do peso")]
    [InlineData("Peso normal")]
    [InlineData("Sobrepeso")]
    [InlineData("Obesidade de grau I")]
    [InlineData("Obesidade de grau II")]
    [InlineData("Obesidade de grau III")]

    public void Teste_Categoria_IMC(string cat)
    {
        IMC i = new IMC();

        i.peso = 80;
        i.altura = 1.60;

        i.Calcular_IMC();
        i.Classificar_IMC();

        Assert.Equal(i.categoria, cat);
    }
}