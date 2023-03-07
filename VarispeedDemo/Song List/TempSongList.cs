using Newtonsoft.Json;

namespace VarispeedDemo.Song_List
{
    public class TempSongList
    {
        public static string path = string.Empty;
        public static List<DisplayModel> cabiste = new List<DisplayModel>();
        public static void SongSet()
        {
            var no_dub = cabiste.Distinct().ToList();
            var dataJson = JsonConvert.SerializeObject(no_dub);
            try
            {
                System.IO.File.WriteAllText(path, dataJson);
            } catch
            {
                System.IO.File.WriteAllText(@"testing.json", dataJson);
            }
        }
        public static void SongUnset(string songFileToRemove)
        {
            // hey we studied this in algorithm session how useful :)
            int i = 0;
            while (cabiste.Count > 0 && i < cabiste.Count)
            {
                if (cabiste[i].Name == songFileToRemove) {
                    cabiste.RemoveAt(i);
                    break;
                } else { i++; }
            }
            SongSet();
        }
        public static void SongReset() { 
            cabiste.Clear(); 
            SongSet();
        }
        public static List<DisplayModel> GetSong()
        {
            try
            {
                string data;
                try { 
                    data = System.IO.File.ReadAllText(path);
                } catch
                {
                    data = System.IO.File.ReadAllText(@"testing.json");
                }
                var dataJson2 = JsonConvert.DeserializeObject<List<DisplayModel>>(data);
                return dataJson2;
            } catch 
            {
                return new List<DisplayModel>();
            }
        }
    }
    public class DisplayModel
    {
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
