using Exemplos_Explorando.Models;
using System.Globalization;




/*
// Sem exceções
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");//ReadAllLines - lê linha por linha

foreach (var linha in linhas)
{
    // será impresso cada linha
    Console.WriteLine(linha);
}
*/

// Tratando uma Exceção

/*
//caso 1
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
*/

/*
//caso 2
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
}
catch (FileNotFoundException ex) // Cao o erro for no arquivo
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex) // Cao o erro for na pasta
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) // Excessão generica
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

finally // Finaliza
{
Console.WriteLine("Chegou até aqui.");
}
*/