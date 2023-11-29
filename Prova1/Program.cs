﻿using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Medico{

    private List<(string Nome, int DataNascimento, string CPF, string CRM)> DadosMedico = new List<(string Nome, int DataNascimento, string CPF, string CRM)>();
    public List<( string Nome, int DataNascimento, string CPF, string CRM)> getDadosMedico(){
    return DadosMedico;
    }

    public void pegaDadosMedico(){

        Console.WriteLine($"Digite o nome do medico:");
        string Nome = Console.ReadLine();
        Console.WriteLine($"Digite a data de nascimento:");
        int DataNascimento = int.Parse(Console.ReadLine());
        string cpf = string.Empty;

    try
    {
        Console.WriteLine($"Digite o CPF (Apenas numeros):");
        cpf = Console.ReadLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro! Digite apenas numeros");
    }
    var pacienteExistente = DadosMedico.FirstOrDefault(p => p.CPF == cpf);

    if (!string.IsNullOrEmpty(MedicoExistente.CPF))
    {
        Console.WriteLine($"O CPF {cpf} já existe no sistema");
        return;
    }
        Console.WriteLine($"Digite o CRM");
        string CRM = Console.ReadLine();
        var novoMedico = (Nome, DataNascimento, CPF, CRM);
        DadosMedico.Add(novoMedico);
    }

}

public class Paciente{
    private List<(string Nome, int DataNascimento, string CPF, string Sexo, string Sintomas)> DadosPaciente = new List<(string Nome, int DataNascimento, string CPF, string Sexo, string Sintomas)>();
    public List<( string Nome, int DataNascimento, string CPF, string Sexo, string Sintomas)> getDadosPaciente(){
    return DadosPaciente;
}
    public void pegaDadosPaciente(){
    Console.WriteLine($"Digite o nome do paciente:");
    string Nome = Console.ReadLine();
    Console.WriteLine($"Digite a data de nascimento:");
    int DataNascimento = int.Parse(Console.ReadLine());
    string cpf = string.Empty;

    try
    {
        Console.WriteLine($"Digite o CPF (Apenas numeros):");
        cpf = Console.ReadLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro! Digite apenas numeros");
    }
    var pacienteExistente = DadosPaciente.FirstOrDefault(p => p.CPF == cpf);

    if (!string.IsNullOrEmpty(pacienteExistente.CPF))
    {
        Console.WriteLine($"O CPF {cpf} já existe no sistema");
        return;
    }
    Console.WriteLine($"Digite o sexo do paciente");
    string Sexo = Console.ReadLine();
    Console.WriteLine($"Digite os sintomas do paciente");
    string Sintomas = Console.ReadLine();
    var novoPaciente = (Nome, DataNascimento, cpf, Sexo, Sintomas);

    DadosPaciente.Add(novoPaciente);
}

public class Relatorios{
    Medico medico = new Medico();
    Paciente paciente = new Paciente();

/*public void RelatorioIdadeMedico(){

    Console.WriteLine("Digite a idade mínima:");
    int minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade máxima:");
    int maximo = int.Parse(Console.ReadLine());
    //fazer validação ppra idade

    var MedicoPorIdade = medico.DadosMedico.Where(p => p.Idade >= minimo && p.Idade<= maximo);

    Console.WriteLine($"Medicos com idade entre {minimo} e {maximo}:");
        foreach (var med in paciente.DadosMedico)
            {
                Console.WriteLine($"Nome: {med.Nome}, Data de nascimento: {med.DataNascimento}, CPF: {med.CPF}, Sexo:{med.Sexo}, Sintomas:{med.Sintomas} ");
            } 
}

   public void RelatorioIdadePaciente(){
    Console.WriteLine("Digite a idade mínima:");
    int minimo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade máxima:");
    int maximo = int.Parse(Console.ReadLine());
    //fazer validação ppra idade

    var PacientePorIdade = paciente.DadosPaciente.Where(p => p.Idade >= minimo && p.Idade<= maximo);

    Console.WriteLine($"Medicos com idade entre {minimo} e {maximo}:");
        foreach (var pac in paciente.DadosPaciente)
            {
                Console.WriteLine($"Nome: {pac.Nome}, Data de nascimento: {pac.DataNascimento}, CPF: {pac.CPF}, Sexo:{pac.Sexo}, Sintomas:{pac.Sintomas} ");
            } 
}*/
public void PacienteSexo(){
    string sexo;

    Console.Write("Digite o sexo do paciente");
    sexo = Console.ReadLine();

    var PacientePorSexo = paciente.DadosPaciente.Where(p => p.Sexo == sexo).ToList();

    Console.WriteLine($"Pacientes com o sexo {sexo}");
    foreach (var Paciente in paciente.DadosPaciente)
    {
        Console.WriteLine($"Nome: {Paciente.Nome}, Data de nascimento: {Paciente.DataNascimento}, CPF: {Paciente.CPF}, Sexo:{Paciente.Sexo}, Sintomas:{Paciente.Sintomas} ");
    } 

}
public void PacienteOrdemAlfabetica(){

}

public void PacienteSintoma(){
    string sintoma;

    Console.Write("Digite o sexo do paciente");
    sintoma = Console.ReadLine();

    var PacientePorSintoma = paciente.DadosPaciente.Where(p => p.Sintomas == sintoma).ToList();

    Console.WriteLine($"Paciente com o sexo {sintoma}");
    foreach (var Paciente in paciente.DadosPaciente)
    {
        Console.WriteLine($"Nome: {Paciente.Nome}, Data de nascimento: {Paciente.DataNascimento}, CPF: {Paciente.CPF}, Sexo:{Paciente.Sexo}, Sintomas:{Paciente.Sintomas} ");
    } 
}
}
public class Program{

    static void Main(){
        Medico medico = new Medico();
        Paciente paciente = new Paciente();
        Relatorios relatorio = new Relatorios();


    paciente.pegaDadosPaciente();
    relatorio.PacienteSexo();
    relatorio.PacienteSintoma();

    
    }
}

}
