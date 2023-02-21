int numeroAnterior = 0;
int numeroAtual = 1;
int novoNumero;
int fibonacci;
Console.WriteLine  ("Digite um numero para quantidade de seguencias");
novoNumero = int.Parse(Console.ReadLine());   
   for (int i = 0; i <novoNumero;  i++ )
 {  
       fibonacci = numeroAnterior + numeroAtual; 
       Console.WriteLine  (fibonacci);
       numeroAnterior = numeroAtual; 
       numeroAtual = fibonacci;   
  }