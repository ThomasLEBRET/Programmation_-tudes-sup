using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using YGO_Designer.Classes.ORM;
using YGO_Designer.Classes.Carte;
using YGO_Designer.Classes;

namespace YGO_Designer
{
    /// <summary>
    /// Classe static simulant un ORM pour l'objet Monstre 
    /// </summary>
    public static class ORMMonstre
    {
        /// <summary>
        /// Ajoute une carte monstre dans la base de données
        /// </summary>
        /// <param name="m">Une carte Monstre</param>
        /// <returns>Un booléen : true si la carte a pu être ajoutée, false sinon</returns>
        public static bool Add(Monstre m)
        {
            MySqlCommand cmd = ORMDatabase.GetConn().CreateCommand();

            cmd.CommandText = "" +
                "INSERT INTO carte(NO_CARTE , CODE_ATTR_CARTE , NOM, DESCRIPTION, TYPE_MO, ATTR_MO, NIVEAU_MO, ATK, DEF, TYPES_MONSTE_CARTE, TYPE_MA, TYPE_PI) " +
                "VALUES (@noC, @cdAttrC, @nomC, @descriptC, @typeMo, @attrMo, @nivMo, @atk, @def, @typesCarteMonstre, NULL, NULL)";

            cmd.Parameters.Add("@noC", MySqlDbType.Int32).Value = m.GetNo();
            cmd.Parameters.Add("@cdAttrC", MySqlDbType.VarChar).Value = m.GetAttr().GetCdAttrCarte();
            cmd.Parameters.Add("@nomC", MySqlDbType.VarChar).Value = m.GetNom();
            cmd.Parameters.Add("@descriptC", MySqlDbType.VarChar).Value = m.GetDescription();

            cmd.Parameters.Add("@typeMo", MySqlDbType.VarChar).Value = m.GetTypeM();
            cmd.Parameters.Add("@attrMo", MySqlDbType.VarChar).Value = m.GetAttribut();
            cmd.Parameters.Add("@nivMo", MySqlDbType.Int32).Value = m.GetNiveau();
            cmd.Parameters.Add("@atk", MySqlDbType.Int32).Value = m.GetAtk();
            cmd.Parameters.Add("@def", MySqlDbType.Int32).Value = m.GetDef();
            cmd.Parameters.Add("@typesCarteMonstre", MySqlDbType.VarChar).Value = m.GetSousTypes();

            if (cmd.ExecuteNonQuery() == 1)
                return ORMCarte.AjouterEffetsCarte(m);
            return false;
        }
    }
}
