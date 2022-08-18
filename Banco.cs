using Mono.Data.SqliteClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Banco : MonoBehaviour
{
    private IDbConnection connec;
    private IDbCommand command;
    private IDataReader reader;
    private string stringConnection = "URI=File:Banco.db";

    private bool conectar()
    {
        try
        {
            connec = new SqliteConnection(stringConnection);
            command = connec.CreateCommand();
            connec.Open();
            command.CommandText = "PRAGMA foreign_keys = ON; CREATE TABLE IF NOT EXISTS OBJECTS (ID INTEGER PRIMARY KEY AUTOINCREMENT, POSX INTEGER, POSY INTEGER, POSZ INTEGER, ROTX INTEGER, ROTY INTEGER, ROTZ INTEGER);";
            command.ExecuteNonQuery();
            return true;

        }
        catch (System.Exception ex)
        {
            print(ex.Message);
            return false;
        }
    }

    public bool inserir(GameObject player)
    {
        try
        {
            conectar();
            command.CommandText = "insert into OBJECTS (POSX, POSY, POSZ, ROTX, ROTY, ROTZ) VALUES (" + player.transform.position.x  + ", " + player.transform.position.y + ", " + player.transform.position.z + ", " + player.transform.rotation.x + ", " + player.transform.rotation.y + ", " + player.transform.rotation.z + ");";
            //command.Parameters.Add(nome);
            command.ExecuteNonQuery();
            return true;
        }
        catch (System.Exception)
        {

            return false;
        }
        finally
        {
            connec.Close();
        }
    }

    public bool alterar(GameObject player, GameObject item1, GameObject item2, GameObject item3, GameObject item4, GameObject item5)
    {
        try
        {
            conectar();
            string comandoSql = "UPDATE OBJECTS SET PLAYER = '" + player + "' ";
            
            //string comandoSql = "UPDATE USUARIOS SET NOME = '" + nome + "' " + "WHERE ID = " + id + ";";
            //command.Parameters.Add(nome);
            //command.Parameters.Add(id);
            command.ExecuteNonQuery();
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
        finally
        {
            connec.Close();
        }
    }
}
