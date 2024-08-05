using SplashKitSDK;

public class Player
{
    private Bitmap _PlayerBitmap;
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Width => _PlayerBitmap.Width;
    public int Height => _PlayerBitmap.Height;
    public bool Quit { get; private set; } = false;

    private const int SPEED = 5;
    private const int GAP = 10;

    public Player(Window gameWindow)
    {
        _PlayerBitmap = new Bitmap("Player", "Player.png");
        X = (gameWindow.Width - Width) / 2;
        Y = (gameWindow.Height - Height) / 2;
    }

    public void Draw()
    {
        _PlayerBitmap.Draw(X, Y);
    }

    public void HandleInput()
    {
        if (SplashKit.KeyDown(KeyCode.LeftKey)) X -= SPEED;
        if (SplashKit.KeyDown(KeyCode.RightKey)) X += SPEED;
        if (SplashKit.KeyDown(KeyCode.UpKey)) Y -= SPEED;
        if (SplashKit.KeyDown(KeyCode.DownKey)) Y += SPEED;

        if (SplashKit.KeyTyped(KeyCode.EscapeKey)) Quit = true;
    }

    public void StayOnWindow(Window gameWindow)
    {
        if (X < GAP) X = GAP;
        if (X > gameWindow.Width - Width - GAP) X = gameWindow.Width - Width - GAP;
        if (Y < GAP) Y = GAP;
        if (Y > gameWindow.Height - Height - GAP) Y = gameWindow.Height - Height - GAP;
    }
}
