using System;
using System.Collections.Generic;

namespace bankHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      // dictionary for each team member 

      List<Dictionary<string, string>> AllTeamInformation = new List<Dictionary<string, string>>();


      int totalSkillLevel = 0;

      int successCount = 0;
      int failCount = 0;

      Console.WriteLine("Enter your bank difficulty level");
      int bankDifficultyLevel = int.Parse(Console.ReadLine());

      Console.WriteLine("Plan your heist");
      while (true)
      {

        Dictionary<string, string> teamMemberInfo = new Dictionary<string, string>();

        Console.WriteLine("Enter a team member's name:");
        string memberName = Console.ReadLine();
        teamMemberInfo.Add("Member Name", memberName);

        if (memberName != "")
        {
          Console.WriteLine("Enter a team member's skill level:");
          teamMemberInfo.Add("Skill Level", Console.ReadLine());

          Console.WriteLine("Enter a team member's courage factor:");
          teamMemberInfo.Add("Courage Level", Console.ReadLine());

          AllTeamInformation.Add(teamMemberInfo);

        }
        else
        {
          break;
        }
      }

      Console.WriteLine("Enter the number of trial runs");
      int trialRuns = int.Parse(Console.ReadLine());


      foreach (Dictionary<string, string> teamMember in AllTeamInformation)
        foreach (KeyValuePair<string, string> item in teamMember)
        {
          // Console.WriteLine ($"{item.Key}: {item.Value}");

          if (item.Key == "Skill Level")
          {
            totalSkillLevel += (int.Parse(item.Value));
          }

        }

      for (int i = 0; i < trialRuns; i++)
      {

        Random rand = new Random();
        int luckValue = rand.Next(1, 11);

        int newBankDifficultyLevel = luckValue + bankDifficultyLevel;


        if (totalSkillLevel >= newBankDifficultyLevel)
        {
          successCount++;
          Console.WriteLine("You are going to succeed!");
          Console.WriteLine($"The team's combined skill level is {totalSkillLevel}");
          Console.WriteLine($"You  have {AllTeamInformation.Count} on your team");
          Console.WriteLine($"The bank's diffulty level is: {newBankDifficultyLevel}");
        }
        else
        {
          failCount++;
          Console.WriteLine("Your mission is GOING to FAIL!");
          Console.WriteLine($"The team's combined skill level is {totalSkillLevel}");
          Console.WriteLine($"You  have {AllTeamInformation.Count} on your team");
          Console.WriteLine($"The bank's diffulty level is: {newBankDifficultyLevel}");

        }
      }

      Console.WriteLine($"Number of succesful runs {successCount}");
      Console.WriteLine($"Number of failed runs {failCount}");



    }
  }
}