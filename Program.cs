// See https://aka.ms/new-console-template for more information
/*
//Övning 1

//Skapa en dictionary med int som nyckel och int som värde
SortedList<int, int> resultat = new SortedList<int, int>();

//skapa ett Random objekt för att slumpa
Random random = new Random();

//Gör tusen upprepnigar
for (int i = 0; i < 1000; i++)
{
    //Slumpa tal mellan 1 och 6
    int tal = random.Next(1, 7);

    //Lägg nyckel om denna inte redan finns
    if (!resultat.ContainsKey(tal))
        resultat.Add(tal, 0);

    //Öka förekomsten av tal
    resultat[tal]++;
}

//Visa resultatet
foreach (KeyValuePair<int, int> kvp in resultat)
{
    Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
}


//Övning 2

List<int> lista = new List<int>();
int input;

while (Int32.TryParse(Console.ReadLine(), out input))
    {
    if(input == 0)
        break;
    lista.Add(input);
    Console.WriteLine(lista.Average());
}

//Övning 3

List<string> deck = new List<string>();

string[] suit = { "h", "r", "k", "s" };
string[] values = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K", "E" };

foreach (string s in suit)
{
    foreach (string v in values)
    {
        deck.Add(s + v);
    }
}

Random random = new Random();

while (deck.Count() > 0)
{
    int num = random.Next(0, deck.Count());
    Console.WriteLine(deck[num]);
    deck.Remove(deck[num]);
}
*/
//Övning 4

Dictionary<string, int> cardPoints = new Dictionary<string, int>();

string[] suit = { "h", "r", "k", "s" };
string[] values = { "E", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K"};
int point = 1;

//Skapar kortlek och tilldelar värden till korten
foreach (string s in suit)
{
    foreach (string v in values)
    {
        cardPoints.Add((s + v), point);
        point++;
        if (point > 13)
        {
            point = 1;
        }
    }
}

Random r = new Random();

//Drar två slumvisa kort och jämför dem.

//while (string.IsNullOrEmpty(Console.ReadLine()))
//{
//    var rndCardOne = cardPoints.ElementAt(r.Next(0, cardPoints.Count()));
//    var rndCardTwo = cardPoints.ElementAt(r.Next(0, cardPoints.Count()));

//    Console.WriteLine("Första kortet är: {0} Andra kortet är: {1}", rndCardOne.Key, rndCardTwo.Key);
//    if (rndCardOne.Value == rndCardTwo.Value)
//    {
//        Console.WriteLine("PAR!!");
//    }    
//}

//Gör 1000 försök och räkna antalet par
int counter = 0;

for (int i = 0; i < 1000; i++)
{
    var rndCardOne = cardPoints.ElementAt(r.Next(0, cardPoints.Count()));
    var rndCardTwo = cardPoints.ElementAt(r.Next(0, cardPoints.Count()));

    if (rndCardOne.Value == rndCardTwo.Value)
    {
        counter++;
    }
}

Console.WriteLine(counter);


