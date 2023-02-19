Console.WriteLine("Bem vindo a Tabuada");
Console.WriteLine("Digite o Valor");
int valor  = int.Parse (Console.ReadLine());
int tabuada = 11;
int[] array = new int[tabuada];
for(int i = 0; i < tabuada; i++){
Console.WriteLine(valor +" x "+i+" = "+ i*valor );
}
