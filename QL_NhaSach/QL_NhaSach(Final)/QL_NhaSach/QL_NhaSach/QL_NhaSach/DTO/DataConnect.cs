using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;

namespace QL_NhaSach.DTO
{
    public class DataConnect
    {
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }


        public DataConnect()
        {

        }
        public DataConnect(string server, string database)
        {
            Conn = new SqlConnection(String.Format("Data Source= {0};Initial Catalog={1};Integrated Security=True", server, database));
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Closed) conn.Close();
        }
        public SqlCommand getSQLCommand(string strSQL)
        {
            return new SqlCommand(strSQL, Conn);
        }
        public DataTable getDataTable(string strSQL)
        {
            Open();
            SqlCommand cmd = getSQLCommand(strSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "DataTable");
            Close();
            return ds.Tables["DataTable"];
        }
        public SqlDataReader getReaderTable(string strSQL)
        {
            Open();
            SqlCommand cmd = getSQLCommand(strSQL);
            SqlDataReader reader = cmd.ExecuteReader();
            Close();
            return reader;
        }
        public DataSet getDataSetTable(string strSQL, string table)
        {
            Open();
            SqlCommand cmd = getSQLCommand(strSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            Close();
            return ds;
        }
        public int updateTable(string strSQL)
        {
            Open();
            SqlCommand cmd = getSQLCommand(strSQL);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public int countTable(string strSQL)
        {
            Open();
            SqlCommand cmd = getSQLCommand(strSQL);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public bool chexkExist_Table(string table, string fiel, string value)
        {
            Open();
            string strSQL = String.Format("select count(*) from {0} where {1} = '{2}'", table, fiel, value);
            SqlCommand cmd = getSQLCommand(strSQL);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            if (kq >= 1)
                return true;
            return false;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        public List<Object> ListTable<Object>(DataTable dt)
        {
            List<Object> list = new List<Object>();
            foreach (DataRow item in dt.Rows)
            {
                Object n = GetItem<Object>(item);
                list.Add(n);
            }
            return list;
        }
        public List<Object> BindingSourceToList<Object>(BindingSource Source)
        {
            List<Object> list = ((IEnumerable)Source.DataSource).OfType<Object>().ToList();
            return list;
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
