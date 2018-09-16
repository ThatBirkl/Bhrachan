using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class DB : MonoBehaviour
{
    private static string constr = "URI=file:" + Application.dataPath + "/database.db";

    /*
     * Executes an insert query on the database
     * 
     * @param query The insert query
     */
    public static void Insert(string query)
    {
        SqliteConnection dbc = new SqliteConnection(constr);
        SqliteCommand dbcm;

        dbc.Open();
        dbcm = new SqliteCommand(query, dbc);
        dbcm.ExecuteNonQuery();
        dbc.Dispose();
    }


    /*
     * Executes a select query on the database
     * 
     * @param query The select query 
     * 
     * @return DataTable with result from query. Read docu on DataTables to find out how to access the data in there
     */
    public static DataTable Select(string query)
    {
        DataTable res = new DataTable();
        
        SqliteConnection dbc = new SqliteConnection(constr);
        SqliteCommand dbcm;
        SqliteDataReader dbr;

        dbc.Open();
        dbcm = new SqliteCommand(query, dbc);
        dbr = dbcm.ExecuteReader();

        res.Load(dbr);

        dbc.Close();
        dbc.Dispose();
        return res;
    }
}
