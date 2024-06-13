using System;
//using System.Linq;
//using System.Collections.Generic;
//using CSharpShellCore;

namespace PeopleRegister;

public static class Program 
{   
	public static class Menu
	{
		
		public static bool add(ref Person[] People, ref int numPerson)
		{
			Person p = new Person();
			string name;
			double phoneNumber;
			Console.WriteLine("\nEnter the person's name: ");
			name = Console.ReadLine();
			Console.WriteLine("Enter the person's phone number: ");
			phoneNumber = Convert.ToInt64(Console.ReadLine());
			
			p.Name=name;
			p.PhoneNumber=phoneNumber;
			People[numPerson]=p;
			numPerson++;
			
			return true;
		}
		
		public static void list(ref Person[] People,ref int numPerson)
		{
			for(int i=0;i<numPerson;i++)
			{
				Console.WriteLine("\nPERSON "+(i+1));
				Console.WriteLine("Name: "+People[i].Name);
				Console.WriteLine("Phone Number: "+People[i].PhoneNumber);
			}
		}
		
		public static void enter()
		{
			Console.WriteLine("\nPress ENTER to continue ...");
			Console.ReadLine();
		}
		
		public static void display()
		{
			Console.Clear();
			Console.WriteLine("MAIN MENU");
			Console.WriteLine("1.- Add person");
			Console.WriteLine("2.- List people");
			Console.Write("\nChoose an option: ");
		}
		
		public static void run(ref Person[] People,ref int numPerson)
		{
			int option = 1;
			while(option != 0)
			{
				display();
				option = Convert.ToInt32(Console.ReadLine());
				switch(option)
				{
					case 0:
						break;
					case 1:
					    add(ref People, ref numPerson);
						break;
					case 2:
					    list(ref People, ref numPerson);
						break;
					default:
						Console.WriteLine("\n\nThis option is not in the menu...");
						break;
				}
				enter();
				//Console.WriteLine(""+option);
			}
		}
	}    
	
	public class Person
	{
		private string name;
		private double phoneNumber;
			
		public string Name
		{
			get{return name;}
			set{name = value;}
		}
		
		public double PhoneNumber
		{get; set;}
		/*
		public int Age
		{
			get{return age;}
			set{age = value;}
		}
		/*	
		public void set_age()
			{
				this.age = age;
			}
			
		public string get_name()
			{
				return name;
			}
			
		public int get_age()
			{
				return age;
			}
			
		*/
	}
	
    public static void Main()
    {
		Person[] People = new Person[100];
		int numPerson = 0;
		
        Menu.run(ref People,ref numPerson);	
    }
}
