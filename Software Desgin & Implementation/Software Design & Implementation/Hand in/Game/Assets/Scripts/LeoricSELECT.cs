using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data; 
using System;

public class LeoricSELECT : MonoBehaviour {

	// Use this for initialization
	public void LoadOnClick () {
		string conn = "URI=file:" + Application.dataPath + "Player.db"; //Path to database.
		IDbConnection dbconn;
		dbconn = (IDbConnection) new SqliteConnection(conn);
		
		dbconn.Open(); //Open connection to the database.
		IDbCommand dbcmd = dbconn.CreateCommand();
		string sqlQuery = "SELECT Name, Speed, Health, Stamina " + "FROM Player WHERE ID=1";
		dbcmd.CommandText = sqlQuery;
		IDataReader reader = dbcmd.ExecuteReader();
		
		while (reader.Read())
		{
			string Name = reader.GetString(0);
			int Speed = reader.GetInt32(1);
			int Health = reader.GetInt32(2);
			int Stamina = reader.GetInt32(3);
			
			Debug.Log( "Name= "+Name+" Speed ="+Speed+" Health = "+Health+" Stamina= "+ Stamina);
		}
		reader.Close();
		reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		dbconn.Close();
		dbconn = null;
		
	}
	

}
