using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Escolha dois números pra somar");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = a + b;


bool par = c % 2 == 0;

if(par){
    Console.WriteLine(c + " é par");
}
else{
    Console.WriteLine(c + " é ímpar");
}
/*
Console.WriteLine("Digite um número: ");

int num = int.Parse(Console.ReadLine());

bool par = num % 2 == 0;

if(par)
{
    Console.WriteLine("é par");
}
else
{
    Console.WriteLine("é impar");
}













/* falso e verdadeiro
bool p = true; 
bool q = false;

Console.WriteLine(!p);
Console.WriteLine(!q);
Console.WriteLine(p && q);
Console.WriteLine(p || q);
bool r = !(p && !q) || !(p || q);
Console.WriteLine(r);










numeros decimais
/*int a = 1;
float b = 2.567f;
double c = 2.99999999; //numeros reais decimais

var d = a + b + c; //declara os numeros diferentes: float, double e int. a resposta é o maior tipo: double

string mensagem1 = "Resultado da soma "; 
char caractere = 'd';

var mensagem2 = mensagem1 + caractere + " é igual a: "; //declara textos diferentes: string e char


Console.WriteLine(mensagem2 + d);










/* calculadora multiplicacao e divisao
int a = 20;
int b = 7;
int quociente = a / b;
int resto = a % b;

Console.WriteLine($"{a} dividido por {b}");

Console.WriteLine("Quociente: " + quociente);

Console.WriteLine("Resto: " + resto);











/* calculadora
int a = 18; //declarar número inteiro
int b = 6;
int c; 

c = a + b; //soma
Console.WriteLine("soma: " + c);
c = a - b; //subtração
Console.WriteLine("subtração: " + c);
c = a * b; //multiplicação
Console.WriteLine("multiplicação: " + c);
c = a / b; //divisão
Console.WriteLine("divisão: " + c);










/* frase
string x = "Ian"; //declarando variavel
string y = "Victor";

int nota1 = 10; //int para declarar numeros inteiros
int nota2 = 50; 

Console.WriteLine("Enquanto isso na escola:");
Console.ReadKey();
Console.WriteLine($"{x} tirou {nota1} na prova e {y} tirou {nota2}"); //digitar "$" para colocar msg antes das variaveis.


// /* para comentar varios codigos, e para fechar */ 

