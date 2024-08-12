
bool Resposta()
{
    InicioPergunta:
    string Resposta = Console.ReadLine();

    if(Resposta == "s")
    {
        return true;
    }
    else if(Resposta == "n")
    {
        return false;
   
    }
    else
    {
        Console.WriteLine("Não entendi, digite apenas s/n");
        goto InicioPergunta;
    }
}

Console.WriteLine("Você quer jogar um jogo? s/n");
if(Resposta() == false)
{
    goto FinalJogo;
}

InicioJogo:

int menor = 0;
int maior = 100;
int NumTentativas = 10;
bool jogoRodando = true;

Random rand = new Random();
int Sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"Pensei em um número entre {menor} e {maior}, tente adivinhar!");

while(jogoRodando)
{
    Console.WriteLine($"Tentativa {NumTentativas}:");
    int NumDigitado = int.Parse(Console.ReadLine());
    if(NumDigitado < Sorteado)
    {
        Console.WriteLine("Muito baixo noob, pense mais alto");
        NumTentativas --;
    }
    else if(NumDigitado > Sorteado)
    {
        Console.WriteLine("Pensou alto demais trouxa, tenta diminuir um pouco");
        NumTentativas--;
    }
    else
    {
        Console.WriteLine("Meh, sem graça, você acertou.");
        jogoRodando = false;
    }
    if(NumTentativas == 0)
    {
        Console.WriteLine($"kkkkk perdeu, eu estava pensando em {Sorteado}");
        jogoRodando = false;
 
    }

}

Console.WriteLine("Quer jogar denovo? s/n");
if(Resposta() == true)
{
    goto InicioJogo;
}

FinalJogo:
Console.WriteLine("kkkk muito noob mesmo.");
