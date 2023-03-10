using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSound.Models
{
    enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
    internal class Sound1
    {
        public string Name { get; set; }
        public string AudioFile { get; set; }   
        public string ImageFile { get; set; }
        public SoundCategory Category { get; set; } 
        public Sound1(string name,SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"/Assests/Audio/{category}/{name}.wav";
            ImageFile = $"/Assests/Images/{category}/{name}.png";

        }

    }
}
