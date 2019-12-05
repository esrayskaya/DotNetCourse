using System;
using System.Collections.Generic;
using System.Text;
using Common;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AwardSQLDAO : IAwardDAO
    {
        public void AddAward(Award award)
        {
            using(var connection=new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using(var command=new SqlCommand())
                {
                    command.CommandText = "AddAward";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Title", award.Title);
                    command.Parameters.AddWithValue("@Description", award.Description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void UpdateAward(Award award, int id)
        {
            using(var connection=new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using(var command=new SqlCommand())
                {
                    command.CommandText = "UpdateAward";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@ID", award.ID);
                    command.Parameters.AddWithValue("@Title", award.Title);
                    command.Parameters.AddWithValue("@Description", award.Description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void DeleteAward(Award award)
        {
            using(var connection=new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using(var command=new SqlCommand())
                {
                    command.CommandText = "DeleteAward";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@ID", award.ID);
                    command.Parameters.AddWithValue("@Title", award.Title);
                    command.Parameters.AddWithValue("@Description", award.Description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public IEnumerable<Award> GetAwardsList()
        {
            List<Award> awards = new List<Award>();
            using(var connection=new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using(var command=new SqlCommand("GetAwards", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var award = new Award(reader.GetInt32(0), reader.GetString(1), reader[2]?.ToString());
                        awards.Add(award);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return awards;
        }
    }
}
