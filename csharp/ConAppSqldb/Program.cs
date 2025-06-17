using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
public class Externalcandidate
{
    public string cCandidatecode { get; set; }
    public string vFirstname { get; set; }
    public string vLastname { get; set; }
}

class Program
{
    static void GetCandidateByCode(string code)
    {
        SqlConnection con = null;
        SqlDataReader reader = null;

        try
        {
            string str = "Data Source=chandu;Initial Catalog=Recruitment;Integrated Security=SSPI;";
            con = new SqlConnection(str);
            con.Open();

            string sql = "SELECT * FROM ExternalCandidate WHERE cCandidatecode = @code";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@code", code);

            reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("No candidate found with code: " + code);
            }

            while (reader.Read())
            {
                Console.WriteLine("Candidate Code: " + reader["cCandidatecode"]);
                Console.WriteLine("First Name: " + reader["vFirstname"]);
                Console.WriteLine("Last Name: " + reader["vLastname"]);
                Console.WriteLine("------------------------------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            if (reader != null) reader.Close();
            if (con != null && con.State == ConnectionState.Open) con.Close();
        }
    }


    static void sqlinsert(string code, string fname, string lname)
    {
        SqlConnection con = null;
        try
        {
            string str = "Data Source=chandu;Integrated Security=SSPI;Initial Catalog=Recruitment";
            con = new SqlConnection(str);
            con.Open();

            string sql = "Insert Into Externalcandidate" +
                          "(cCandidatecode, vFirstName, vLastName) Values" +
                          "(@code, @fname, @lname)";
            //SqlCommand cmd= new SqlCommand(sql, con);
            //This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, con))
            {

                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@code",
                    Value = code,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@fname",
                    Value = fname,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@lname",
                    Value = lname,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 20
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();

            }
        }

        catch (Exception ex)

        {
            Console.WriteLine(ex.Message);
        }

    }
    static void Main(string[] args)
    {

        //GetCandidateByCode("000101");

        //Console.ReadLine();
    }

}