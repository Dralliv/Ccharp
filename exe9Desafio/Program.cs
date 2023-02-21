List<double> transacao = new List<double>();
string opcao;

do{
  Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar:");
  Console.WriteLine("1. Adicionar Transação;");
  Console.WriteLine("2. Consultar extrato;");
  Console.WriteLine("3. Sair;");
  opcao = Console.ReadLine();

if (opcao == "1") {
    Console.WriteLine ("Digite o valor a ser depositado (em R$): ");
    double valor = double.Parse(Console.ReadLine());
    transacao.Add(valor);
    //Console.WriteLine("O valor depositado foi:");
    // foreach(var valor in transacao){
    //   Console.WriteLine("R$ " + valor);
    // }
}

else if (opcao == "2") {
    Console.WriteLine ("Seu Extrato (em R$): ");
    double saldo = 0;
    foreach(var valor in transacao){
        saldo = saldo + valor;
        Console.WriteLine($"R$ " + valor);
    }
    Console.WriteLine ("Seu Saldo (em R$): " + saldo);
}
 
} while(!(opcao == "3"));