public class Paciente
{
    public int IdPaciente { get; set; }
    public string Nome { get;set;}
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string DataNascimento { get; set; }
    
    public Paciente(int IdPaciente, string Nome, string Cpf, string Email, string Telefone,string DataNascimento)
    {
        
        this.IdPaciente = IdPaciente;
        this.Nome = Nome;
        this.Cpf = Cpf;
        this.Email = Email;
        this.Telefone = Telefone;
        this.DataNascimento=DataNascimento;
    }

}
