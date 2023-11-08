Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 ==roll2) || (roll2 == roll3) || (roll1 == roll3)) //Combined three Boolean expressions to create one composite Boolean expression, sometimes known as a "compound condition"
//the || are logical OR operators, these basically say "either the expression to my left OR the expression to my right must be true in order for the entire expression to be true."

{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("You lost!");
}




