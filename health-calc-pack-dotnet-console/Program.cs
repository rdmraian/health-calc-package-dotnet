using health_calc_pack_dotnet;

var imc = new IMC();
var result = imc.Calc(1.85, 77.0);
var classificacao = imc.GetIMCCategory(result);

Console.WriteLine($"Seu IMC é: {result} e o resultado é: {classificacao}");