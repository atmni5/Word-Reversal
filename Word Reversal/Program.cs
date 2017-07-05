using System;

namespace Word_Reversal
{
	class Program
	{
		public static void Main(string[] args)
		{
		    Program program = new Program();
			program.Reverse();
		}
		
		private void Reverse(){
			
			string input = Console.ReadLine();
			string[] words = input.Split(' ');
			string wordsRev = "";
			string wordRev = "";
			
			//iterate through every word in the sentence
			foreach(string word in words){
				
				wordRev = "";
				
				//iterate through each character for each word
				foreach(char c in word){
					wordRev = wordRev.Insert(0,  c + "");
				}
				
				wordsRev += wordRev + " ";
				
			}
			Console.WriteLine(wordsRev);
			Console.ReadKey();
			
		}
	}
}