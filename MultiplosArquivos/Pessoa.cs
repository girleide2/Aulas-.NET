using System.Reflection;

namespace Namespace;
public class Pessoa
{
    float Altura;
    string Nome;
    public Pessoa(float altura, string nome){
        Altura = altura;
        Nome = nome;
    }
    public int altura {get; set};
    public string nome {get; set;}

}