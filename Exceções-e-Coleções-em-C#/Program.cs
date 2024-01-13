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

// Tratando uma Exceção----------


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



// Exceção Especifica - De arquivo----------
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



 // Exceção Especifica - De Diretorio ou pasta----------
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



 // Finally----------
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



// Fila - Queue----------
/*
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
*/

// Pilha----------
/*
Stack<int> pilha = new Stack<int>();

// Adicionaando elementos
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// Removendo elemento
Console.WriteLine($"Removendo o elemento {pilha.Pop()} do top:");

// Introduzir novo elemento a pilha: 20
pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}
*/



//Dictionary - Garante que cada elemento seja único. Portanto, nao pode haver repeticao desse elemento.

/*
Dictionary<string,string> estados = new Dictionary<string,string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("PA", "Pará");
*/


/*
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Removendo o elemento Bahia
Console.WriteLine("Removendo o elemento Bahia");
estados.Remove("BA");

// Alterando valor
estados["SP"] = "São Paulo - Valor Alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
*/


// Verificando a existencia de um item
/*
string chave = "BA";
Console.WriteLine($"Verificado o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente. È seguro adicionar a chave: {chave}");
}
*/

//Obtendo um valor ja existente
//Console.WriteLine(estados["MG"]);