using System;

namespace lab_one

{
	class Program
	{
		static void Main(string[] args)
		{
			//declarations
			String[] answerKey = new String[] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
			String[] userChoices = new String[10];
			String userSelection = "";
			String[] questions = new String[] { "Who is too busy to do C# research?",
												"Who is a superb instructor?",
												"Who is teaching too many classes?",
												"Who is learning C#, plus how to teach from Chris?",
												"Who loves football?",
												"Who loves physical books over digital?",
												"Who was born in 1985?",
												"Who graduated from high school in 1985?",
												"Who is trying to quickly fill up 10 questions?",
												"Who is glad there are only 10 questions?" };
			//two-dimensional array
			String[,] optionChoices = new String[,]  {
														{"A) Chris", "B) LeAnn", "C) John", "D) Joe"},
														{"A) Popeye", "B) Chris", "C) Mickey", "D) Goofy"},
														{"A) Barney", "B) Fred", "C) Chris", "Wilma"},
														{"A) LeAnn", "B) Prince", "C) Madonna", "D) Micheal"},
														{"A) Grandma", "B) Grandpa", "Auntie Em", "D) Chris"},
														{"A) Chris", "B) Biden", "C) Obama", "D) Warren"},
														{"A) Chris", "B) LeAnn", "C) Joe", "D) John"},
														{"A) Joe", "B) John", "C) LeAnn", "D) Chris"},
														{"A) Louey", "B) Dewey", "C) Hughey", "D) LeAnn"},
														{"A) LeAnn", "B) Popeye", "C) Mickey", "D) Goofy"},
												 };

			String primingValue; //priming value
			int x = 0;
			int y = 0;
			int totalCorrect = 0;
			int totalIncorrect = 0;

			Console.WriteLine("Welcome to this quiz. You know the drill. Answer 9 out of 10 questions to pass.");
			Console.WriteLine("Press any key to get started. Enter 2 to exit.");

			primingValue = Console.ReadLine();

			while (primingValue != "2")
			{

				//This for loop controls the output of questions.
				for (x = 0; x < questions.Length; x++)
				{
					//Console.WriteLine(questions.Length); //test
					Console.WriteLine(questions[x]);

					//This inner loop outputs options for the question.
					for (y = 0; y < optionChoices.GetLength(1); y++) //the last problem line of code
																	 //for (y = 0; y < 4; y++) //temporarily hard coding
					{
						//Console.WriteLine(y);//test
						//Console.WriteLine(optionChoices.GetLength(1)); //test
						Console.WriteLine(optionChoices[x, y]);

					}
					Console.WriteLine("Please enter your selection of A, B, C or D.");
					userSelection = Console.ReadLine();

					//decision making logic to make sure they got it right.
					//make amends for case sensitive input.

					if (userSelection.ToUpper() == answerKey[x])

					{
						//Console.WriteLine(userSelection.ToUpper()); //test
						//Console.WriteLine(answerKey[x]); //test

						totalCorrect++;
						//Console.WriteLine(totalCorrect); //test
						Console.WriteLine("You are correct.");
					}
					else
					{
						totalIncorrect++;
						//Console.WriteLine(totalIncorrect); //test
						Console.WriteLine("You are incorrect.");
					}
					//adding user input to userChoices array
					userChoices[x] = userSelection;
				}
					Console.WriteLine("The quiz has concluded. Here's how you did:");
					Console.WriteLine("Total correct." + totalCorrect);
					Console.WriteLine("Total incorrect." + totalIncorrect);

						//decision logic to determine if passing.
						if (totalCorrect >= 9)
						{
							Console.WriteLine("You passed!");
						}
						else
						{
							Console.WriteLine("Sorry, you failed.");
							Console.WriteLine("To retake the quiz, press any key. To quit, enter 2.");
						}


						primingValue = Console.ReadLine();
						if (primingValue == "2")
						{
							Environment.Exit(0); //sentinal value 
						}
						else
						{
							Console.Clear();
							totalCorrect = 0;
							totalIncorrect = 0;

				}
			}
				}
			}
		}


