// See https://aka.ms/new-console-template for more information

using modul6_103022300050;

public class Program
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Arrayan");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Star Wars oleh Arrayan");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Evangelion 3.0 + 1.0 oleh Arrayan");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Harry Potter oleh Arrayan");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Minecraft the Movie oleh Arrayan");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Gundam Quuuuuuux oleh Arrayan");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Despicable Me 4 oleh Arrayan");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Kung Fu Panda 4 oleh Arrayan");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Drive oleh Arrayan");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Barbie oleh Arrayan");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Bladerunner 2099 oleh Arrayan");
        
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        user.PrintAllVideoPlaycount();
    }
}
