using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"The sky is blue.", "Paris is in Italy.", "Sharks live in the ocean", "Disney is the happiest place on Earth.", "Tomato is a fruit."};
      bool[] answers = {true, false, true, false, true};
      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length) {
        Console.WriteLine("Warning! Length of questions and answers does not match.");
      }
      int askingIndex = 0;
      foreach (string question in questions) {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("True or false?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        while (isBool == false) {
          Console.WriteLine("Please respond with 'true' or 'false'");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers) {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
        Console.WriteLine($"Input: {response} | Answer: {answer}");
        if (response == answer) {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of 5 correct!");
    }
  }
}
