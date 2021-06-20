using System;

namespace TortugaLiebre
{
    class Track
    {
        public const int TrackLength = 71;
        public const int NumOfRunners = 02;

        public string[,] Tracks { get; set; }

        public Track()
        {
            Tracks = new string[TrackLength + 1, NumOfRunners];
        }
        public void DisplayRaceTrack()
        {
            Console.WriteLine();
            for (var i = 0; i <= TrackLength; i++)
            {
                Console.Write(i +"    " + "  | ");
                for (var c = 0; c < NumOfRunners; c++)
                {
                    if (Tracks[i, c] == null)
                        Console.Write("  | ");
                    else
                        Console.Write(Tracks[i, c]+  " | ");
                }
                Console.WriteLine();
            }
               
        }

        public void RunnerPosition(Runner runner)
        {
            Tracks[runner.CurrentPosition, runner.Lane] = null;
            Tracks[runner.CurrentPosition, runner.Lane] = runner.RunnerSymbol;
        }
    }

}
