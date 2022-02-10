using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.Model
{
    class DBO
    {
        public static string conS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PUCIT\C#_Projects\Point_of_Sale\Point_of_Sale\Model\ItemsDatabase.mdf;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(conS);
        public static bool addData(string price,string date,string time,List<Item> list)
        {
            int c=-1;
            try
            {
                con.Open();
                string query = $"insert into orders(price,date,time) VALUES ('{price}','{date}','{time}')SELECT SCOPE_IDENTITY()";
                SqlCommand comd = new SqlCommand(query, con);
                int key = Convert.ToInt32(comd.ExecuteScalar());
                string query2 = "";
                
                for (int i = 0; i < list.Count; i++)
                {
                    query2 = $"insert into Item(name,price,quantity,total,tax,comment,orderId) VALUES('{list[i].itemName}','{list[i].price}','{list[i].quantity}','{list[i].total}','{list[i].tax}','{list[i].comment}',{key})";
                    SqlCommand comd2 = new SqlCommand(query2, con);
                    c=comd2.ExecuteNonQuery();
                }
            }catch(Exception e)
            {
                return false;
            }
            con.Close();
            return true;
        }

    }
}
