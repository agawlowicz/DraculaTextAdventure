using System;
using System.Threading;

namespace DraculaTextAdventure
{
    public class Decisions
    {
        public Decisions()
        {
        }

        public static void Converse()
        {
            Console.WriteLine("You begin talking with the women, and they seem to have some sort of control over you.\n" +
                "They flirt with you, putting you under their spell of seduction.");
            Thread.Sleep(500);
            Console.WriteLine("You kiss the women!");
            Thread.Sleep(500);
            Console.WriteLine("The next day you wake up as a new man --a dead man to be exact. You have become a vampire!");
            Thread.Sleep(500);

            Console.WriteLine("Game Over");
            Program.cont = false;
        }

        public static void Escape()
        {
            Console.WriteLine("You plot an escape!");
            Thread.Sleep(300);

            Console.WriteLine("In the middle of the day, you pick the lock on your door and escape on foot!\n");
            Thread.Sleep(300);

            Console.WriteLine("...you underestimated the time it would take to reach the village and notice the sun is setting...");
            Thread.Sleep(300);

            Console.WriteLine("Appearing out of mist, Dracula suddenly stands before you.");
            Thread.Sleep(300);

            Console.WriteLine("Your escape failed, and you remain a prisoner for the rest of your life.");
            Thread.Sleep(300);

            Console.WriteLine("Game Over");
            Program.cont = false;
        }

        public static void GamePlay()
        {
            Console.WriteLine("You travel to faraway land and arrive at your last stop before Dracula's castle.\n" +
                    "It's a small village where everyone seems to worry for you. They do the sign of the cross and warn you not to visit.\n");
            Thread.Sleep(500);

            Console.WriteLine("You have the following options:\n" +
                "1) Listen to the villagers and turn back\n" +
                "2) Ignore the villagers and continue on to Dracula's castle.\n");

            var choice = IsValidChoice();

            if (choice == 1)
            {
                Console.WriteLine("Congrats! You have common sense! You have survived!");
                Thread.Sleep(300);

                Console.WriteLine("Game Over");
                Program.cont = false;
            }
            else
            {
                IgnoreVillagers();
            }
        }

        public static void IgnoreVillagers()
        {
            Console.WriteLine("You ignore the villagers and continue on to Dracula's castle arriving around midnight.\n");
            Thread.Sleep(500);

            Console.WriteLine("When you arrive at the castle, Dracula greets you and shows you to a room.\n" +
            "He then leaves the room and locks the door behind him.\n");
            Thread.Sleep(500);

            Console.WriteLine("You find this strange.");
            Thread.Sleep(500);

            Console.WriteLine("You have the following options:\n" +
                "1) Try to pick the lock\n" +
                "2) Wait for Dracula to return\n");
            var choice = IsValidChoice();
            if (choice == 1) { PickLock(); } else { WaitForDracula(); }
        }

        public static void Instructions()
        {
            Console.WriteLine("Welcome to your adventure investigating Dracula! See how long you survive!\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You have heard stories of a mysterious man named Dracula.\n" +
                "Apparently, anyone who visits Dracula never returns.\n");
            Thread.Sleep(500);

            Console.WriteLine("Naturally, you decide to visit.\n");
            Thread.Sleep(500);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public static void IsNotVampire()
        {
            Console.WriteLine("You are an idiot.\n");
            Thread.Sleep(250);
            Console.WriteLine("You remain a prisoner for the rest of your life--which ends shortly.\nDeath by vampire.");
            Thread.Sleep(500);

            Console.WriteLine("Game Over");
            Program.cont = false;
        }

        public static int IsValidChoice() //returns 1 or 2 for decision
        {
            bool isTrue;
            int choice;
            do
            {
                isTrue = int.TryParse(Console.ReadLine(), out choice);
                if (choice != 1 && choice != 2) { isTrue = false; }
            } while (!isTrue);
            Console.Clear();
            return choice;
        }

        public static void IsVampire()
        {
            Console.WriteLine("You come to the conclusion that he is in fact a vampire!");
            Thread.Sleep(500);

            Console.WriteLine("Now that you know Dracula is a vampire, you must decide your next steps.\n" +
                "1) Kill Dracula\n" +
                "2) Plot an escape\n");
            var choice = IsValidChoice();

            if (choice == 1) { KillDracula(); } else { Escape(); }
        }

        public static void KillDracula()
        {
            Console.WriteLine("You decide to attempt to kill Dracula.");
            Thread.Sleep(500);

            Console.WriteLine("While the sun is shining, you scale the wall and enter Dracula's coffin room with a large knife.");
            Thread.Sleep(300);
            Console.WriteLine("You open the coffin and hold the knife over Dracula's heart.");
            Thread.Sleep(300);
            Console.WriteLine("Using all your force, you plunge the dagger into his heart.");
            Thread.Sleep(300);

            Console.WriteLine("Dracula's eyes open, he pulls the dagger from his heart!");
            Thread.Sleep(300);

            Console.WriteLine("With shock, you stumble backwards and fall out the window to your death.");
            Thread.Sleep(500);

            Console.WriteLine("Apparently you didn't know the proper way to end a vampire's life...");
            Thread.Sleep(300);

            Console.WriteLine("Game Over");
            Program.cont = false;
        }

        public static void PickLock()
        {
            Console.WriteLine("You are successful picking the lock and free yourself from the room!\n");
            Console.WriteLine("While wandering the halls of the castle, you run into three stunning women.\n" +
                "You have the following options:\n" +
                "1) Run away\n" +
                "2) Converse with the women\n");
            var choice = IsValidChoice();

            if (choice == 1) { RunAway(); } else { Converse(); }
        }

        public static void RunAway()
        {
            Console.WriteLine("The women's presence surprises you, so you begin running away.");
            Thread.Sleep(500);
            Console.WriteLine("You run all the way outside when you are attacked and killed by wolves!");
            Thread.Sleep(500);
            Console.WriteLine("Turns out Dracula can control wolves...you didn't know that?");
            Thread.Sleep(500);

            Console.WriteLine("Game Over");
            Program.cont = false;
        }

        public static void ScaleWall()
        {
            Console.WriteLine("Your curiosity gets the best of you.\n" +
                "You climb out of your window and begin climbing down the wall.\n");
            Thread.Sleep(500);
            
            Console.WriteLine("You enter through the window to find a coffin in the center of the room.\n" +
                "You work up the confidence to open the coffin...you find Dracula lying there!\n" +
                "Confused and shocked, you close the coffin and climb back to your room as quickly as possible");
            Thread.Sleep(500);

            Console.WriteLine("You return to your room to contemplate what you just saw.\n" +
                "You have heard stories of vampires, but they can't actually be real, right?\n");
            Thread.Sleep(500);

            Console.WriteLine("You're a skeptic, but you can't ignore your observations.\n" +
                "Over the next few days, you notice more about Dracula.\n" +
                "He never eats and can never be found during the day (because he's sleeping in his coffin).\n");
            Thread.Sleep(500);

            Console.WriteLine("You decide:\n" +
                "1) No way is Dracula a vampire\n" +
                "2) Dracula must be a vampire\n");

            var choice = IsValidChoice();

            if(choice == 1) { IsNotVampire(); } else { IsVampire(); }
        }

        public static void WaitForDracula()
        {
            Console.WriteLine("You wait for Dracula.");
            Thread.Sleep(500);
            Console.WriteLine("...you keep waiting");
            Thread.Sleep(500);
            Console.WriteLine("...and waiting...");
            Thread.Sleep(500);

            Console.WriteLine("You wait an entire day and eventually he returns when the sun sets.\n" +
                "Again, you note this as strange.");
            Thread.Sleep(500);

            Console.WriteLine("You choose to ignore this.");
            Thread.Sleep(500);

            Console.WriteLine("After talking for a while, he leaves you to rest. Again, he locks the door.\n");
            Console.WriteLine("You find it hard to sleep though, so you go to the window.\n");
            Thread.Sleep(300);

            Console.WriteLine("Suddenly, something catches your eye...");
            Thread.Sleep(500);

            Console.WriteLine("It appears to be Dracula, covered in blood, scaling the walls of the castle!\n" +
                "He enters the window below yours.");
            Thread.Sleep(500);

            Console.WriteLine("You have the following choices:\n" +
                "1) Investigate the room Dracula entered by scaling the wall\n" +
                "2) Try picking the lock on your door");

            var choice = IsValidChoice();

            if (choice == 1) { ScaleWall(); } else { PickLock(); }
        }
    }
}
