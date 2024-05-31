Console.Clear();

Console.WriteLine("--- Etanol ou Gasolina? ---");

Console.Write("\nDigite o preço do etanol (R$).....: ");
decimal precoEtanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
decimal precoGasolina = Convert.ToDecimal(Console.ReadLine());

double razao = RetornarRazao();

Console.WriteLine($"\nO preço do etanol corresponde a {razao * 100:N1}% do preço da gasolina.");

bool viabilidade = RevelarAbastecimentoViavel();

if (viabilidade)
{
    Console.WriteLine("\nRecomendação: Abasteça com GASOLINA.");
}

else
{
    Console.WriteLine("\nRecomendação: Abasteça com ETANOL.");
}

double RetornarRazao()
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}

bool RevelarAbastecimentoViavel()
{
    bool viabilidade = razao * 100 >= 73;
    return viabilidade;
}