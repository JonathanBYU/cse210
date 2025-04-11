using System;

class Program
{
    static void Main(string[] args)
    {
        Comment[] comments1 = [new Comment("Joe", "This is a good video"), new Comment("Henry", "This is not good"), new Comment("Billy", "This video is awesome")];
        Comment[] comments2 = [new Comment("Lane", "This is terrible"), new Comment("Gavin", "Best video ever"), new Comment("Caden", "I liked this video"), new Comment("Alana", "It was alright")];
        Comment[] comments3 = [new Comment("Jonathan", "This was an exceptional video"), new Comment("Caleb", "This was good"), new Comment("Jordan", "It was decent")];
        Comment[] comments4 = [new Comment("Amara", "It wasn't too bad"), new Comment("Jaxon", "This was the best movie I've ever seen"), new Comment("Justin", "It was not too bad"), new Comment("Alivia", "I didn't hate it")];
        
        Video[] videos = [new Video("video1", "author1", 100, comments1), new Video("video2", "author2", 50, comments2), new Video("video3", "author3", 150, comments3), new Video("video4", "author4", 200, comments4)];
        
        foreach (Video video in videos) {
            Console.WriteLine(video.DisplayVideo());
        }
    }
}