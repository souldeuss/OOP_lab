using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace lab_06
{
    internal class Dog : Animal ,SoundProdusingAnimal
    {
        public string breed;
        public void makeSound()
        {   Sound = "D:\\UN\\ООП\\OOP\\lab_06\\dog.mp3"
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = Sound;
            myplayer.controls.play();
        }
    }
}
