using primer_parcial_unit_test_procesador_matematico;

namespace ProcesadorMatematicoTests
{
    public class ProcesadorMatematicoTests
    {
        private readonly primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico procesadorMatematico;

        public ProcesadorMatematicoTests()
        {
            this.procesadorMatematico = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();
        }

        [Fact]
        public void Dividir_WhenCalled_ReturnsResultadoDividir()
        {
            //Arrange
            double nro1 = 2;
            double nro2 = 2;
            double resultadoTest = 2 / 2;

            //Act

            double resultado = procesadorMatematico.Dividir(nro1, nro2);

            //Assert 

            Assert.Equal(resultadoTest, resultado);
        }

        [Fact]
        public void Sumar_WhenCalled_ReturnsResultadosumar()
        {
            //Arrange
            double nro1 = 2;
            double nro2 = 2;
            double resultadoTest = 4;
            //Act
            double resultado = procesadorMatematico.Sumar(nro1, nro2);
            //Assert
            Assert.Equal(resultadoTest, resultado);
        }

        [Theory]
        [InlineData(2, false)]
        [InlineData(-2, true)]
        public void EsNegativo_WhenCalled_ReturnsResultadoEsNegativo(double nro, bool expected)
        {
            //Arrange
            double nro1 = nro;
            //Act
            bool resultado = procesadorMatematico.EsNegativo(nro1);
            //Assert;
            Assert.Equal(resultado, expected);
        }

        [Fact]
        public void CalcularMayor_WhenCalled_ReturnsResultadoCalcularMayorConNumeroMayor()
        {
            //Arrange
            double menor = 1;
            double mayor = 2;
            //Act
            double resultado  =  procesadorMatematico.CalcularMayor(menor, mayor);
            //Assert
            Assert.Equal(mayor, resultado);
        }

        public void CalcularMayor_WhenCalled_ReturnsResultadoCalcularMayorConNumeroMenor()
        {
            //Arrange
            double menor = 1;
            double mayor = 2;
            //Act
            double resultado = procesadorMatematico.CalcularMayor(mayor, menor);
            //Assert
            Assert.Equal(menor, resultado);
        }
    }
}
