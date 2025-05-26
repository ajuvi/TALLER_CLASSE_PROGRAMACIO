using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Pattern
{
    public class IDAOTeamMySqlImpl : IDAO <Team>

    {
        MySql.Data.MySqlClient.MySqlConnection cN;
        public IDAOTeamMySqlImpl()
        {


            string strCn = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_equips;";


            cN = new MySqlConnection(strCn);
            cN.Open();

            Console.WriteLine($"MySQL version : {cN.ServerVersion}");
        }
        public void Delete(string  id)
        {
            string sql = "DELETE FROM equips WHERE ABREVIACIO = @id";
            MySqlCommand cmd = new MySqlCommand(sql, cN);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public HashSet<Team> GetAll()
        {


            return null ;

        }


        public Team GetValue(string abv)
        {
            Team equip=null;
            var sSql = "SELECT * FROM EQUIPS WHERE ABREVIACIO = @ABV";
            MySqlCommand cmd = new MySqlCommand(sSql, cN);

            cmd.Parameters.AddWithValue("@ABV", abv);
            
            cmd.Prepare();

            MySqlDataReader cursor = cmd.ExecuteReader() ;
            if (cursor.Read())
            {
                equip = new(cursor.GetString("ABREVIACIO"), cursor.GetString("NOM"), cursor.GetInt32("PRESSUPOST"), cursor.GetString("LOGOLINK"));
            }
            cursor.Close();
            
            return equip ;
        }

        public void Save(Team value)
        {
            throw new NotImplementedException();
        }

        
        public void Update(string abreviacio, Team updatedTeam)
        {
            throw new NotImplementedException();
        }
    }
}
