using System;

namespace Inheritance1
{
    public class Cartoon
    {
        protected string Title;
        protected string Creator;
        protected int YearOfRelease;
        protected bool IsAnimated;

        public Cartoon()
        {
            this.Title = "MotuPathulu";
            this.Creator = "Ravi";
            this.IsAnimated = true;
            this.YearOfRelease = 2024;
            
        }
        public Cartoon(Cartoon pokeman)
        {
            this.Title = pokeman.Title;
            this.Creator = pokeman.Creator;
            this.IsAnimated = pokeman.IsAnimated;
            this.YearOfRelease = pokeman.YearOfRelease;
           
        }

        
        void DisplayConstructorInfo(string constructorName) 
        {
            
            Console.WriteLine($"Title: {Title}, Creator: {Creator}, IsAnimated: {IsAnimated}, YearOfRelease: {YearOfRelease}");
        }

        public void GetCartoonData()
        {
            Console.WriteLine("Enter Cartoon Details:");
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Creator: ");
            Creator = Console.ReadLine();
            Console.Write("Is Animated (true/false): ");
            IsAnimated = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Year of Release: ");
            YearOfRelease = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayCartoonData()
        {
            Console.WriteLine("Cartoon Title: " + Title);
            Console.WriteLine("Cartoon Creator: " + Creator);
            Console.WriteLine("Cartoon Year of Release: " + YearOfRelease);
            Console.WriteLine("Is Animated: " + IsAnimated);
        }
    }


    public class AnimeCartoon : Cartoon
    {
        public bool IsAnime;

        
        public AnimeCartoon()
        {
            Title = "Dora";
            Creator = "Manisha";
            IsAnime = true;
            YearOfRelease = 2000;
            //Console.WriteLine("Title is" + Title);
            //Console.WriteLine("Creator is:"+ Creator);
            //Console.WriteLine("IsAnime is" + IsAnime);
            //Console.WriteLine("YearOfRelease is" + YearOfRelease);


        }

        public void GetAnimeCartoonData()
        {
            Console.WriteLine("Enter AnimeCartoon Details:");
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Creator: ");
            Creator = Console.ReadLine();
            Console.Write("Is Anime (true/false): ");
            IsAnime = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Year of Release: ");
            YearOfRelease = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAnimeCartoonData()
        {
            Console.WriteLine("AnimeCartoon Title: " + Title);
            Console.WriteLine("AnimeCartoon Creator: " + Creator);
            Console.WriteLine("AnimeCartoon Year of Release: " + YearOfRelease);
            Console.WriteLine("Is Anime: " + IsAnime);
        }
    }

    class ClsInheritance
    {
        static void Main()
        {
            
            AnimeCartoon a1 = new AnimeCartoon();
            a1.GetAnimeCartoonData();
            a1.DisplayAnimeCartoonData();
            //Cartoon c1=new Cartoon();
            //Cartoon c2 = new Cartoon(c1);
            
            a1.GetCartoonData();
            a1.DisplayCartoonData();

            
        }
    }
}



