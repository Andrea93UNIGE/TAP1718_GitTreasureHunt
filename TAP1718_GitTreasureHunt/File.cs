using System;
using System.Collections.Generic;

namespace TAP1718_GitTreasureHunt
{
    public class File
    {
        readonly int audience;
        readonly string place;

        public File(int audience, string place)
        {
            this.audience = audience;
            this.place = place;
        }

        public void DoSomething(){
            Console.WriteLine(this.ToString());
        }

        public override bool Equals(object obj)
        {
            var file = obj as File;
            return file != null &&
                   audience == file.audience &&
                   place == file.place;
        }

        public override int GetHashCode()
        {
            var hashCode = 825926359;
            hashCode = hashCode * -1521134295 + audience.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(place);
            return hashCode;
        }

        public override string ToString()
        {
            return audience.ToString() + " " + place;
        }
    }
}
