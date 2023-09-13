int points = 0;
Console.WriteLine("Welcome to the Leo Trivia!");

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

Console.WriteLine("Movin onto Nuuummbbeeerrr Ttwooooo!");
Console.WriteLine("How many hours have I spent in your walls this week?");
Console.WriteLine("a) 32 hours  b) 40 hours  c) I never left");
string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("WOW!!! You're practically a genius with the way you're blowing through these questions left and right!");
}
else
{
  Console.WriteLine("HAHAHAHAHAH, did you really think I'd leave a place as comfortable as your walls, the view is too intoxicating.");
}

Console.WriteLine("And last, BUT NOT LEAST! Nummmbbeerrrrrr Thhrrreeeeeee!");
Console.WriteLine("Does your skin feel good on you?");
Console.WriteLine("a) No b) NO c) OF COURSE NOT, I WANT TO RIP IT OFF");
string answer3 = Console.ReadLine();
if (answer3 == "c")
{
  points++;
  Console.WriteLine("HAHAHAHAHAH WOW, YOU'RE TOO GOOD AT THIS!");
}
else
{
  Console.WriteLine("I NEED MORE PASSION!");
}

Console.WriteLine("ANNNDDD WE'RE DONE.");
Console.WriteLine($"You got a total of {points} points");
if (points == 0)
{
  Console.WriteLine("This is fucking horrible, you serve zero purpose.");
}
else if (points < 3)
{
  Console.WriteLine("Not the worst, but I WANT BETTER");
}
else 
{
  Console.WriteLine("CONGRATULATIONS, YOU'VE WON!");
}

Console.WriteLine("Click any button to end this shitfest.");
Console.ReadKey();