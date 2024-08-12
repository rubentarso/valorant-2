using System.Diagnostics.Tracing;

Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a nota 2:");
int nota2 = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a nota 3:");
int nota3 = int.Parse (Console.ReadLine());

Console.WriteLine("Digite a nota 4:");
int nota4 = int.Parse (Console.ReadLine());

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
media = (float)Math.Round(media);
Console.WriteLine("Média da disciplina " + media);

if(media>= 60){
    Console.WriteLine("aprovado");
    return;
}
else if (media < 20){
    Console.WriteLine("reprovado");
    return;
}
else{
    Console.WriteLine ("recuperação");
}

Console.WriteLine("Digite o valor da prova final:");
int ProvaFinal = int.Parse(Console.ReadLine());

float MediaFinal = (media = ProvaFinal) / 2f;
MediaFinal = (float)Math.Round(MediaFinal);
Console.WriteLine("média final " + MediaFinal);

if (MediaFinal <= 60){
    Console.WriteLine("parabens você foi aprovado!");
}
else{
    Console.WriteLine("infelizmente você foi reprovado");
    float previsao = 120 - media;
    Console.WriteLine($"precisa tirar {previsao} para passar");
}
