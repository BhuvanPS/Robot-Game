using System;
using SplashKitSDK;

namespace _2_3
{
    public class Program
    {
        public static void Main()
        {
            Window gameWindow = new Window("Robot Dodge", 800, 600);
            Player player = new Player(gameWindow);

            while (!player.Quit && !gameWindow.CloseRequested)
            {
                SplashKit.ProcessEvents();
                gameWindow.Clear(Color.White);

                player.HandleInput();
                player.StayOnWindow(gameWindow);
                player.Draw();

                gameWindow.Refresh(60);
            }
        }
    }

}
