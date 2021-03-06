﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Radio
    {
        private bool isOn;
        private static int instanceCounter;
        public static int InstanceCounter
        {
            get { return instanceCounter; }
        }
        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        private int volume;
        private double frequency;

        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    frequency = value;
                }
                else
                {
                    throw new Exception("Fel värde för frekvens!! (0 - 100)");
                }
            }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    volume = value;
                }
                else
                {
                    throw new Exception("Fel värde för volym!! ( 0 - 50)");
                }
            }
        }
        static Radio()
        {
            instanceCounter = 0;
        }
        public Radio()
        {
            IsOn = false;
            Volume = 15;
            Frequency = 93.50;
            instanceCounter++;
        }
        public Radio(int volume, double frequency) : this()
        {
            Volume = volume;
            Frequency = frequency;
        }
        public override string ToString() => $"Radio volym: {Volume}, frekvens: {Frequency}";

    }
}
