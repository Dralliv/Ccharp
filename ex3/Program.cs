float nota1;
float nota2;
float nota3;

Console.WriteLine("Bem vindo a calculadora de média! Por gentileza digite seu nome.");
string nome = Console.ReadLine();
Console.WriteLine(nome+" digite sua primeira nota?");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota?");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua terceira nota?");
nota3 = float.Parse(Console.ReadLine());
float media = (nota1+nota2+nota3)/3;
if(media >=6){
  Console.WriteLine(nome+"  Aprovado com a nota "+media+" .");
}else if(media>=5 && media<6){
Console.WriteLine(nome+"  Recuperação com a nota "+media+" ."); 
}else{
  Console.WriteLine(nome+"  reprovado com a nota "+media+" ."); 
}



