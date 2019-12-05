using System;
using System.Collections.Generic;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserSQLDAO : IUserDAO
    {
        public void AddUser(User user)
        {
            using(var connection=new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using(var command=new SqlCommand())
                {
                    command.CommandText = "AddUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Firstname", user.FirstName);
                    command.Parameters.AddWithValue("@lastname", user.LastName);
                    command.Parameters.AddWithValue("@BirthDay", user.DateOfBirthDay);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void UpdateUser(User user, int id)
        {
            using (var connection = new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "UpdateUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@ID", user.ID);
                    command.Parameters.AddWithValue("@Firstname", user.FirstName);
                    command.Parameters.AddWithValue("@lastname", user.LastName);
                    command.Parameters.AddWithValue("@BirthDay", user.DateOfBirthDay);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void DeleteUser(User user)
        {
            using (var connection = new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "DeleteUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Firstname", user.FirstName);
                    command.Parameters.AddWithValue("@lastname", user.LastName);
                    command.Parameters.AddWithValue("@BirthDay", user.DateOfBirthDay);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public IEnumerable<User> GetUsersList()
        {
            List<User> users = new List<User>();
            using(var connection=new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("GetAwards", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                        users.Add(user);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return users;
        }
        public IEnumerable<Award> GetAwardsOfUser(User user)
        {
            List<Award> awards = new List<Award>();
            using (var connection = new SqlConnection(DataBaseConfig.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "GetUsersAwards";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var award = new Award(reader.GetInt32(0), reader.GetString(1));
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
