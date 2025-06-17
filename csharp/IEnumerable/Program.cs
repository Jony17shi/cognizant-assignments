// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

class Program
{
    static string str = "Data Source=chandu;Integrated Security=SSPI;Initial Catalog=Recruitment";

    static void Main(string[] args)
    {
        disconnected();
        Console.ReadLine();
    }

    static void disconnected()
    {
        SqlConnection conString = new SqlConnection(str);
        conString.Open();
        SqlCommand cmdQuery = new SqlCommand("Select * from externalcandidate", conString);
        SqlDataAdapter sda = new SqlDataAdapter(cmdQuery);
        DataSet dsData = new DataSet();
        sda.Fill(dsData);  // x=y
        DataTable excan = dsData.Tables[0];
        IEnumerable<DataRow> query = from can in excan.AsEnumerable() select can;
        Console.WriteLine("Candidate Names:");
        foreach (DataRow p in query)
        {
            Console.WriteLine(p.Field<string>("vFirstName") + " " + p.Field<string>("vLastName"));
        }
    }
}
