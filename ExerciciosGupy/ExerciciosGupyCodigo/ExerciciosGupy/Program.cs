using System.Runtime.InteropServices;

//Exercício 3
ExercicioTres();

static void ExercicioTres()
{
    int minFat = 0;
    int maxFat = 50000;

    int[] faturamentoAno = new int[365];

    Random numeroAleatorio = new Random();

    var total = 0;

    for(int i = 0; i < faturamentoAno.Length; i++)
    {
        var numeroGerado = numeroAleatorio.Next(minFat, maxFat);
        faturamentoAno[i] = numeroGerado;
        total += numeroGerado;
    }

    var min = faturamentoAno.Min();
    var max = faturamentoAno.Max();
    var mediaAnual = total / 365;
    var dias = faturamentoAno.Where(e => e > mediaAnual).ToArray().Length; //Variável referente ao número de dias onde o faturamento foi superior à média anual.

    Console.WriteLine("Valor do menor faturamento em um dia do ano: R$: " + min);
    Console.WriteLine("Valor do maior faturamento em um dia do ano: R$: " + max);
    Console.WriteLine("Número de dias no ano em que o valor de faturamento diário foi superior à média anual: " + dias);
}


