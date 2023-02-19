Console.WriteLine("Bem vindo ao sistema de descoberta de Triangulo");
Console.WriteLine("Digite o primeiro valor");
float lado1 = float.Parse (Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
float lado2 = float.Parse (Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
float lado3 = float.Parse (Console.ReadLine());

if(lado1+lado2>lado3 ||lado3+lado2>lado1 ||lado1+lado3>lado2){
if(lado1==lado2 && lado2==lado3){
Console.WriteLine("Esse é um triangulo Equilatero");  
}
else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3){
Console.WriteLine("Esse é um triangulo Isóseles");   
}else if(lado1 != lado2 && lado2 != lado3){
Console.WriteLine("Esse é um triangulo Escaleno");   
}
}else{
Console.WriteLine("não é triangulo");
}