using System;
using System.Collections.Generic;
using System.Text;

namespace Begin_Blockbuster_Lab_11
{
    class DVD : MovieAbstract
    {
        public DVD(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("Using the index, please select a scene you'd like to watch");
            string input = Console.ReadLine();
            int pick = int.Parse(input);

            string scene = Scenes[pick];
            Console.WriteLine(scene);
        }
    }
}
