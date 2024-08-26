
    // Arrange - Preparar
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 4, 7)]
     public void Teste_Multi_Somar(double n1, double n2, double res_esp)
        {
            Operacoes o = new Operacoes();
            // Act - Agir
            var res_soma = o.Somar(n1, n2);
            // Assert - Verificar
            Assert.Equal(res_esp, res_soma);
        }
    
    // Arrange - Preparar
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 3, 6)]
    [InlineData(3, 4, 12)]
     public void Teste_Multi_Multiplicar(double n1, double n2, double res_esp)
        {
            Operacoes o = new Operacoes();
            // Act - Agir
            var res_soma = o.Multiplicar(n1, n2);
            // Assert - Verificar
            Assert.Equal(res_esp, res_soma);
        }
