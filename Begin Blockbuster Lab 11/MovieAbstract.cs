using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Begin_Blockbuster_Lab_11
{
    abstract class MovieAbstract
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set;  }

        public MovieAbstract(string title, string category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
            Scenes = scenes;
        }

        //up to the child classes to fill in 
        public abstract void Play();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime}");
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {
                Console.WriteLine($"{i}: {scene}");
                i++;
            }
        }
    }
}
