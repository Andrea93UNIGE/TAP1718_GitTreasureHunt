using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TAP1718_GitTreasureHunt
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            int meme_index = rand.Next(5);
            var meme = @"meme" + (meme_index + 1).ToString() + ".jpg";
            System.Diagnostics.Process.Start(meme);
        }
    }
}
