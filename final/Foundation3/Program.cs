using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------EVENT 1-----------------------------------");
        Address event1A = new Address("Los Geranios", "San Juan de Lurigancho", "Lima", "Peru", 663, 15419);
        Lecture event1 = new Lecture("Lecture","The benefits of the doubt","Learn about some benefits of the doubt and apply it to your life", "July 12th", "4:00 PM", event1A, "Sir Angello", 1548);
        Console.WriteLine("Standar Details:");
        Console.WriteLine(event1.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(event1.StandarDetails());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine();
        
        Console.WriteLine("------------------------------EVENT 2-----------------------------------");
        Address event2A = new Address("Oak","Davis City", "MO","USA",145,50065);
        Reception event2 = new Reception("Reception","Chichi and Julia's Wedding","Amazing wedding of my friends","October 25th 2025","5:00 PM",event2A,"Askyourquestion@wedding.com");
        Console.WriteLine("Standar Details:");
        Console.WriteLine(event2.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(event2.StandarDetails());
        Console.WriteLine(event2.GetEmail());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine();


        Console.WriteLine("------------------------------EVENT 3-----------------------------------");
        Address event3A = new Address("Hurry","Roanoke","VA","USA",4417,24011);
        OutdoorGathering event3 = new OutdoorGathering("outdoorGathering","Party Rock in Park", "Rock with your friend in the park", "April 1st 2024", "8:00AM",event3A,"That day is a Sunny and beuatiful one");
        Console.WriteLine("Standar Details:");
        Console.WriteLine(event3.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(event3.StandarDetails());
        Console.WriteLine(event3.GetWeather());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine();


    }
}