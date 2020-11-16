using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;
using YGO_Designer.Classes.Carte;

namespace YGO_Designer
{
    public static class ORMPiege
    {
        public static bool AjouterPiege(Piege pi)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();

            cmd.CommandText = "" +
                "INSERT INTO carte(NO_CARTE , CODE_ATTR_CARTE , NOM, DESCRIPTION, TYPE_MO, ATTR_MO, NIVEAU_MO, ATK, DEF, TYPES_MONSTE_CARTE, TYPE_MA, TYPE_PI) " +
                "VALUES (@noC, @cdAttrC, @nomC, @descriptC, NULL, NULL, NULL, NULL, NULL, NULL, NULL, @typePiege)";

            cmd.Parameters.Add("@noC", MySqlDbType.Int32).Value = pi.GetNo();
            cmd.Parameters.Add("@cdAttrC", MySqlDbType.VarChar).Value = pi.GetAttr().GetCdAttrCarte();
            cmd.Parameters.Add("@nomC", MySqlDbType.VarChar).Value = pi.GetNom();
            cmd.Parameters.Add("@descriptC", MySqlDbType.VarChar).Value = pi.GetDescription();

            cmd.Parameters.Add("@typePiege", MySqlDbType.VarChar).Value = pi.GetNomTypePi();
            if (cmd.ExecuteNonQuery() == 1)
                return ORMCarte.AjouterEffetsCarte(pi);
            return false;
        }
    }
}
