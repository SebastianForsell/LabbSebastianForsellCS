using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Lastbil
    {
        private int numberOfGears;
        private int numberOfWheels;
        private string cargoType;
        private int hornFrequency;
        private int hornSpeed;
        private string hornSound;
        private static int instanceCounter;

        public int HornSpeed
        {
            get { return hornSpeed; }
            set { hornSpeed = value; }
        }
        public int HornFrequency
        {
            get { return hornFrequency; }
            set { hornFrequency = value; }
        }
        public string CargoType
        {
            get { return cargoType; }
            set { cargoType = value; }
        }
        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set { numberOfWheels = value; }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set { numberOfGears = value; }
        }
        public string HornSound
        {
            get { return hornSound; }
            set { hornSound = value; }
        }
        public static int InstanceCounter
        {
            get { return instanceCounter; }
        }
        static Lastbil()
        {
            instanceCounter = 0;
        }
        public Lastbil()
        {
            NumberOfGears = 10;
            NumberOfWheels = 10;
            CargoType = "Goods";
            HornFrequency = 1000;
            HornSpeed = 500;
            HornSound = "meep meep";
            instanceCounter++;
    }
        public Lastbil(int numberOfGears, int numberOfWheels, string cargoType, int hornFrequency, int hornSpeed) : this()
        {
            NumberOfWheels = numberOfWheels;
            NumberOfGears = numberOfGears;
            CargoType = cargoType;
            HornFrequency = hornFrequency;
            HornSpeed = hornSpeed;
            HornSound = hornSound;
        }
        public override string ToString()
        {
            return $"Last bil antal hjul: {NumberOfWheels}, antal växlar: {NumberOfGears}, typ av last: {CargoType}";
        }
    }
}
