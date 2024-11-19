using Orai1119;

List <Dolgozo> berek = new List<Dolgozo>();

using (var sr = new StreamReader("../../../src/berek2020.txt"))
{
    _ = sr.ReadLine();
    while (!sr.EndOfStream)
	{
        berek.Add(new Dolgozo(sr.ReadLine()));

    }
}

// 3. feladat
Console.WriteLine(berek.Count);

// 4. feladat
var f4 = berek.Average(x => x.Ber);
Console.WriteLine($"{f4 / 1000:.0} ezer forint");

// 5. feladat
var input = Console.ReadLine();
// 6. feladat
if (berek.Any(x=> x.Reszleg == input))
{
var f5 = berek.Where(x=> x.Reszleg == input).MaxBy(x => x.Ber);
Console.WriteLine($"{f5.ToString()}");
}
else
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}
// 7. feladat
var f7 = berek.GroupBy(x => x.Reszleg);
foreach (var item in f7)
{
    Console.WriteLine($"{item.Key} {item.Count()}");
}


// 20 percig tartott
