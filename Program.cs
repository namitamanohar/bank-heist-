using System;

namespace bankHeist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan your heist");
            Console.WriteLine ("Enter a team member's name:");
            string memberName = Console.ReadLine ();

            Console.WriteLine ("Enter a team member's skill level:");
            string skillLevel = Console.ReadLine ();

            Console.WriteLine ("Enter a team member's courage factor:");
            string courageFactor = Console.ReadLine ();

            Console.WriteLine ($"Team member name : {memberName} Skill Level {skillLevel} Courage level: {courageFactor} ");
        }
    }
}