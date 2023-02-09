using System;

class Program
{
    static void Main(string[] args)
    {
        // Video number 1
        Video video1 = new Video();
        video1._author = "Ricardo Mostacero";
        video1._length = 300;
        video1._title = "The Most Amazing Places in the World";

        Comment video1C1= new Comment();
        video1C1._name = "Pepe Lucho";
        video1C1._commment = "I learned amazing places to go on vacation, thank you";
        video1.comments.Add(video1C1);

        Comment video1C2 = new Comment();
        video1C2._name = "Pepe Grillo";
        video1C2._commment = "It was nice";
        video1.comments.Add(video1C2);

        Comment video1C3 = new Comment();
        video1C3._name = "Pepe Maximus";
        video1C3._commment = "I don't like that video. It was boring";
        video1.comments.Add(video1C3);

        // Video Number 2
        Video video2 = new Video();
        video2._author = "Alexandra Fernandez";
        video2._length = 400;
        video2._title = "The Most Amazing babies in the World";

        Comment video2C1= new Comment();
        video2C1._name = "Juan Luis Guerra";
        video2C1._commment = "It was a very cute video";
        video2.comments.Add(video2C1);

        Comment video2C2 = new Comment();
        video2C2._name = "Donald Trump";
        video2C2._commment = "I think babies can improve their incomes in different ways";
        video2.comments.Add(video2C2);

        Comment video2C3 = new Comment();
        video2C3._name = "Mia Khalifa";
        video2C3._commment = "Very cute babies";
        video2.comments.Add(video2C3);


        // Video number 3
        Video video3 = new Video();
        video3._author = "Angello Ruiz";
        video3._length = 400;
        video3._title = "The Most Amazing Cats in the World";

        Comment video3C1= new Comment();
        video3C1._name = "Adam Sandler";
        video3C1._commment = "HAHAHAHAHAHAHA";
        video3.comments.Add(video3C1);

        Comment video3C2 = new Comment();
        video3C2._name = "Sofia Vergara";
        video3C2._commment = "I wanna eat baby cheeses";
        video3.comments.Add(video3C2);

        Comment video3C3 = new Comment();
        video3C3._name = "Jennifer Aniston";
        video3C3._commment = "I will share that video with my friends";
        video3.comments.Add(video3C3);

        // Get information
        List<Video> videos = new List<Video>()
        {
            video1, video2, video3
        };
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            int videoNumberComments = video.NumberComments();
            Console.Write($"{videoNumberComments} ");
            video.StoreComments();
            Console.WriteLine();
        }
        

    }
}