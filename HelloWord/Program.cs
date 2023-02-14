string Nome;
string SobreNome;
int Idade;
string CorFavorita;
  Console.WriteLine(" Bom dia? Qual é o seu nome?");
    Nome = Console.ReadLine();
  Console.WriteLine(Nome+" Tudo bem com Você? Agora qual o seu sobrenome?");
    SobreNome= Console.ReadLine();
  Console.WriteLine("Agora "+Nome+" "+SobreNome+" qual a sua idade? ");
    Idade = int.Parse(Console.ReadLine());
  Console.WriteLine(Nome+" "+SobreNome+" Me diga agora Sua Cor Favorita ");
    CorFavorita = Console.ReadLine();
  Console.WriteLine(Nome+" "+SobreNome+" Confira agora Seus Dados: ");
  Console.WriteLine("Seu nome é: "+Nome);
  Console.WriteLine("Seu Sobrenome é: "+SobreNome);
  Console.WriteLine("Sua Idade é: "+Idade);
  Console.WriteLine("Sua cor Favorita é : "+CorFavorita);
  Console.WriteLine("Seus dados Estão corretos? Digite sim ou não");
  String resposta = Console.ReadLine();
      if (resposta =="sim"){
          Console.WriteLine("Obrigado pelas confirmações. Tenha um ótimo dia!");
      }else{
          Console.WriteLine("por Favor qual foi o dado que ficou incorreto: Digite nome ou sobrenome, cor ou idade.");
              string resposta2 = Console.ReadLine();
            if(resposta2 == "nome"){
                Console.WriteLine("Então agora digite seu nome novamente:");          
                Nome = Console.ReadLine();
                Console.WriteLine(Nome+" "+SobreNome+" Confira agora Seus Dados: ");
                Console.WriteLine("Seu nome é: "+Nome);
                Console.WriteLine("Seu Sobrenome é: "+SobreNome);
                Console.WriteLine("Sua Idade é: "+Idade);
                Console.WriteLine("Sua cor Favorita é : "+CorFavorita);
                Console.WriteLine("Obrigado pelas confirmações. Tenha um ótimo dia!");
          }else if(resposta2 =="sobrenome"){
              Console.WriteLine("Então agora digite seu Sobrenome novamente:");          
              SobreNome = Console.ReadLine();
              Console.WriteLine(Nome+" "+SobreNome+" Confira agora Seus Dados: ");
              Console.WriteLine("Seu nome é: "+Nome);
              Console.WriteLine("Seu Sobrenome é: "+SobreNome);
              Console.WriteLine("Sua Idade é: "+Idade);
              Console.WriteLine("Sua cor Favorita é : "+CorFavorita);
              Console.WriteLine("Obrigado pelas confirmações. Tenha um ótimo dia!");
          }else if(resposta2 =="idade"){
              Console.WriteLine("Então agora digite sua idade novamente:");          
              Idade = int.Parse(Console.ReadLine());
              Console.WriteLine(Nome+" "+SobreNome+" Confira agora Seus Dados: ");
              Console.WriteLine("Seu nome é: "+Nome);
              Console.WriteLine("Seu Sobrenome é: "+SobreNome);
              Console.WriteLine("Sua Idade é: "+Idade);
              Console.WriteLine("Sua cor Favorita é : "+CorFavorita);
              Console.WriteLine("Obrigado pelas confirmações. Tenha um ótimo dia!");
          }else if(resposta2 =="cor"){
              Console.WriteLine("Então agora digite sua cor novamente:");          
              CorFavorita = Console.ReadLine();
              Console.WriteLine(Nome+" "+SobreNome+" Confira agora Seus Dados: ");
              Console.WriteLine("Seu nome é: "+Nome);
              Console.WriteLine("Seu Sobrenome é: "+SobreNome);
              Console.WriteLine("Sua Idade é: "+Idade);
              Console.WriteLine("Sua cor Favorita é : "+CorFavorita);
              Console.WriteLine("Obrigado pelas confirmações. Tenha um ótimo dia!");
          }else{
            Console.WriteLine("por favor digite uma informação válida");      
          }
    }