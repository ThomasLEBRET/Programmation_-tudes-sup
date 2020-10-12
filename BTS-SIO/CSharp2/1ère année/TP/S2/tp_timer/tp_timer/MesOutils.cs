using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace tp_timer
{
    class MesOutils
    {
        public static void DeserialiseListe(string monTheme)
        {
            FileStream f = new FileStream(monTheme + ".txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            List<MotIllustre> uneListeDeMotsIllustre = new List<MotIllustre>();
            ListeDeMotsIllustres.SetListeMotIllustre((List<MotIllustre>)bf.Deserialize(f));
            f.Close();
        }

        public static void SerialiseListe(string monTheme)
        {
            FileStream f = new FileStream(monTheme + ".txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, ListeDeMotsIllustres.GetListeDeMotIllustre());
            f.Close();
        }
    }
}
