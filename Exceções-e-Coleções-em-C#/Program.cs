using Exemplos_Explorando.Models;
using System.Globalization;


new ExemploExcecao().Metodo1();


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


//caso 1 - Exceção generica
/*
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

 Console.WriteLine($"Chegou ate aqui.");
 */

// Exceção Especifica - De arquivo
/*
 try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_LeituraX.txt");

foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
 catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

 Console.WriteLine($"Chegou ate aqui.");
*/


 // Exceção Especifica - De Diretorio ou pasta
 /*
 try
{
    string[] linhas = File.ReadAllLines("Arquivos/novoArquivo/arquivo_Leitura.txt");

foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do diretorio. Caminho do arquivo não encontrado. {ex.Message}");
}
 catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

 Console.WriteLine($"Chegou ate aqui.");
 */


 // Finaly
 /*
 try
{
    string[] linhas = File.ReadAllLines("Arquivos/novoArquivo/arquivo_Leitura.txt");

foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do diretorio. Caminho do arquivo não encontrado. {ex.Message}");
}
 catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally{
    Console.WriteLine($"Chegou ate aqui.");
}
*/