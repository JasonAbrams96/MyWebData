using System;
using System.Collections;
using MyWebData2.Classes;

namespace MyWebData2.Items
{
    public class TempGames
    {
        public ArrayList MyList = new ArrayList();

        public TempGames()
        {
            VideoGame g1 = new VideoGame();
            g1.Title = "Super Mario Bros. 3";
            g1.Rating = 8;
            g1.MySystem = VideoGame.System.NES;

            VideoGame g2 = new VideoGame();
            g2.Title = "Pokemon Colosseum";
            g2.Rating = 9;
            g2.MySystem = VideoGame.System.GAMECUBE;

            VideoGame g3 = new VideoGame();
            g3.Title = "Grand Theft Auto 3";
            g3.Rating = 5;
            g3.MySystem = VideoGame.System.PS2;

            MyList.Add(g1);
            MyList.Add(g2);
            MyList.Add(g3);

        }
    }
}
