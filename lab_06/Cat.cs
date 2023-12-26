using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace lab_06
{
    class Cat : Animal, SoundProdusingAnimal
    {
        public string color;
        public void makeSound()
        {
            Name = "Cat"; 
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = "D:\\UN\\ООП\\OOP\\lab_06\\cat.mp3";
            myplayer.controls.play();

        }
    }
}
