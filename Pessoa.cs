namespace ClassesObjetos
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public string? Cidade {get; set;}

        public Pessoa()
        {
            Nome = "Não informado";
            Idade = 0;
        }
      
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} - Cidade: {Cidade}");
        }

    }
}