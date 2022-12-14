using CA221214;

Random rnd = new();
List<Game> games = new();

using StreamReader sr = new("..\\..\\..\\RES\\bestgames.csv");
while (!sr.EndOfStream) games.Add(new Game(sr.ReadLine()!));

Console.WriteLine($"f1: összesen {games.Count} játék szerepel a listában");

Console.WriteLine("f2: az alábbi években került a legtöbb játék a listára:");
var dgv = games.GroupBy(x => x.ReleaseYear)
    .Where(x => x.Count() > 10)
    .OrderByDescending(x => x.Count())
    .ToDictionary(x => x.Key, x => x.Count());
foreach (var kvp in dgv) Console.WriteLine($"\t{kvp.Key}: {kvp.Value}db");

var fpss = games.Where(x => x.Genre == "First-person shooter").ToList();
Console.WriteLine($"f3: összesen {fpss.Count} FPS került a listára,ú" +
    $"\n\tpéldául: {fpss[rnd.Next(fpss.Count)].Title}");

#region programozási tételekkel

//Dictionary<int, int> dic = new();

//foreach (Game g in games)
//{
//    if (!dic.ContainsKey(g.ReleaseYear))
//    {
//        dic.Add(g.ReleaseYear, 1);
//    }
//    else dic[g.ReleaseYear]++;
//}

//var kvpl = dic.ToList();

//for (int i = 0; i < kvpl.Count - 1; i++)
//{
//    for (int j = i+1; j < kvpl.Count; j++)
//    {
//        if (kvpl[j].Value > kvpl[i].Value)
//        {
//            (kvpl[i], kvpl[j]) = (kvpl[j], kvpl[i]);
//        }
//    }
//}
//foreach (var kvp in kvpl)
//{
//    if (kvp.Value > 10)
//    {
//        Console.WriteLine($"{kvp.Key}: {kvp.Value}db");
//    }
//}
#endregion