using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // game setup
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine();
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
      Console.WriteLine();

      if (noiseChoice == "NO") {
        Console.WriteLine("You've watched too many horror movies huh.");
        Console.WriteLine("THE END");
      }
      else if (noiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. \nYou walk towards it. Do you open it or knock?");
      }
   
      Console.WriteLine();
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      doorChoice = doorChoice.ToUpper();
      Console.WriteLine();

      if (doorChoice == "KNOCK") {
        Console.WriteLine("A voice behind the door speaks. It says, 'Answer this riddle: ' \n'Poor people have it. Rich people need it. If you eat it you die. What is it?'");
        Console.WriteLine();
        Console.Write("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        riddleAnswer = riddleAnswer.ToUpper();

        if (riddleAnswer == "NOTHING") {
          Console.WriteLine();
          Console.WriteLine("The door opens and NOTHING is there. You turn off the lights, run outside and set the house on fire. Ain't no way you're living in a huanted house. Plus your house insurance covers arson. Blame it on your neighbors annoying kid. The guilt will fade away as you sip on mimosas in Cancun");
          Console.WriteLine("\nTHE END");
        }
        else {
          Console.WriteLine();
          Console.WriteLine("You answered incorrectly. The door doesn't open. Suddenly you awaken in your room, sweating profusely. Was it all a dream? I wouldn't take my chances, burn the place down, it's what the spirit would want you to do.");
          Console.WriteLine("\nTHE END");
        }
      } 
      //if you choose open
      else if (doorChoice == "OPEN") {
        Console.WriteLine("The door is locked! See if one of your three keys will open it");
        Console.WriteLine();
        Console.Write("Enter 1, 2, or 3: ");
        string keyChoice = Console.ReadLine();
        keyChoice = keyChoice.ToUpper();
        switch (keyChoice) {
          case "1":
            Console.WriteLine("\nYou chose the first key. The door opens and NOTHING is there. Strange...Wait you look more closely. No...it cant be. Is that international superstar Shia Lebeouf? Wrestling a knife from Shia LaBeouf...");
            Console.WriteLine("\nTHE END");
            break;
          case "2":
            Console.WriteLine("\nYou chose the second key. The door opens, you peer into the darkness. Is that...your ex. The one that got away. You walk closer in disbelief. 'Why did you leave?', you cry out. They raise their arm slowly pointing behind you as their quiet snicker explodes into maniacal laughter. You turn around, there's nothing there. You turn back to them. Suddenly they burst into flames. The laughter has turned into a horrid shriek that echoes through the room. Should've picked a different key.");
            Console.WriteLine("\nTHE END");
            break;
          case "3":
            Console.WriteLine("\nYou chose the third key. The door opens. You walk in without question. There's a joyful presence in the room. You hear a familiar bark. 'Sparky!' Your childhood dog jumps up at you. You hug him harder than you've ever hugged anything before. Moments pass and you know that its time for him to go. You wish so desperately for this moment to never end...Suddenly, you wake up, tears running down your face.");
            Console.WriteLine("\nTHE END");
            break;
          default:
            Console.WriteLine("\nYou've decided not to open the door. Some things are better left unanswered. You go back to your room and choose to live in blissful ignorance, that noise was probably a rat anyways, probably...");
            Console.WriteLine("\nTHE END");
            break;
        }

      }

    }
  }
}