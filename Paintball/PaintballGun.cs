class PaintballGun
{
    public int MagazineSize { get; private set; } // auto-property

    // balls available
    private int balls;
    // balls loaded in magazine, commented beacuase we use auto-property
    // private int ballsLoaded;
    private bool isEmpty;
    public int BallsLoaded { get; private set; } // auto-property

    public int Balls  // Get and Set Accessors backing field
    {
        get
        {
            return balls;
        }

        set
        {
            if (value > 0) // value is keyword used by set accesor property
                balls = value;
            Reload();
        }
    }


    /* public int BallsLoaded // Get and Set Accessors backing field
        {
            get
            {
                return ballsLoaded;
            }
            set
            {
                ballsLoaded = value; // value is keyword used by set accesor property
            }
    }*/

    // Constructor
    public PaintballGun(int balls, int magazineSize, bool loaded)
    {
        this.balls = balls;
        MagazineSize = magazineSize;
        if (loaded)
        {
            Reload();
        }

    }

    public bool IsEmpty()
    {
        return BallsLoaded == 0;
    }

    public void Reload()
    {
        if (balls > MagazineSize)
        {
            BallsLoaded = MagazineSize;
        }
        else
        {
            BallsLoaded = balls;
        }
    }

    public bool Shoot()
    {
        if (BallsLoaded == 0)
        {
            return false;
        }
        BallsLoaded--;
        balls--;
        return true;
    }

}
