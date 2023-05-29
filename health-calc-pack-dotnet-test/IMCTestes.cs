using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet;

namespace health_calc_pack_dotnet_test
{
    public class UnitTest1
    {
        [Fact]
        public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 1.85;
            double Weight = 77;
            double ExpectedIMC = 30.55;

            //Act
            var result = imc.Calc(Height, Weight);

            //Asserts
            Assert.Equal(ExpectedIMC, result);

        }

        [Fact]
        public void ValidaDadosIMC_QuandoDadosValidos_EntaoRetornaVerdadeiro()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 10;
            double Weight = 400;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao()
        {
            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 30.55;
            string Expected = "OBESIDADE";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }
    }
} 