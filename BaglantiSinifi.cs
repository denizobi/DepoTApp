using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace _083005334
{
    public class BaglantiSinifi
    {       
        // Microsoft Access Veritabanına Bağlantı İçin
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb");
        public OleDbCommand comm = new OleDbCommand();
        OleDbDataAdapter oda = new OleDbDataAdapter();

        public int QueryCalistir(string sqlQuery, CommandType commandType)
        {
            try
            {
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.CommandType = commandType;
                comm.CommandTimeout = 100000000;
                if (conn.State != ConnectionState.Open)
                { conn.Open(); }
                int ef=comm.ExecuteNonQuery();
                conn.Close();
                return ef;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Hatası: ", ex.Message.ToString() + "-" + sqlQuery.ToString());
                conn.Close();
                return 0;
            }
        }

        public void ParametreEkle(string parameterName, object _value)
        {
            comm.Parameters.AddWithValue(parameterName, _value);
        }

        public void ParametreSil()
        {
            comm.Parameters.Clear();
        }

        public DataTable TabloGoster(string sqlQuery, CommandType commandType)
        {
            try
            {
                DataTable dt = new DataTable();
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.CommandType = commandType;
                comm.CommandTimeout = 100000000;
                oda.SelectCommand = comm;
                oda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Hatası: ", ex.Message.ToString() + "-" + sqlQuery.ToString());
                conn.Close();
                return null;
            }
        }

        public Object VeriGetir(string sqlQuery, CommandType commandType)
        {
            try
            {
                object obj;
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.CommandType = commandType;
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                obj = comm.ExecuteScalar();
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Hatası: ", ex.Message.ToString() + "-" + sqlQuery.ToString());
                conn.Close();
                return null;
            }
        }

        public DataSet DataSetGoster(string sqlQuery, CommandType commandType)
        {
            try
            {
                DataSet dt = new DataSet();
                comm.Connection = conn;
                comm.CommandText = sqlQuery;
                comm.CommandType = commandType;
                comm.CommandTimeout = 100000000;
                oda.SelectCommand = comm;

                oda.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }
    }
}
