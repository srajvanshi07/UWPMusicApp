using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UWPMusicApp.Model.Music;

namespace UWPMusicApp.Model
{
    public class MusicManager
    {
        private static List<Music> getMusics()
            // created getMusics method for local variable list
        {
            //List<Music> musics = new List<Music>();
            var musics = new List<Music>();
            musics.Add(new Music("Downfall", Music.MusicCategory.Classical));

            musics.Add(new Music("Lesser Faith", Music.MusicCategory.Classical));

            musics.Add(new Music("Phase2", Music.MusicCategory.Classical));

            musics.Add(new Music("Brain ID 1270", Music.MusicCategory.Country));

            musics.Add(new Music("Squirrel Fever", Music.MusicCategory.Country));

            musics.Add(new Music("The Meat Rack Jan 2016 LIVE", Music.MusicCategory.Country));

            musics.Add(new Music("inter1", Music.MusicCategory.International));

            musics.Add(new Music("inter2", Music.MusicCategory.International));

            musics.Add(new Music("inter3", Music.MusicCategory.International));

            musics.Add(new Music("Say Goodnight", Music.MusicCategory.Rock));

            musics.Add(new Music("Storybook", Music.MusicCategory.Rock));

            musics.Add(new Music("Up North Classic", Music.MusicCategory.Rock));

            return musics;



        }
        public static void GetAllMusics(ObservableCollection<Music> musics)
            //Add using System.Collections.ObjectModel; created method
        {
            //use method created for local list to get all music list
            var allMusics = getMusics();
            //clear the data of observable collection 
            musics.Clear();
            //LINQ used  (Lambda --> delegate--> Function pointer)
            allMusics.ForEach(s => musics.Add(s));
            // Connect music manager with UI

        }

        // Filter music by category for Pane
        public static void GetMusicByCategory(ObservableCollection<Music> musics, MusicCategory category)
        {
            var allMusic = getMusics();
            var filterMusic = allMusic.Where(s => s.Category == category).ToList();
            musics.Clear();
            filterMusic.ForEach(s => musics.Add(s));
        }
           
    }
}
