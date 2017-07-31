using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagFinder.Models
{
    public class Flags : CollectionBase
    {
        public Flags()
        {
        }

        public void LoadFlags()
        {
            Add("Canada", true, false, false, false, false, false, false, true, false);
            Add("Mexico", true, true, true, true, true, false, true, true, false );
            Add("United States", true, false, false, false, true, false, false, true, false);
        }

        void Add(string name, bool red, bool orange, bool yellow, bool green, bool blue, bool purple, bool brown, bool white, bool black)
        {
            Flag flag = new Flag();
            flag.Name = name;
            flag.Red = red;
            flag.Orange = orange;
            flag.Yellow = yellow;
            flag.Green = green;
            flag.Blue = blue;
            flag.Purple = purple;
            flag.Brown = brown;
            flag.White = white;
            flag.Black = black;
            //flag.ImageLocation = "~/Content/Images/" + imgName + ".jpg";
            List.Add(flag);
        }

    }
}
