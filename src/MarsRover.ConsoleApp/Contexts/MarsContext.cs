using System.Collections.Generic;

namespace MarsRover.ConsoleApp
{
    public class MarsContext
    {
        private static MarsContext instance = null;
        private static readonly object padlock = new object();

        private MarsContext()
        {
            PlateauList = new List<Plateau>();
        }

        public List<Plateau> PlateauList { get; set; }

        public Plateau ActivePlateau { get; set; }

        public void AddPlatoue(int x, int y)
        {
            var size = new PlateauSize(x, y);
            var plateau = new Plateau(size);

            this.PlateauList.Add(plateau);
            this.ActivePlateau = plateau;
        }

        public static MarsContext Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MarsContext();
                    }
                    return instance;
                }
            }
        }
    }
}
