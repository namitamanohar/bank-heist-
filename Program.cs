using System;
using System.Collections.Generic;

namespace bankHeist {
    class Program {
        static void Main (string[] args) {
            // dictionary for each team member 

            List<Dictionary<string, string>> AllTeamInformation = new List<Dictionary<string, string>> ();

            Dictionary<string, int> bankDifficultyLevel = new Dictionary<string, int> ();
            bankDifficultyLevel.Add ("difficulty", 100);

            Console.WriteLine ("Plan your heist");
            while (true) {

                Console.WriteLine ("Enter a team member's name:");
                Dictionary<string, string> teamMemberInfo = new Dictionary<string, string> ();
                string memberName = Console.ReadLine ();
                teamMemberInfo.Add ("Member Name", memberName);

                if (memberName != "") {
                    Console.WriteLine ("Enter a team member's skill level:");
                    teamMemberInfo.Add ("Skill Level", Console.ReadLine ());

                    Console.WriteLine ("Enter a team member's courage factor:");
                    teamMemberInfo.Add ("Courage Level", Console.ReadLine ());

                    AllTeamInformation.Add (teamMemberInfo);

                } else {
                    break;
                }
            }
            foreach (Dictionary<string, string> teamMember in AllTeamInformation)
                foreach (KeyValuePair<string, string> item in teamMember) {
                    // Console.WriteLine ($"{item.Key}: {item.Value}");

                }
            Console.WriteLine ($"You  have {AllTeamInformation.Count} on your team");
        }
    }
}