
while(true){
    Console.WriteLine("Digite seu nome:");
    var nome = Console.ReadLine();
    Console.WriteLine($"Olá {nome}");
    Console.WriteLine("Digite sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite sua altura:");
    float altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu peso:");
    float peso = float.Parse(Console.ReadLine());

    float imc = peso/(altura*altura);

    if(imc<=18.5)
    {
        if(idade<=10)
        {
            Console.WriteLine($"{nome} é uma criança com o imc de {imc}, considerado abaixo do peso.");
        }
        if(idade>10 & idade<=20)
        {
            Console.WriteLine($"{nome} é um(a) adolecente com o imc de {imc}, considerado abaixo do peso.");
        }
        if(idade>=21 & idade<=60){
        
            Console.WriteLine($"{nome} é um(a) adult(a) com o imc de {imc}, considerado abaixo do peso.");
        }
        if(idade>60)
        {
            Console.WriteLine($"{nome} é um(a) idoso(a) com o imc de {imc}, considerado abaixo do peso.");
        }
    } 
    if(imc>18.5 & imc<=24.9)
    {
        if(idade<=10)
        {
            Console.WriteLine($"{nome} é uma criança com o imc de {imc}, considerado normal.");
        }
        if(idade>10 & idade<=20)
        {
            Console.WriteLine($"{nome} é um(a) adolecente com o imc de {imc}, considerado normal.");
        }
        if(idade>=21 & idade<=60){
        
            Console.WriteLine($"{nome} é um(a) adult(a) com o imc de {imc}, considerado normal.");
        }
        if(idade>60)
        {
            Console.WriteLine($"{nome} é um(a) idoso(a) com o imc de {imc}, considerado normal.");
        }
    }  
    if(imc>=25 & imc<=29.9)
    {
        if(idade<=10)
        {
            Console.WriteLine($"{nome} é uma criança com o imc de {imc}, considerado sobrepeso.");
        }
        if(idade>10 & idade<=20)
        {
            Console.WriteLine($"{nome} é um(a) adolecente com o imc de {imc}, considerado sobrepeso.");
        }
        if(idade>=21 & idade<=60){
        
            Console.WriteLine($"{nome} é um(a) adult(a) com o imc de {imc}, considerado sobrepeso.");
        }
        if(idade>60)
        {
            Console.WriteLine($"{nome} é um(a) idoso(a) com o imc de {imc}, considerado sobrepeso.");
        }
    }     
    else
    {
        if(idade<=10)
        {
            Console.WriteLine($"{nome} é uma criança com o imc de {imc}, considerado obesidade.");
        }
        if(idade>10 & idade<=20)
        {
            Console.WriteLine($"{nome} é um(a) adolecente com o imc de {imc}, considerado obesidade.");
        }
        if(idade>=21 & idade<=60){
        
            Console.WriteLine($"{nome} é um(a) adult(a) com o imc de {imc}, considerado obesidade.");
        }
        else
        {
            Console.WriteLine($"{nome} é um(a) idoso(a) com o imc de {imc}, considerado obesidade.");
        }
    } 
    Console.WriteLine("Deseja emitir outro relatorio? (S/N)");
    string resposta = Console.ReadLine();
    
    if(resposta == "s")
        continue;
    if(resposta == "n")
        break;
    else
        Console.WriteLine("Digite (S/N)");

}



    
