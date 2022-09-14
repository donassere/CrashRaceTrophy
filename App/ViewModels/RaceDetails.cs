using App.Models;

namespace App.ViewModels
{
    public class RaceDetails
    {
        public Race ViewRace { get; }
        public string HeaderTitle { get; }

        public RaceDetails(Race race, string title)
        {
            ViewRace = race;
            HeaderTitle = title;
        }
    }
}