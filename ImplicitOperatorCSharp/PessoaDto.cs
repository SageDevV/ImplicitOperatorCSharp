namespace ImplicitOperatorCSharp
{
    public class PessoaDto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public static implicit operator PessoaDto(PessoaEntradaViewModel pessoaEntradaViewModel)
        {
            return new PessoaDto()
            {
                Nome = pessoaEntradaViewModel.NomePessoa,
                Idade = pessoaEntradaViewModel.IdadePessoa,
                Sexo = pessoaEntradaViewModel.SexoPessoa
            };
        }

        public override string ToString()
        {
            return $"{Nome} - {Idade} - {Sexo}";
        }
    }
}
