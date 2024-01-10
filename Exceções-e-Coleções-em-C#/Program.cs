using Exemplos_Explorando.Models;
using System.Globalization;


//new ExemploExcecao().Metodo1();

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


 // Finally
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

// Fila - Queue

Queue<int> fila = new Queue<int>();

// Enqueue - adiciona um elemento a fila
fila.Enqueue(2); 
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

// percorrenndo uma fila
foreach (int item in fila)
{
    Console.WriteLine(item);
}

// Dequeue() - Remove o primeiro item da fila
fila.Dequeue();
Console.WriteLine("Fila sem o primeiro elemento:");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// Adicionei o elemento 10 a fila

Console.WriteLine("Adicionei o elemento 10 a fila:");
fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}
