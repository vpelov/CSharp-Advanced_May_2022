Dictionary<string, List<double>> dataDict = new Dictionary<string, List<double>>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    object SrtingSplitOptions = null;
    string[] stringArr = Console.ReadLine()
        .Split(' ')
        .ToArray();
    string name = stringArr[0];
    double grade = double.Parse(stringArr[1]);
    if (!dataDict.ContainsKey(name))
    {
        List<double> current = new List<double>();
        current.Add(grade);
        dataDict.Add(name, current);
    }
    else
    {
        dataDict[name].Add(grade);
    }
}

foreach (var item in dataDict)
{
    Console.Write($"{item.Key} -> ");
for (int i = 0; i < item.Value.Count; i++)
    {
        Console.Write($"{item.Value[i]:f2} ");
    }
    Console.WriteLine($"(avg: { item.Value.Average():f2})");

 }

