
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SpaceShooterTest
{
    [TestClass]
    public class SpaceShooterTest
    {
        private readonly int range = 400;
        private readonly int sizePlayer = Info.SIZE_PLAYER;
        private readonly int sizeShot = Info.SIZE_SHOT;
        private readonly int sizeEnemy = Info.SIZE_ENEMY;
        [TestMethod]
        /*
        * This test test the collision of the entity.
        */
        public void TestMethod2()
        {
            double distance;
            bool collision;
            double distanceRocketShot = sizePlayer / 2 + sizeShot / 2;
            double distanceRocketPlayer = sizePlayer / 2 + sizeEnemy / 2;
            Random rnd = new Random();
            int shotX;
            int shotY;
            using (var sw = new StringWriter())
            {
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    /**
                     * This is a collision; the Y is the same, but change the X, but not a lot, so the method see a collision.
                     */
                    distance = Info.Distance(shotX + rnd.Next((int)distanceRocketPlayer), shotY, shotX, shotY);
                    collision = distance < distanceRocketPlayer;
                    Assert.IsTrue(collision);
                }
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    /**
                     * This is a collision too, the X is the same but the Y varies.
                     */
                    distance = Info.Distance(shotX, shotY + rnd.Next((int)distanceRocketPlayer), shotX, shotY);
                    collision = distance < distanceRocketPlayer;
                    Assert.IsTrue(collision);
                }
                for (int i = 0; i < 100000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    /**
                     * This is NOT a collision, because the X various too much and the method can't see a collision happens.
                     * In fact i sum: shotX + (casual number) + distanceRocketPlayer.
                     */
                    distance = Info.Distance(shotX + distanceRocketPlayer + rnd.Next(range), shotY, shotX, shotY);
                    collision = distance < distanceRocketPlayer;
                    Assert.IsFalse(collision);
                }
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    /**
                     * This is NOT a collision. Now the Y is too much and the method can't see a collision.
                     */
                    distance = Info.Distance(shotX, shotY + distanceRocketPlayer + rnd.Next(range), shotX, shotY);
                    collision = distance < distanceRocketPlayer;
                    Assert.IsFalse(collision);
                }

                /**
                 * Now this test is the same as the previous test, but i use the distance between rocket and shot, and NOT rocket and player.
                 */
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    distance = Info.Distance(shotX + rnd.Next((int)distanceRocketShot), shotY, shotX, shotY);
                    collision = distance < distanceRocketShot;
                    Assert.IsTrue(collision);
                }
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    distance = Info.Distance(shotX, shotY + rnd.Next((int)distanceRocketShot), shotX, shotY);
                    collision = distance < distanceRocketShot;
                    Assert.IsTrue(collision);
                }
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    distance = Info.Distance(distanceRocketShot + shotX + rnd.Next(range), shotY, shotX, shotY);
                    collision = distance < distanceRocketShot;
                    Assert.IsFalse(collision);
                }
                for (int i = 0; i < 1000; i++)
                {
                    shotX = rnd.Next(range);
                    shotY = rnd.Next(range);

                    distance = Info.Distance(shotX, shotY + distanceRocketShot + rnd.Next(range), shotX, shotY);
                    collision = distance < distanceRocketShot;
                    Assert.IsFalse(collision);
                }

            }
        }
    }
}
