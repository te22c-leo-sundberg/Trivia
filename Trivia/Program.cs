int points = 0;
Console.WriteLine("Welcome to the Leo Trivia!");

// -----------------------------------------------------------------------------

Console.WriteLine("Allllriighhhttt! Let's get this trivia rolling!");
Console.WriteLine("Quueesstiiooon Nummberr Oooonee!");
Console.WriteLine("Which fictional character is objectionally the hottest?");
Console.WriteLine("a) Bridget  b) Astolfo  c) Felix");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "a")
{   
  points++;
  Console.WriteLine("Wow! You're a natural. Keep it up like this and we could be friends!");
}
else
{
  Console.WriteLine("What the fuck? No. Why did you think that would even be remotely close to the correct answer?");
}

// -----------------------------------------------------------------------------

Console.WriteLine("Movin onto Nuuummbbeeerrr Ttwooooo!");
Console.WriteLine("");
Console.WriteLine("a) Galactus  b) Unicorn  c) Unicron");
string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("WOW!!! You're practically a genius with the way you're blowing through these questions left and right!");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine("3: Vad heter Scorponoks headmaster?");
Console.WriteLine("a) Lord Zarak  b) Lord Hi-Q  c) Lord Razorfist");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du har alltså ingen koll alls.");
}
else if (points < 3)
{
  Console.WriteLine("OK, du har hyfsad koll - eller gissade rätt en eller ett par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();