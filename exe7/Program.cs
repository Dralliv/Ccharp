Console.WriteLine("Boletim 2.0");
Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine("Quantas notas serão usadas para a média?");
int quantNotas;
while(!int.TryParse(Console.ReadLine(), out quantNotas)){
Console.WriteLine("Numero Invalido, por favor entre novamente com a nota");
}
List<double> notas = new List<double>();

for(int i = 0; i < quantNotas; i++){
  Console.WriteLine("Digite a " + (i +1) + " Nota:");
  notas.Add(double.Parse(Console.ReadLine()));
}
double soma = 0;
Console.WriteLine($"O Boletin de {nome}: ");
foreach(var nota in notas){
  Console.WriteLine(nota);
  soma+= nota;
  //soma = soma +nota;
}
double media = soma / quantNotas;
Console.WriteLine("A média é de : "+ media);