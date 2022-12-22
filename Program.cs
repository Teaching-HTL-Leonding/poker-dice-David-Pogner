// Angabe: https://github.com/Teaching-HTL-Leonding/poker-dice-David-Pogner/blob/main/readme-de.md

int dice1 = 0;
int dice2 = 0;
int dice3 = 0;
int dice4 = 0;
int dice5 = 0;

bool fixed1 = false;
bool fixed2 = false;
bool fixed3 = false;
bool fixed4 = false;
bool fixed5 = false;

int count;
string input;

Console.Clear();

void RollDice()
{
    if (!fixed1)    
    {
        dice1 = Random.Shared.Next(1, 7);
    }

    if (!fixed2)
    {
        dice2 = Random.Shared.Next(1, 7);
    }

    if (!fixed3)
    {
        dice3 = Random.Shared.Next(1, 7);
    }

    if (!fixed4)
    {
        dice4 = Random.Shared.Next(1, 7);
    }

    if (!fixed5)
    {
        dice5 = Random.Shared.Next(1, 7);
    }
}


void PrintDice()
{
    System.Console.WriteLine($"{dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
}


void FixDice()
{
    fixed1 = false;
    fixed2 = false;
    fixed3 = false;
    fixed4 = false;
    fixed5 = false;

    do
    {
        System.Console.WriteLine($"Dice roll #{count} (out of 3): {dice1} {dice2} {dice3} {dice4} {dice5} ");
        System.Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dice)");
        input = Console.ReadLine()!;

        switch (input)
        {
            case "1":
                if (fixed1) { fixed1 = false; }
                else { fixed1 = true; }
                break;

            case "2":
                if (fixed2) { fixed2 = false; }
                else { fixed2 = true; }
                break;

            case "3":
                if (fixed3) { fixed3 = false; }
                else { fixed3 = true; }
                break;

            case "4":
                if (fixed4) { fixed4 = false; }
                else { fixed4 = true; }
                break;

            case "5":
                if (fixed5) { fixed5 = false; }
                else { fixed5 = true; }
                break;
        }

        System.Console.Write("Fixed: ");
        if (fixed1) { System.Console.Write("1 "); }
        if (fixed2) { System.Console.Write("2 "); }
        if (fixed3) { System.Console.Write("3 "); }
        if (fixed4) { System.Console.Write("4 "); }
        if (fixed5) { System.Console.Write("5 "); }
        
        
    } while (input != "r");
}

for (count = 1; count <= 3; count++)
{    
    RollDice();
    PrintDice();

    if (count < 3)
    {
        FixDice();
        if (fixed1 == true && fixed2 == true && fixed3 == true && fixed4 == true && fixed5 == true)
        {
            System.Console.WriteLine("Game Over! You fixed all dices ");
            return;
        }
    }
}

