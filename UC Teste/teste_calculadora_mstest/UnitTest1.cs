namespace teste_calculadora_mstest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Teste_Somar()
    {
        // Arrange - Preparar
        double pnum = 10;
        double snum = 20;
        double resultado;
        Operacoes o = new Operacoes();
        // Act - Agir
        resultado = o.Somar(pnum, snum);
        // Assert - Verificar (resultado previsto X resultado obtido)
        Assert.AreEqual(30, resultado);
    }

    [TestMethod]
    public void Teste_Multiplicar()
    {
        // Arrange - Preparar
        double pnum = 10;
        double snum = 20;
        double resultado;
        Operacoes o = new Operacoes();
        // Act - Agir
        resultado = o.Multiplicar(pnum, snum);
        // Assert - Verificar (resultado previsto X resultado obtido)
        Assert.AreEqual(200, resultado);
    }
}