double etanol, gasolina, Calculo = 0;

Console.WriteLine(@"/////  Preço da Gasolina e do Alcool  \\\\\");

Console.WriteLine("Preço do Etanol...: ");
etanol = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Preço do Gasolina...: ");
gasolina = Convert.ToDouble(Console.ReadLine());

void Calculo_Preco(){
    Calculo = etanol / gasolina;

    if(Calculo > 0.73){
        Console.WriteLine("Abasteça com Gasolina Mais em Conta");
        
    }
}

Calculo_Preco();

Console.WriteLine($"{Calculo}");