﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class OperasyonClass
    {
        public void operasyonekle(string oadi,string otanim)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO operasyon (ad,tanim) "+"VALUES (@oadi,@otanim);";
            command.Parameters.AddWithValue("@oadi",oadi);
            command.Parameters.AddWithValue("@otanim", otanim);
            command.ExecuteNonQuery();
            mycon.connectionclose();


        }
        public string[] OperasyonBilgiGetir(string oid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM operasyon WHERE operasyon_id=@oid";
            command.Parameters.AddWithValue("@oid", Convert.ToInt32(oid));
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[2];

            arr[0] = comread["ad"].ToString();
            arr[1] = comread["tanim"].ToString();
            
            mycon.connectionclose();
            return arr;
        }
        public void OperasyonGuncelle(string oadi, string otanim)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE operasyon SET ad=@oadi,tanim=@otanim ";
            command.Parameters.AddWithValue("@oadi", oadi);
            command.Parameters.AddWithValue("@otanim", otanim);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }
    }
}