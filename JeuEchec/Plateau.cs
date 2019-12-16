using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JeuEchec
{
    class Plateau
    {
        private Dictionary<Case, Piece> map = new Dictionary<Case, Piece>();

        public Dictionary<Case, Piece> getMap()
        {
            return map;
        }

        public void Set(Case key, Piece value)
        {
            if (map.ContainsKey(key))
            {
                map[key] = value;
            }
            else
            {
                map.Add(key, value);
            }
        }

        public Piece Get(Case key)
        {
            Piece result = null;

            if (map.ContainsKey(key))
            {
                result = map[key];
            }

            return result;
        }

        public Plateau()
        {

            map = new Dictionary<Case, Piece>();
            map.Add(new Case("A8"), (Piece)new Tour("noir"));
            map.Add(new Case("B8"), (Piece)new Cavalier("noir"));
            map.Add(new Case("C8"), (Piece)new Fou("noir"));
            map.Add(new Case("D8"), (Piece)new Roi("noir"));
            map.Add(new Case("E8"), (Piece)new Reine("noir"));
            map.Add(new Case("F8"), (Piece)new Fou("noir"));
            map.Add(new Case("G8"), (Piece)new Cavalier("noir"));
            map.Add(new Case("H8"), (Piece)new Tour("noir"));
            map.Add(new Case("A7"), (Piece)new Pion("noir"));
            map.Add(new Case("B7"), (Piece)new Pion("noir"));
            map.Add(new Case("C7"), (Piece)new Pion("noir"));
            map.Add(new Case("D7"), (Piece)new Pion("noir"));
            map.Add(new Case("E7"), (Piece)new Pion("noir"));
            map.Add(new Case("F7"), (Piece)new Pion("noir"));
            map.Add(new Case("G7"), (Piece)new Pion("noir"));
            map.Add(new Case("H7"), (Piece)new Pion("noir"));
            for (int i = 6; i > 2; i--)
            {
                for (char j = 'A'; j < 'I'; j++)
                {
                    map.Add(new Case(j + (i.ToString())), null);
                }
            }
            map.Add(new Case("A2"), (Piece)new Pion("blanc"));
            map.Add(new Case("B2"), (Piece)new Pion("blanc"));
            map.Add(new Case("C2"), (Piece)new Pion("blanc"));
            map.Add(new Case("D2"), (Piece)new Pion("blanc"));
            map.Add(new Case("E2"), (Piece)new Pion("blanc"));
            map.Add(new Case("F2"), (Piece)new Pion("blanc"));
            map.Add(new Case("G2"), (Piece)new Pion("blanc"));
            map.Add(new Case("H2"), (Piece)new Pion("blanc"));
            map.Add(new Case("A1"), (Piece)new Tour("blanc"));
            map.Add(new Case("B1"), (Piece)new Cavalier("blanc"));
            map.Add(new Case("C1"), (Piece)new Fou("blanc"));
            map.Add(new Case("D1"), (Piece)new Reine("blanc"));
            map.Add(new Case("E1"), (Piece)new Roi("blanc"));
            map.Add(new Case("F1"), (Piece)new Fou("blanc"));
            map.Add(new Case("G1"), (Piece)new Cavalier("blanc"));
            map.Add(new Case("H1"), (Piece)new Tour("blanc"));
        }

        public Boolean checkDeplacement(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Type t = piece_loc.GetType();
            if (t.Equals(typeof(Roi)))
            {
                return (CheckDeplacement_Roi(loc, dest));
            }
            else if (t.Equals(typeof(Reine)))
            {
                return (CheckDeplacement_Reine(loc, dest));
            }
            else if (t.Equals(typeof(Fou)))
            {
                return (CheckDeplacement_Fou(loc, dest));
            }
            else if (t.Equals(typeof(Tour)))
            {
                return (CheckDeplacement_Tour(loc, dest));
            }
            else if (t.Equals(typeof(Cavalier)))
            {
                return (CheckDeplacement_Cavalier(loc, dest));
            }
            else if (t.Equals(typeof(Pion)))
            {
                return (CheckDeplacement_Pion(loc, dest));
            }
            else
            {
                return (false);
            }

        }



        public Boolean CheckDeplacement_Pion(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Boolean blanc_dest = false;
            Piece piece_dest = Get(dest);
            Boolean blanc = (piece_loc.Color.Equals("blanc")) ? true : false;
            if (piece_dest != null)
            {
                blanc_dest = (piece_dest.Color.Equals("blanc")) ? true : false;
            }
            int i = (blanc) ? 1 : -1;
            int[] coor_loc = getCoordonnees(loc);
            int[] coor_dest = getCoordonnees(dest);
            if (piece_dest == null)
            {
                if (coor_dest[1] == coor_loc[1] + i && coor_dest[0] == coor_loc[0])
                {
                    return true;
                }
                if (coor_dest[1] == coor_loc[1] + (i * 2) && coor_dest[0] == coor_loc[0] && coor_loc[1] == (i == 1 ? 2 : 7))
                {
                    return true;
                }
            }
            else
            {
                if (coor_dest[1] == coor_loc[1] + i && (coor_dest[0] == coor_loc[0] + i || coor_dest[0] == coor_loc[0] - i))
                {
                    if (blanc_dest != blanc)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public Boolean CheckDeplacement_Tour(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Boolean blanc_dest = false;
            Piece piece_dest = Get(dest);
            Boolean blanc = (piece_loc.Color.Equals("blanc")) ? true : false;
            if (piece_dest != null)
            {
                blanc_dest = (piece_dest.Color.Equals("blanc")) ? true : false;
                if (blanc_dest == blanc)
                {
                    return false;
                }
            }

            int[] coor_loc = getCoordonnees(loc);
            int[] coor_dest = getCoordonnees(dest);
            int i = 0;
            if (coor_loc[1] != coor_dest[1])
            {
                i = 1;
            }
            if (coor_loc[0] != coor_dest[0] && i == 1)
            {
                return false;
            }
            int plusgrand = coor_loc[i] < coor_dest[i] ? 1 : -1;
            while (coor_loc[i] != coor_dest[i])
            {
                int[] newcoor = new int[2];
                newcoor[i] = coor_loc[i] + plusgrand;
                int j = (i == 0) ? 1 : 0;
                newcoor[j] = coor_loc[j];
                Case newcase = GetCase(newcoor);
                if (newcase == null)
                {
                    return false;
                }
                Piece newpiece = Get(newcase);

                if (newcoor[i] == coor_dest[i])
                {
                    return true;
                }
                else
                {
                    if (newpiece != null)
                    {
                        return false;
                    }
                }
                coor_loc = newcoor;
            }
            return false;
        }

        public Boolean CheckDeplacement_Cavalier(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Boolean blanc_dest = false;
            Piece piece_dest = Get(dest);
            Boolean blanc = (piece_loc.Color.Equals("blanc")) ? true : false;
            if (piece_dest != null)
            {
                blanc_dest = (piece_dest.Color.Equals("blanc")) ? true : false;
            }
            int[] coor_loc = getCoordonnees(loc);
            int[] coor_dest = getCoordonnees(dest);
            if (piece_dest == null || blanc != blanc_dest)
            {
                int x = coor_loc[0] - coor_dest[0];
                x = (x < 0) ? -x : x;
                int y = coor_loc[1] - coor_dest[1];
                y = (y < 0) ? -y : y;

                if ((x == 2 && y == 1) || (x == 1 && y == 2))
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean CheckDeplacement_Fou(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Boolean blanc_dest = false;
            Piece piece_dest = Get(dest);
            Boolean blanc = (piece_loc.Color.Equals("blanc")) ? true : false;
            if (piece_dest != null)
            {
                blanc_dest = (piece_dest.Color.Equals("blanc")) ? true : false;
                if (blanc_dest == blanc)
                {
                    return false;
                }
            }
            int[] coor_loc = getCoordonnees(loc);
            int[] coor_dest = getCoordonnees(dest);
            int x = coor_loc[0] - coor_dest[0];
            int y = coor_loc[1] - coor_dest[1];
            if ((x < 0 ? -x : x) != (y < 0 ? -y : y))
            {
                return false;
            }

            while (coor_loc[0] != coor_dest[0] || coor_loc[1] != coor_dest[1])
            {
                int[] newcoor = new int[2];
                newcoor[0] = coor_loc[0] + (x < 0 ? 1 : -1);
                newcoor[1] = coor_loc[1] + (y < 0 ? 1 : -1);
                Case newcase = GetCase(newcoor);
                if (newcase == null)
                {
                    return false;
                }
                Piece newpiece = Get(newcase);

                if (newcoor[0] == coor_dest[0] && newcoor[1] == coor_dest[1])
                {
                    return true;
                }
                else
                {
                    if (newpiece != null)
                    {
                        return false;
                    }
                }
                coor_loc = newcoor;
            }
            return false;
        }
        public Boolean CheckDeplacement_Reine(Case loc, Case dest)
        {
            if (CheckDeplacement_Tour(loc, dest))
            {
                return true;
            }
            else if (CheckDeplacement_Fou(loc, dest))
            {
                return true;
            }
            return false;

        }
        public Boolean CheckDeplacement_Roi(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Boolean blanc_dest = false;
            Piece piece_dest = Get(dest);
            Boolean blanc = (piece_loc.Color.Equals("blanc")) ? true : false;
            if (piece_dest != null)
            {
                blanc_dest = (piece_dest.Color.Equals("blanc")) ? true : false;
            }
            int[] coor_loc = getCoordonnees(loc);
            int[] coor_dest = getCoordonnees(dest);
            if (piece_dest == null || blanc != blanc_dest)
            {
                if ((-1 <= coor_loc[1] - coor_dest[1] && 1 >= coor_loc[1] - coor_dest[1]) && (-1 <= coor_loc[0] - coor_dest[0] && 1 >= coor_loc[0] - coor_dest[0]))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Case> Deplacement_possible(Case loc, Joueur joueur)
        {
            List<Case> result = new List<Case>();
            if ((map[loc] == null) || (map[loc].Color != joueur.Color))
            {
                return result;
            }
            List<Case> ok = new List<Case>(map.Keys);
            foreach (Case c in ok)
            {
                if (checkDeplacement(loc, c))
                {
                    result.Add(c);
                }
            }
            return result;
        }

        public void Deplacement(Case depart, Case arrivee)
        {
            arrivee.Image = depart.Image;
            depart.Image = Properties.Resources.Vide;
            map[arrivee] = map[depart];
            map[depart] = null;
        }

        public int[] getCoordonnees(Case loc)
        {
            String name = loc.Name;
            int x = name.ElementAt(0) - 65;
            int y = name.ElementAt(1) - 48;
            int[] result = { x, y };
            return (result);
        }

        public Case GetCase(int[] xy)
        {
            int x = xy[0] + 65;
            char c = (char)x;
            String name = c + xy[1].ToString();
            foreach (KeyValuePair<Case, Piece> Objet in map)
            {
                if (Objet.Key.Name.Equals(name))
                {
                    return Objet.Key;
                }
            }
            return null;
        }

        public Case GetCaseWithName(String name)
        {
            foreach (KeyValuePair<Case, Piece> Objet in map)
            {
                if (Objet.Key.Name.Equals(name))
                {
                    return Objet.Key;
                }
            }
            return null;
        }

        public String[] ToArray()
        {
            String[] result = new String[64];
            int i = 0;
            foreach (KeyValuePair<Case, Piece> Objet in map)
            {
                if (Objet.Value == null)
                {
                    result[i++] = Objet.Key.Name + ":vide";
                }
                else
                {
                    result[i++] = Objet.Key.Name + ":" + Objet.Value.GetType().ToString() + ":" + Objet.Value.Color;
                }
            }
            return result;
        }

        public void LoadArray(String[] array)
        {
            String[] aux = new String[3];
            map.Clear();
            foreach (String str in array)
            {
                aux = str.Split(':');
                Case resultcase = new Case(aux[0]);
                if (aux.Length != 3)
                {
                    map.Add(resultcase, null);
                }
                else if (aux[1].Equals((typeof(Pion)).ToString()))
                {
                    Piece resultpiece = new Pion(aux[2]);
                    map.Add(resultcase, resultpiece);

                }
                else if (aux[1].Equals((typeof(Roi)).ToString()))
                {
                    Piece resultpiece = new Roi(aux[2]);
                    map.Add(resultcase, resultpiece);
                }
                else if (aux[1].Equals((typeof(Reine)).ToString()))
                {
                    Piece resultpiece = new Reine(aux[2]);
                    map.Add(resultcase, resultpiece);
                }
                else if (aux[1].Equals((typeof(Fou)).ToString()))
                {
                    Piece resultpiece = new Fou(aux[2]);
                    map.Add(resultcase, resultpiece);
                }
                else if (aux[1].Equals((typeof(Tour)).ToString()))
                {
                    Piece resultpiece = new Tour(aux[2]);
                    map.Add(resultcase, resultpiece);
                }
                else if (aux[1].Equals((typeof(Cavalier)).ToString()))
                {
                    Piece resultpiece = new Cavalier(aux[2]);
                    map.Add(resultcase, resultpiece);
                }
            }
        }

        public void Save()
        {
            using (var stream = File.Create("C:/Users/Stagiaire/Documents/Cours/Informatique/Cours C#/Echec/V1212/JeuEchec/JeuEchec/Xml/save.xml"))
            {
                var serializer = new XmlSerializer(typeof(string[]));
                serializer.Serialize(stream, ToArray());
            }
        }

        public void Load()
        {
            String[] result = new String[64];
            using (var stream = File.OpenRead("C:/Users/Stagiaire/Documents/Cours/Informatique/Cours C#/Echec/V1212/JeuEchec/JeuEchec/Xml/save.xml"))
            {
                var serializer = new XmlSerializer(typeof(string[]));
                result = (String[])serializer.Deserialize(stream);
            }
            LoadArray(result);
        }
    }
}
