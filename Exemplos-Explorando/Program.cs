using Exemplos_Explorando.Models;



/*
//DATA E HORA
using System.Globalization;
DateTime data = DateTime.Now;

Console.WriteLine("Data hora e minuto: ");
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine("Somente data: ");
Console.WriteLine(data.ToShortDateString());

Console.WriteLine("Somente Hora: ");
Console.WriteLine(data.ToShortTimeString());
*/

/*
//FORMATANDO DATA E HORA
DateTime data = DateTime.Parse("06/12/2023 18:00");

Console.WriteLine(data);
*/

/*
//CONVERTENDO DATA E HORA PARA UMA DATA VALIDA
using System.Globalization;

string dataString = "2022-04-17 18:00";
DateTime.TryParseExact( dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime data);

Console.WriteLine(data);
*/

//VALIDANDO O RETORNO TryParse
using System.Globalization;

string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact( dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}

/*
// REPRESENTANDO PORCENTAGEM
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// FORMATNDO VALORES MONETÁRIOS
decimal valorMonetario = 1528.40M;

Console.WriteLine(valorMonetario.ToString("N2")); //C2 - exibira com duas casa decimais

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

// PERSONALIZANDO A FORMATAÇÃO
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/


/*
//Alterando Localização do Sistemas/ FORMATAÇÃO PERSONALIZADA
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// FORMATNDO VALORES MONETÁRIOS
decimal valorMonetario = 1528.40M;

Console.WriteLine(valorMonetario.ToString("C2")); //C2 - exibira com duas casa decimais
*/


/*
//Alterando Localização do Sistemas
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// FORMATNDO VALORES MONETÁRIOS
decimal valorMonetario = 1528.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
*/

/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// FORMATNDO VALORES MONETÁRIOS
decimal valorMonetario = 1528.40M;

Console.WriteLine($"{valorMonetario:C}");

*/

// Concatenação
/*
string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;
Console.WriteLine(resultado);
*/



// Tema - Metodos
// Pessoa p1 = new Pessoa(nome: "Leonardo", sobreNome:"Buta");

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobreNome: "Neves Queiros");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.SobreNome = "Buta";
// p1.Idade = 20;
// p1.Apresentar();