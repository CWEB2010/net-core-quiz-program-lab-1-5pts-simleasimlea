using System;

namespace lab_one
{
    class Program
    {
		//declarations
		String[] answerKey = new String[10] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
		String[] userChoices = new String[10];
		String userSelection = "";
		String[] questions = new String[10] {	"Who is too busy to do C# research?",
												"Who is a superb instructor?",
												"Who is teaching too many classes?",
												"Who is learning C#, plus how to teach from Chris?",
												"Who loves football?",
												"Who loves physical books over digital?",
												"Who was born in 1985?",
												"Who graduated from high school in 1985?",
												"Who is trying to quickly fill up 10 questions?",
												"Who is glad there are only 10 questions?" };

		static void Main(string[] args)
        {
            Console.WriteLine("Hello Chris");
        }
    }
}
