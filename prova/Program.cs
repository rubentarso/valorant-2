bool Resposta()
{
    inicioPergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
    {
        return false;
    }
    else
    {
Console.WriteLine("Não entendi, responda apenas s/n:");
  goto inicioPergunta;  
    }

}

Console.WriteLine("quer jogar um jogo? s/n");
if(Resposta() == false)
{
    goto finalDeJogo;
}

inicioJogo:

int menor = 0;
int maior = 100;
int numTentativas = 10;
bool jogoRodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor,maior + 1);
Console.WriteLine($"pensei em um númeero entre {menor} e {maior}. tente advinhar!");

while(jogoRodando)
{
    Console.WriteLine($"tentativas {numTentativas}:");
    int numDigitado = int.Parse(Console.ReadLine());
    if(numDigitado < sorteado)
    {
        Console.WriteLine("Muito baixo. Tente novamente.");
        numTentativas--;
    
    }
else if(numDigitado > sorteado)
{
    Console.WriteLine("Muito alto. Tente novamente.");
    numTentativas--;
}
else
{
    Console.WriteLine($"Parabéns! você acertou o número era {sorteado}.");
    jogoRodando = false;

}
if(numTentativas == 0)
{
    Console.WriteLine($"acabaram suas tentativas. o número que pensei era {sorteado}.");
    jogoRodando = false;
}
}

//finalização

Console.WriteLine("Quer jogar de novo? s/n");
if(Resposta() == true)
{
    goto inicioJogo;

}
finalDeJogo:
Console.WriteLine("então até a próxima");  















