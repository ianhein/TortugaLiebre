﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TortugaLiebre
{
    public abstract class Runner // Abstracta porque no quiero que la clase Runner sea instanciada por un objeto
    {
        private static Random _rand = new Random(); //Estática porque podemos usar una instancia para cada clase Runner
        public int OrigPosition { get; set; }
        public string RunnerSymbol { get; set; }
        public int CurrentPosition { get; set; }
        public int Lane { get; set; }
        public string Name { get; set; }
        public string MoveDescription { get; set; }

        public static List<Runner> AllRunners = new List<Runner>();

        public int GetMoveType()
        {
            return _rand.Next(1, 101);
        }

        public void MakeMove (int spaces)
        {
            OrigPosition = CurrentPosition;

            if (CurrentPosition + spaces <0)
            {
                CurrentPosition = 0;
                    
            }
            else if (CurrentPosition + spaces > Track.TrackLength)
            {
                CurrentPosition = Track.TrackLength;
            }
            else
            {
                CurrentPosition += spaces;
            }
        }

        public bool IsWinner(Runner runner)
        {
            if (runner.CurrentPosition == Track.TrackLength)
                return true;

            return false;
        }

        public abstract void CalculateMove();
        
    }
}
