// Programação Estruturada - 15 de Abril de 2025
void ex1() // Soma de Dois Numeros
{
    Console.Write("Valor 1: ");
    int n1 = int.Parse(Console.ReadLine()!);
    Console.Write("Valor 2: ");
    int n2 = int.Parse(Console.ReadLine()!);
    int soma = n1 + n2;
    Console.WriteLine("O resultado da soma é {0}.", soma);
}

void ex2() // Calculo da Idade
{
    Console.Write("Ano de Nascimento: ");
    int anoNascimento = int.Parse(Console.ReadLine()!);
    Console.Write("Ano Atual: ");
    int anoAtual = int.Parse(Console.ReadLine()!);
    int idade = anoAtual - anoNascimento;
    Console.WriteLine("O resultado da idade é {0} anos.", idade);
}

void ex3()  // Conversão de Km para m
{
    Console.Write("Distância em Km: ");
    double km = double.Parse(Console.ReadLine()!);
    double m = km * 1000;
    Console.WriteLine("A distância em quilometros equivale a {0} metros.", m);

}

void ex4() //  Calculo Média
{
    Console.Write("Nota 1: ");
    double nota1 = double.Parse(Console.ReadLine()!);
    Console.Write("Nota 2: ");
    double nota2 = double.Parse(Console.ReadLine()!);
    Console.Write("Nota 3: ");
    double nota3 = double.Parse(Console.ReadLine()!);
    Console.Write("Nota 4: ");
    double nota4 = double.Parse(Console.ReadLine()!);
    double media = (nota1 + nota2 + nota3 + nota4) / 4;
    Console.WriteLine("A média das notas é {0}.", media);
}

void ex5() // Conversao de Moeda
{
    Console.Write("Informe o valor em reais: R$ ");
    double real = double.Parse(Console.ReadLine()!);
    Console.Write("Informe a cotação do dolar: R$ ");
    double ctd = double.Parse(Console.ReadLine()!);
    double dolar = real / ctd;
    Console.WriteLine("O valor em dolar é de {0} dolares.", dolar);
}


void ex6() // Volume de um Cilindro
{
    Console.Write("Informe o raio da base do cilindro: ");
    double raio = double.Parse(Console.ReadLine()!);
    Console.Write("Informe a altura do cilindro: ");
    double altura = double.Parse(Console.ReadLine()!);
    double pi = 3.14;
    double area = pi * Math.Pow(raio, 2) * altura;
    Console.WriteLine("O valor do volume do cilindro é {0:f2}.", area);
}

void ex7() // Calculo da Hipotenusa
{
    Console.Write("Cateto 1: ");
    double cat1 = double.Parse(Console.ReadLine()!);
    Console.Write("Cateto 2: ");
    double cat2 = double.Parse(Console.ReadLine()!);
    double hipotenusa = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
    Console.WriteLine("O valor da hipotenusa é {0}.", hipotenusa);
}

void ex8()  // Conversão de Horas para Minutos
{
    Console.Write("Informe as horas: ");
    int horas = int.Parse(Console.ReadLine()!);
    int minutos = horas * 60;
    Console.WriteLine("{0} horas são {1} minutos.", horas, minutos);
}


void ex9() // Calculo do IMC
{
    Console.Write("Informe o peso: ");
    double peso = double.Parse(Console.ReadLine()!);
    Console.Write("Informe a altura: ");
    double altura = double.Parse(Console.ReadLine()!);
    double imc = peso / altura;
}

void ex10()//Calculo de Juros Simples
{
    Console.Write("Capital (C): ");
    double capital = double.Parse(Console.ReadLine()!);
    Console.Write("Taxa de Juros (%): ");
    double taxaJuros = double.Parse(Console.ReadLine()!);
    Console.Write("Tempo: ");
    double tempo = double.Parse(Console.ReadLine()!);

    double juroSimples = capital * taxaJuros * tempo;
    Console.WriteLine("O valor do juros simples é {0}.", juroSimples);

}

// ex1();
// ex2();
// ex3();
// ex4();
// ex5();
// ex6();
// ex7();
// ex8();
// ex9();
ex10();

