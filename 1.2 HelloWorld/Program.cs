﻿namespace HelloWorld


{

	class MainClass
	{

		public static void Main(string[] args)
		{

			Message myMessage;
			myMessage = new Message("Hello World - from Message Object");
			myMessage.Print();




			Message[] allmesssage = new Message[5];
			string name;


			allmesssage[0] = new Message("Welcome back!");
			allmesssage[1] = new Message("What a lovely name");
			allmesssage[2] = new Message("Great name");
			allmesssage[3] = new Message("Oh hi!");
			allmesssage[4] = new Message("That is a silly name");

			Console.Write("Enter a name: ");
			
			name = Console.ReadLine().ToLower();
			
			if (name == "mark")
			{

				allmesssage[0].Print();

			}
			else if (name == "fred")
			{

				allmesssage[1].Print();

			}
			else if (name == "wilma")
			{
				allmesssage[2].Print();
			}
			else if (name == "alice")
			{
				allmesssage[3].Print();
			}
			else
			{
				allmesssage[4].Print();
			}



			Console.ReadLine();

		}

	}

}




