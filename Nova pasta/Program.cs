using System.Runtime.InteropServices.Marshalling;

/*void Mensagem(){
    Console.WriteLine("olá mundo");
}
Mensagem();

void Escreva(string msg){
    Console.WriteLine(msg);
}
Escreva("olá");





void MostrarIdade(string nome, int idade){
    Escreva($"{nome} tem {idade} anos");
}
MostrarIdade("Fulano",16);

void CalcularIdade(string nome, int ano){
    int idade = 2024 - ano;
    MostrarIdade(nome, idade);
}
CalcularIdade("fulanão", 2014);*/

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}



void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}


void multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}


void divisao(float a, float b){
if(b == 0){
    Console.WriteLine("Erro de divisão por zero");
    return;
}
    float resultado = a / b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}


//variaveis globais
float a;
float b;

void DigitarAeB(){
    Console.WriteLine("Digite a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite b:");
    b = float.Parse(Console.ReadLine());

}

//menu


Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("1 - soma ----------");
Console.WriteLine("2 - subtração -----");
Console.WriteLine("3 - multiplicação -");
Console.WriteLine("4 - divisão -------");
Console.WriteLine("5 - sair ----------");
Console.WriteLine("-------------------");
Console.WriteLine("Digite a opção desejada:");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
Console.WriteLine("Soma");
DigitarAeB();
Soma(a,b);
}

else if(opcao == 2){
Console.WriteLine("Subtração");
DigitarAeB();
Subtracao(a,b);
}

else if (opcao == 3){
Console.WriteLine("Multiplicação");
DigitarAeB();
multiplicacao(a,b);

}
else if (opcao == 4){
Console.WriteLine("Divisão");
DigitarAeB();
divisao(a,b);

}
else if (opcao == 5){
Console.WriteLine("Saindoo....");

}
else{
Console.WriteLine("Opção inválida");
}

























































