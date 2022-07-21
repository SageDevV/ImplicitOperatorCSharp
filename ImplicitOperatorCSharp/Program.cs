using ImplicitOperatorCSharp;

//Conversão implicita de string para objeto complexo HappyWay
string telefone = "55 47 992843977";
string telefoneErrado = "Teste";

var telefoneObject = new Telefone();
telefoneObject = telefone;

Console.WriteLine(telefoneObject);

//Conversão implicita de string para objeto complexo BadWay

//telefoneObject = telefoneErrado;
Console.WriteLine(telefoneObject);

//Conversão implicita de objeto complexo para string 
var telefoneObject2 = new Telefone()
{
    PrefixoPais = "55",
    DDD = "47",
    Número = "992843977"
};
string telefone2 = telefoneObject2;

Console.WriteLine(telefone2);

//Conversão implicita de objeto complexo para objeto complexo 
var pessoaEntradaViewModel = new PessoaEntradaViewModel() 
{
    NomePessoa = "Teste",
    SexoPessoa = 'S'
};

var pessoaDto = new PessoaDto();
pessoaDto = pessoaEntradaViewModel;

Console.WriteLine(pessoaDto);







