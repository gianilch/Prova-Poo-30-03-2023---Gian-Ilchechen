namespace provaVeiculos
{
  class Program
  {
    static void Main(string[] args)
    {

      string longitude, latitude, situacaoMecanica, status, nome;
      double tanqueDeCombustivel;
      int velocidade;


      Console.WriteLine("Vamos criar um novo veiculo!");

      Console.WriteLine("Defina o nome!");
      nome = Console.ReadLine();

      Console.WriteLine("Defina a latitude!");
      latitude = Console.ReadLine();

      Console.WriteLine("Defina a longitude!");
      longitude = Console.ReadLine();

      Console.WriteLine("Defina a Situacao Mecanica (Ótima, Boa, Ruim, Péssima)!");
      situacaoMecanica = Console.ReadLine();

      Console.WriteLine("Defina a quantidade de litros tem no tanque de combustivel!");
      tanqueDeCombustivel = int.Parse(Console.ReadLine());

      Console.WriteLine("Defina a velocidade!");
      velocidade = int.Parse(Console.ReadLine());

      Console.WriteLine("Defina o status (bloqueado ou liberado)!");
      status = Console.ReadLine();

      Console.WriteLine("Vou montar o seu veiculo!");

      var veiculo = new Veiculo(latitude, longitude, situacaoMecanica, tanqueDeCombustivel, velocidade, status, nome);


      Console.WriteLine(veiculo.relatorio());
      Console.WriteLine(veiculo.posicao());

    }
  }
}
