//Crie uma calculadora simples usando um switch para realizar as operações de adição, subtração, multiplicação e divisão com base na escolha do usuário.
double num1, num2;
String operacao;
bool ligado = true;
double Resultado;
while (ligado){
    Console.WriteLine("Digite o valor do primeiro numero: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o valor do segundo numero: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a operacao que deseja realizar: \n 1- Somar \n 2- Subtrair \n 3- Multiplicar \n 4- Dividir \n 5- Sair");
    operacao = Console.ReadLine();

    switch(operacao)
    {
        case "1":
        Resultado = num1 + num2;
        Console.WriteLine($"O Valor da soma é {Resultado}");
        break;

        case "2":
        Resultado = num1 - num2;
        Console.WriteLine($"O Valor da subtração é {Resultado}");
        break;

        case "3":
        Resultado = num1 * num2;
        Console.WriteLine($"O Valor da multiplicação é {Resultado}");
        break;

        case "4":
        Resultado = num1 / num2;
        Console.WriteLine($"O Valor da divisão é {Resultado}");
        break;

        case "5":
        ligado = false;
        break;  
    }    
}