/* Questão 1
int INDICE = 13;
int SOMA = 0;
int K = 0;

while (K < INDICE) {
    K++;
    SOMA = SOMA + K;
}

Console.WriteLine(SOMA);


*/

/*Questão 2
int Fibonacci = 0;
int Aux1 = 0;
int Aux2 = 1;
Console.WriteLine("Informe um número para verificar se pertence a sequência de Fibbonacci");
int Entrada = 13;
Console.WriteLine("Sua entrada: "+Entrada);
int[] ConjuntoFibonacci = new int[Entrada];


for(int i = 0; i < Entrada; i++){
    Fibonacci = Aux1 + Aux2;
    Aux1 = Aux2;
    Aux2 = Fibonacci;    
    ConjuntoFibonacci[i] = Fibonacci;
    Console.WriteLine(ConjuntoFibonacci[i]);
}

if(ConjuntoFibonacci.Contains(Entrada)){
        Console.WriteLine("O número: "+ Entrada + " pertence a sequência de Fibonacci");
    } else {
        Console.WriteLine("O número: "+ Entrada + " não pertence a sequência de Fibonacci");
}
 */


 /* Questão 3
using (StreamReader r = new StreamReader(@"./dados.json")){

    var json = r.ReadToEnd();
    var mes = System.Text.Json.JsonSerializer.Deserialize<List<Dados>>(json);
    var menorFaturamento = 0.0;
    var diaMenor = 0;
    var maiorFaturamento = 0.0;
    var diaMaior = 0;
    var mediaMensal = 0.0;
    var qntDiasCalculados = 0;

    foreach (var dados in mes){
        if (dados.valor >= maiorFaturamento && dados.valor != 0.0){
            diaMaior = dados.dia;
            maiorFaturamento = dados.valor;
        }
        if (dados.valor != 0.0 && menorFaturamento == 0.0){
            menorFaturamento = dados.valor;
        }
        if (dados.valor < menorFaturamento && dados.valor != 0.0){
            diaMenor = dados.dia;
            menorFaturamento = dados.valor;
        }
        if (dados.valor != 0.0){
            qntDiasCalculados++;
            mediaMensal = mediaMensal + dados.valor;
        }
    }
    Console.WriteLine("Maior faturamento foi no dia: "+ diaMaior +" Com o faturamento de: "+ maiorFaturamento);
    Console.WriteLine("Menor faturamento foi no dia: "+ diaMenor +" Com o faturamento de: "+ menorFaturamento);
    Console.WriteLine("A média mensal foi de: "+ mediaMensal/qntDiasCalculados);
}

 public class Dados {
    public int dia {get; set;}
    public double valor {get;set;}
}
*/

/*Questão 4 

double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

double total = sp+rj+mg+es+outros;

Console.WriteLine("Faturamento percentual por estado: SP - "+((sp/total).ToString("0.00%"))+" RJ - "+((rj/total).ToString("0.00%"))+" MG - "+((mg/total).ToString("0.00%"))+" ES - "+((es/total).ToString("0.00%")));
*/

/* Questão 5
string fruta = "Melancia";
char[] aux = fruta.ToCharArray();
string reverse = string.Empty;
Console.WriteLine("Palavra a ser revertida: "+fruta);

for (int i = aux.Length; i > 0; i--){
    reverse += aux[i-1];
}

Console.WriteLine("Resultado: "+reverse);

*/