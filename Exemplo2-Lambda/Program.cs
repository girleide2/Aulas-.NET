#region Lambda examples 
/*
Func<int, int, int> sum = (x,y) => x + y;
Console.WriteLine($"Sum: {sum(10,20)}");

Func<string, int, string> isBiggerThan = (string s, int x) => s.Length > x ? "yes" : "no";
*/
string[] people = {"maria", "joao", "jose"};
char letter = 'a';
Console.WriteLine($" Pessoas que coném a letra a no nome '{letter}': {string.Join(",", people.Where(x => x.Contains(letter)))}");


List<int> lista = {2,3,4};
lista.sum(x=>x)
lista.Where(x => x > 2).sum() //percorrer a lista onde x for maior que dois, somar os termos
#endregion

