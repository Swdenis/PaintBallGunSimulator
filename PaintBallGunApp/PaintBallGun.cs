﻿using System;
namespace PaintBallGunApp
{
    class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }
        public int MagazineSize { get; private set; } = 16;
        private int balls = 0;
        public int BallsLoaded { get; private set; }


        public bool IsEmpty() { return BallsLoaded == 0; }

        public int Balls
        {
            get { return balls; }
            set { if (value > 0) balls = value;
                Reload();
            }
        }

        public void Reload() => BallsLoaded = balls > MagazineSize ? MagazineSize : balls;
        

        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }



        
    }
}
