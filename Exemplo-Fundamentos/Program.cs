using System.Diagnostics.Contracts;
using Exemplo_Fundamentos.Models;
/*
//LISTAS

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BAHIA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("SC");

Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Remove("MG");

Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// Console.WriteLine("Percorrendo uma lista com FOR: ");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// int contadorForeach = 0;
// Console.WriteLine("Percorrendo uma lista com FOREACH: ");
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }
*/


/*
//ARRAYS

int[] arrayInteiros = new int[4];

// adicionado valores nas posicoes do array
arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;
arrayInteiros [3] = 1;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//Redimensiona em 2x a capacidade do array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Foreach - indicado para listas e arrays
Console.WriteLine("Percorrendo array com foreach");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

// Console.WriteLine("Percorrendo array com foreach (sem contador)");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// Console.WriteLine("Percorrendo array com foreach (com contador)");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }
*/



/*
string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("2 - Buscar cliente");
            break;

        case "3":
            Console.WriteLine("3 - Apagar cliente");
            break;

        case "4":
            Console.WriteLine("4 - Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
Console.WriteLine("O programa se encerrou.");
*/


// Laço DO WHILE
// int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
    
// } while (numero != 0);

// Console.WriteLine($"Total das soma dos numeros digitados é: {soma}");


// Laço WHILE
// int numero = 5;
// int contador = 0;
// int auxiliar = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}º Execução: {numero} X {contador} = {numero * contador}");
//     contador++;
// }

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}º Execução: {numero} X {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break; // Quebra o laço e ele tem maior prioridade
//     }
// }


// // Laço FOR
// int numero = 10;
// Console.WriteLine($"{numero} X 1 = {numero * 1}");

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }



//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 30);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
//calc.Potencia(3,3);

// Funcoes de Trigonometria
/*
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
*/
//calc.RaizQuadrada(9);


// Operador Logico  NOT = não
/*
bool choveu = true;
bool estatarde = true;
 if (!choveu && !estatarde)
 {
    Console.WriteLine("Vou pedalar");
 }
 else 
 {
    Console.WriteLine("Vou pedalar outro dia.");
 }
*/


// Operadores Logicos AND = E; Valor = true true
/*
bool possuiPresencaMinima = true;
double media = 7.5;

if(possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado.");
}
else
{
    Console.WriteLine("Reprovado.");
}
*/


// Operadores Logicos OR = Ou; Valor = true false
/*
bool maiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada.");
}
else
{
    Console.WriteLine("Entrada não liberada.");
}
*/


// Swich case - Recomendado utilizar para substituir uma condicao que houver vários IFs.
/*
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é vogal");
        break;
}
*/

// Operadores Condicionais------------------
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// If Else
/*if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
} 
else
{
    Console.WriteLine("Descupe. Não temos a quantidade desejada em estoque.");
}*/


// If Aninhado
/*
if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
} 
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
} 
else
{
    Console.WriteLine("Descupe. Não temos a quantidade desejada em estoque.");
}
*/


//Conversão segura------------
// string a = "15";
// int b = 0;
// int.TryParse(a, out b);



// Cast - Conversão de tipos------------
// int a = Convert.ToInt32("5");// Convert.ToInt32("") - coverte uma string em numero inteiro, o valor seja "null" ele retornará 0.
// Console.WriteLine(a);
// int a = int.Parse("5");// int.Parse("") - coverte uma string em numero inteiro, o valor seja "null" ele retornará erro nessa linha.
// Console.WriteLine(a);


// int a = 10;
// int b = 20;
// int c = a + b;
// Console.WriteLine(c);
// c = c + 5;
// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now;

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// string apresentacao = "Olá, seja bem vindo;-)";
// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;
// decimal preco = 1.50M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Variavel da quantidade: "+ quantidade);
// Console.WriteLine("Variavel da altura: "+ altura.ToString("0.00"));
// Console.WriteLine("Variavel da preco: "+ preco);
// Console.WriteLine("Variavel da condicao: "+ condicao);


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Claudia";
//pessoa1.Idade = 26;
//pessoa1.Apresentar();