using System;

namespace ForwardBackward.Tools
{
    public class Dice
    {
        private static Dice _instance;
        private static readonly object Padlock = new object();
        
        public int Roll
        {
            get
            {
                Random rnd = new Random();

                return rnd.Next(1, 6);
            }
        }

        private Dice()
        {
            
        }

        public static Dice Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Dice();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}