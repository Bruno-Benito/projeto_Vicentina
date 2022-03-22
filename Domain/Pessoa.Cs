public class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } //nome da pessoa

    public DateTime Nascimento { get; set; }// data de nascimento

    public bool vacina { get; set; } //se tomou vacina se sim, qual?

    public bool comorbidade { get; set; }//se tem comorbidade se sim, qual?

    public string contato { get; set; }
}