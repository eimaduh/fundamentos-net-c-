//USANDO CLASSES
    using ExemploFundamentos.Commom.models;

        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Maduh";
        pessoa.Idade = 19;
        pessoa.Profissao = "Desenvolvedora";
        pessoa.Apresentar();


//TIPOS DE DADOS 
    string boasVindas = "Sejam bem vindos";
    int idade = 0;
    double altura = 1.80;
    decimal peso = 55.500M;
    bool exist = false;
    DateTime dataAtual = DateTime.Now;

    Console.WriteLine(boasVindas);
    Console.WriteLine(idade);
    Console.WriteLine(altura);
    Console.WriteLine(peso);
    Console.WriteLine(exist);
    Console.WriteLine(dataAtual);


//CONVERTENDO DADOS
    int inteiro = 0;
    string a = inteiro.ToString();
    Console.WriteLine(a);

    int num = Convert.ToInt32("25");
    Console.WriteLine(num);
    //int num = Convert.ToInt32(null) DEVOLVE 0

    int num2 = int.Parse("25");
    Console.WriteLine(num2);
    //int num2 = int.Parse(null) ERROR


//CONVERTENDO COM POSSIBILIDADE DE ERRO 
    string number = "15-";

    //USAMOS O MÉTODO TryParse POIS SE HOUVER ERRO ELE DEVOLVERÁ 0 E A APLICAÇÃO NÃO FICARÁ TRAVADA
    int.TryParse(number, out int erro);
    Console.WriteLine(erro);


//CONDICIONAL 
    int quantidadeEmEstoque = 20;
    int quantidadeCompra = 2;

    if (quantidadeCompra == 0){
        Console.WriteLine("Venda inválida");
    }
    else if (quantidadeEmEstoque >= quantidadeCompra){
        Console.WriteLine("Compra realizada com sucesso!");
    } 
    else {
        Console.WriteLine("Desculpe, não temos estoqe sficiente do produto!");
    }


//SWITCH 
    string vogal = "a";

    switch (vogal) {
        case "a": 
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("É uma vogal");
            break;
        default:
            Console.WriteLine("Não é uma vogal");
            break;

    }


//OPERADORES ARITIMÉTICOS
    Calculadora calculo = new Calculadora();

    calculo.Somar(10, 30);
    calculo.Subtrair(35, 5);
    calculo.Mulltiplicar(6, 7); 
    calculo.Dividir(90, 3);
    calculo.Potencia(5, 5);
    calculo.Seno(90);
    calculo.Coseno(90);
    calculo.Tangente(90);
    calculo.RaizQuadrada(36); 


//FOR
    int number2 = 4;

    for (int index = 0; index < 10; index++){
        Console.WriteLine($"{number2} * {index} = {number2 * index}  ");
    }


//WHILE
    int number3 = 6;
    int contador = 0;

    while(contador <= 10) {
        Console.WriteLine($"{number3} * {contador} = {number3 * contador}  ");
        contador++;
    }


//MENU INTERATIVO COM WHILE
    // string opcao;

    // while(true){
    //     Console.WriteLine("Digite a sua opção");
    //     Console.WriteLine("1 Cadastrar");
    //     Console.WriteLine("2 Logar");
    //     Console.WriteLine("3 Excluir");
    //     Console.WriteLine("4 Encerrar");
 
    //     opcao = Console.ReadLine();

    //     switch(opcao){
    //         case "1": Console.WriteLine("Cadastrar");  
    //             break;
    //         case "2": Console.WriteLine("Logar"); 
    //             break;
    //         case "3": Console.WriteLine("Excluir"); 
    //             break;
    //         case "4": Console.WriteLine("Encerrar"); 
    //             Environment.Exit(0); //vai encerrar o programa
    //             break;
    //         default: Console.WriteLine("Comando inválido"); 
    //             break;
    //     }

    // }



//ARRAY
//Uma array nasce e morre com o mesmo tamanho
    int[] arrayInteiros = new int[4];
        arrayInteiros[0] = 10;
        arrayInteiros[1] = 20;
        arrayInteiros[2] = 30;
        arrayInteiros[3] = 40;

//faz uma cópia do array alterando sua capacidade
    Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // mudando o tamanho do array

    for (int i = 0; i < arrayInteiros.Length; i++){
        Console.WriteLine($"Posição Nª {i} - {arrayInteiros[i]}");
    }

    foreach(int valor in arrayInteiros){
        Console.WriteLine($"{valor}");
    }


//LISTAS
//São melhores pq não possue tamanho fixo, sua capacidade se adequa a necessidade
//.AddRange adiciona vários itens

    List<string> listString = new List<string>();

    listString.Add("MG");
    listString.Add("GO");
    listString.Add("SC");
    listString.Add("ES");

    for (int i = 0; i < listString.Count; i++){
        Console.WriteLine($"Posição Nª {i} - {listString[i]}");
    }

    foreach(string itens in listString){
        Console.WriteLine($"{itens}");
    }












