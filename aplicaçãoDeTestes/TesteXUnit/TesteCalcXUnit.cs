using aplicaçãoDeTestes;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - ação
            var resultado = CalcularImc.Somar(pNum, sNum);

            //Assert - verificação
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 4, 6)]
        [InlineData(6, 1, 7)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = CalcularImc.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
    }
}