double salario;
double desconto;
Console.WriteLine("Olá gostaria de saber quanto vai pagar de imposto? Digite o seu Salário Bruto?");
salario = double.Parse (Console.ReadLine());
if(salario <=900){
desconto =0;
}else if(salario>=1000&&salario<=1500){
  desconto = salario *0.05;
Console.WriteLine($"O seu desconto devido é de R$ {desconto}."); 
}else if(salario>1500 && salario>=2500){
  desconto = salario * 0.10;
Console.WriteLine("O seu desconto devido é de R$"+desconto+"."); 
}else if(salario>2500){
  desconto = salario * 0.20;
Console.WriteLine("O seu desconto devido é de R$"+desconto+".");   
}
