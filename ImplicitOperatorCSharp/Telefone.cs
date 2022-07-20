namespace ImplicitOperatorCSharp
{
    public class Telefone
    {
        public string PrefixoPais { get; set; }
        public string DDD { get; set; }
        public string Número { get; set; }

        public static implicit operator Telefone (string telefone)
        {
            try
            {
                var data = telefone.Split(" ");
                return new Telefone
                {
                    PrefixoPais = data[0],
                    DDD = data[1],
                    Número = data[2]
                };
            }
            catch (Exception)
            {
                throw new InvalidCastException("Conversão implicita inválida");
            }
            
        }

        public static implicit operator string (Telefone telefone)
            => $"{telefone.PrefixoPais} {telefone.DDD} {telefone.Número}";
    }
}





