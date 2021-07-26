using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quality
{
    public partial class ResultBlockBonus : Form
    {
        private string _conn, _table = "aerated_block", _dataBase = "mmm";
        private List<string> _rename = new List<string>();
        private List<string> _namesVisibl = new List<string>() { "id" };
        private string _id;
        private int[] _idResult = new int[0];
        public ResultBlockBonus(string conn, string id)
        {
            this._id = id;
            this._conn = conn;
            InitializeComponent();
            Renewal();
        }

        private void AddList()
        {
            _rename.Add("номер партии");
            _rename.Add("фактическая плотность");
            _rename.Add("номер плотности");
            _rename.Add("сила действительная");
            _rename.Add("номер класса");
            _rename.Add("номер марки");
            _rename.Add("фактическая влажность");
            _rename.Add("Комментарий");
        }

        private void RenameAndVisibl(DataSet ds)
        {
            foreach (DataGridViewColumn item in dataGridView_ResultBlock.Columns)
            {
                if (_namesVisibl.Contains(item.Name)) item.Visible = false;
            }
            dataGridView_ResultBlock.Columns["id_party"].HeaderText = _rename[0];
            dataGridView_ResultBlock.Columns["density_actual"].HeaderText = _rename[1];
            dataGridView_ResultBlock.Columns["id_density"].HeaderText = _rename[2];
            dataGridView_ResultBlock.Columns["strength_actual"].HeaderText = _rename[3];
            dataGridView_ResultBlock.Columns["id_class"].HeaderText = _rename[4];
            dataGridView_ResultBlock.Columns["id_mark"].HeaderText = _rename[5];
            dataGridView_ResultBlock.Columns["humidity_actual"].HeaderText = _rename[6];
            dataGridView_ResultBlock.Columns["comments"].HeaderText = _rename[7];
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ArrayId()
        {
            string f = "";
            StringBuilder stringBuilder = new StringBuilder(_id);
            for(int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] != ' ')
                {
                    f += stringBuilder[i].ToString();
                }
                else
                {
                    int[] e = new int[_idResult.Length + 1];
                    for (int h = 0; h < _idResult.Length; h++)
                    {
                        e[h] = _idResult[h];
                    }
                    e[e.Length - 1] = Convert.ToInt32(f);
                    _idResult = e;
                    f = "";
                }
            }
        }
 
        private void Renewal()
        {
            ArrayId();
            using (MySqlConnection mCon = new MySqlConnection(_conn))
            {
                try
                {
                    mCon.Open();
                    string sql = ("select * from " + _dataBase + ".`" + _table + "` where (");
                    for (int i = 0; i < _idResult.Length; i++)
                    {
                        if(i == _idResult.Length - 1)
                            sql += $"id = {_idResult[i]}";
                        else
                            sql += $"id = {_idResult[i]} || ";
                    }
                    sql += ")";
                    MySqlDataAdapter dD = new MySqlDataAdapter(sql, mCon);
                    DataSet ds = new DataSet();
                    ds.Reset();
                    dD.Fill(ds, sql);
                    dataGridView_ResultBlock.DataSource = ds.Tables[0];

                    //AddList();
                    //RenameAndVisibl(ds);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mCon.Close();
                }
            }
        }
    }
}
