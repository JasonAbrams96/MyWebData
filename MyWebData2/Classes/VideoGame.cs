using System;
namespace MyWebData2.Classes
{
    public class VideoGame
    {
        public String Title {get; set;}
        public int Rating { get; set; }

        public enum System { NES, SNES, N64, GAMECUBE, WII, WII_U, SWITCH, PS1, PS2, PS3, PS4, PS5, XBOX, XBOX360, XBOX1, XBOX_X, NEED_TO_CHOOSE}
        public System MySystem = System.NEED_TO_CHOOSE;

        public VideoGame()
        {
            
        }

    }
}
