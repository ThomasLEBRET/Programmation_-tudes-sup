using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes;

namespace YGO_Designer
{
    public static class ORMMonstre
    {
        public static bool AjouterMonstre(Monstre m)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();

            cmd.CommandText = "" +
                "INSERT INTO carte(NO_CARTE , CODE_ATTR_CARTE , NOM, DESCRIPTION, TYPE_MO, ATTR_MO, NIVEAU_MO, ATK, DEF, TYPE_MA, TYPE_PI) " +
                "VALUES (@noC, @cdAttrC, @nomC, @descriptC, @typeMo, @attrMo, @nivMo, @atk, @def, NULL, NULL)";

            cmd.Parameters.Add("@noC", MySqlDbType.Int32).Value = m.GetNo();
            cmd.Parameters.Add("@cdAttrC", MySqlDbType.VarChar).Value = m.GetAttr().GetCdAttrCarte();
            cmd.Parameters.Add("@nomC", MySqlDbType.VarChar).Value = m.GetNom();
            cmd.Parameters.Add("@descriptC", MySqlDbType.VarChar).Value = m.GetDescription();

            cmd.Parameters.Add("@typeMo", MySqlDbType.VarChar).Value = m.GetTypeMonstre();
            cmd.Parameters.Add("@attrMo", MySqlDbType.VarChar).Value = m.GetAttrMonstre();
            cmd.Parameters.Add("@nivMo", MySqlDbType.Int32).Value = m.GetNivMonstre();
            cmd.Parameters.Add("@atk", MySqlDbType.Int32).Value = m.GetAtk();
            cmd.Parameters.Add("@def", MySqlDbType.Int32).Value = m.GetDef();

            if (cmd.ExecuteNonQuery() == 1)
                return AjouterEffetsCarte(m);
            return false;
        }

        private static bool AjouterEffetsCarte(Monstre m)
        {
            if (m != null && ORMCarte.ExistCard(m))
            {
                MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();
                cmd.CommandText = "INSERT INTO effet_carte(CODE_EFFET, NO_CARTE) VALUES(@cdEffet, @noCarte)";
                bool estTransactionReussi = true;
                cmd.Parameters.Add("@noCarte", MySqlDbType.Int32).Value = m.GetNo();
                MySqlParameter cdEffet = new MySqlParameter("@cdEffet", MySqlDbType.VarChar);
                cmd.Parameters.Add(cdEffet);
                if (estTransactionReussi)
                {
                    foreach (Effet e in m.GetListEffets())
                    {
                        cdEffet.Value = e.GetCodeEffet();
                        estTransactionReussi = cmd.ExecuteNonQuery() == 1;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
