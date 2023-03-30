

class Veiculo
{
  private string _longitude { get; set; }
  private string _latitude { get; set; }
  private string _situacaoMecanica { get; set; }
  private double _tanqueDeCombustivel { get; set; }
  private int _velocidade { get; set; }
  private string _status { get; set; }
  private string _nome { get; set; }

  public Veiculo(string longitude, string latitude, string situacaoMecanica, double tanqueCombustivel, int velocidade, string status, string nome)
  {
    Longitude = longitude;
    Latitude = latitude;
    SituacaoMecanica = situacaoMecanica;
    TanqueDeCombustivel = tanqueCombustivel;
    Velocidade = velocidade;
    Status = status;
    Nome = nome;
  }

  public string Longitude
  {
    get => _longitude;
    set => _longitude = value;
  }

  public string Latitude
  {
    get => _latitude;
    set => _latitude = value;
  }

  public string SituacaoMecanica
  {
    get => _situacaoMecanica;
    set => _situacaoMecanica = value;
  }

  public double TanqueDeCombustivel
  {
    get => _tanqueDeCombustivel;
    set => _tanqueDeCombustivel = value;
  }

  public int Velocidade
  {
    get => _velocidade;
    set => _velocidade = value;
  }

  public string Status
  {
    get => _status;
    set => _status = value;
  }

  public string Nome
  {
    get => _nome;
    set => _nome = value;
  }

  public string posicao()
  {
    string posicao = "O caminhão está localizado na longitude: " + Longitude + " e Latitude: " + Latitude;
    return posicao;
  }

  public string relatorio()
  {
    string relatorio = "O veiculo que você criou é o: " + Nome + ", a situacao mecânica dele é " + SituacaoMecanica + ", ele possui " + TanqueDeCombustivel + " L de combustivel, atualmente ele está " + Status + " e sua velocidade é de " + Velocidade + " KM/H.";
    return relatorio;

  }

}