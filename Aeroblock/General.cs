using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using quality;
using quality.directory;
using quality.Messenger;

namespace Aeroblock
{
    public partial class General : Form
    {
        private MySqlConnection mCon;

        //string conn = "Database=u0550310_aeroblock2; Server=31.31.196.61; port=3306; username=u0550_guseva; password=irinka20112004; charset=utf8 ";
        //string conn4 = "Database=aeroblock_2; Server=192.168.100.100; port=3306; username=sss_aebl; password=12345; charset=utf8 ";
        private string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        private string conn2 = ConfigurationManager.ConnectionStrings["conn2"].ConnectionString;
        private string conn3 = ConfigurationManager.ConnectionStrings["conn3"].ConnectionString;
        private string conn4 = ConfigurationManager.ConnectionStrings["conn4Local"].ConnectionString;
        //private string conn4 = ConfigurationManager.ConnectionStrings["conn4"].ConnectionString;


        public General()
        {
            mCon = new MySqlConnection(conn);
            InitializeComponent();
        }

        private void General_Load(object sender, EventArgs e)
        {
        }

        private void возвратныеПаллетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Pallet> list = null;
                list = MdiChildren.OfType<Pallet>();
                if (list != null && list.Count() > 0)
                {
                    list.First().Activate();
                }
                else
                {
                    Pallet form = new Pallet(conn);
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра заявок", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<RZD_general> list = null;
                list = MdiChildren.OfType<RZD_general>();
                if (list != null && list.Count() > 0)
                {
                    list.First().Activate();
                }
                else
                {
                    RZD_general form = new RZD_general(conn2);
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void отчетСводныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<report.General> list = null;
                list = MdiChildren.OfType<report.General>();
                if (list != null && list.Count() > 0)
                {
                    list.First().Activate();
                }
                else
                {
                    report.General form = new report.General();
                    form.MdiParent = this;
                    form.Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра заявок", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_pass up = new user_pass(conn4);

            if (up.ShowDialog() == DialogResult.OK)
            {
                входНеВыполненToolStripMenuItem.Text = "" + up.user + "";
                входToolStripMenuItem.Enabled = false;
            }
            if (up.previl == "1")
            {
                toolStripMenuItem1.Enabled = true;
                //остаткиПоСчетамToolStripMenuItem.Enabled = true;
                //реестрСчетовToolStripMenuItem.Enabled = true;
                //справочникиToolStripMenuItem.Enabled = true;
                //окнаToolStripMenuItem.Enabled = true;
            }
            if (up.previl == "2")
            {
                //заявкиToolStripMenuItem.Enabled = true;
                //остаткиПоСчетамToolStripMenuItem.Enabled = true;
                //реестрСчетовToolStripMenuItem.Enabled = true;
                //справочникиToolStripMenuItem.Enabled = true;
                //работникиГКToolStripMenuItem.Visible = false;

                //окнаToolStripMenuItem.Enabled = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            входToolStripMenuItem.Enabled = true;
            входНеВыполненToolStripMenuItem.Text = "Вход не выполнен";
            //заявкиToolStripMenuItem.Enabled = false;
            //остаткиПоСчетамToolStripMenuItem.Enabled = false;
            //реестрСчетовToolStripMenuItem.Enabled = false;
            //справочникиToolStripMenuItem.Enabled = false;
            //окнаToolStripMenuItem.Enabled = false;
        }

        private void ремонтПаллетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Remont_pal> list = null;
                list = MdiChildren.OfType<Remont_pal>();
                if (list != null && list.Count() > 0)
                {
                    list.First().Activate();
                }
                else
                {
                    Remont_pal form = new Remont_pal(conn);
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Order_GB> list = null;
                list = MdiChildren.OfType<Order_GB>();
                if (list != null && list.Count() > 0)
                {
                    list.First().Activate();
                }
                else
                {
                    Order_GB form = new Order_GB(conn3);
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        //Cement
        private void ЦементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "cement")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "cement");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра цемента", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void ГипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "drymixes")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "drymixes");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра гипса", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void ШламToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "sludge")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "sludge");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра шлам", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void ОпределениеАктивностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "lime_activity")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "lime_activity");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра определения активности", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void ОпределениеВремениГашенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "lime_blankings")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "lime_blankings");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра определения времени гашения", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void ЖурналТехнологическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "technology")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "technology");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра журнала технологического", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void ИспытаниеГПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "aerated_block")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseForm form = new BaseForm(conn4, "aerated_block");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка просмотра испытаний гп", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void незнаюКакНазватьИГдеСтоятьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseForm> list = null;
                list = MdiChildren.OfType<BaseForm>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Text == "result_block")//Todo заменить text на AccessibleDefaultActionDescription и переименовать Для пользователя.
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    ResultBlocks form = new ResultBlocks(conn4);
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка незнаю как назвать и где стоять", ex.Message);
                //Logger.Message("Ошибка просмотра заявок", ex.Message);
                //toolSSLState.Text = ex.Message;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseFormDirectory> list = null;
                list = MdiChildren.OfType<BaseFormDirectory>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "class")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseFormDirectory form = new BaseFormDirectory(conn4, "class");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }

        private void групповыеМатериалыToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseFormDirectory> list = null;
                list = MdiChildren.OfType<BaseFormDirectory>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "group_material")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseFormDirectory form = new BaseFormDirectory(conn4, "group_material");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }

        private void производителиToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseFormDirectory> list = null;
                list = MdiChildren.OfType<BaseFormDirectory>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "manufacturer")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseFormDirectory form = new BaseFormDirectory(conn4, "manufacturer");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }

        private void маркиToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseFormDirectory> list = null;
                list = MdiChildren.OfType<BaseFormDirectory>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "mark")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseFormDirectory form = new BaseFormDirectory(conn4, "mark");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }

        private void МатериалыыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseFormDirectory> list = null;
                list = MdiChildren.OfType<BaseFormDirectory>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "material")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseFormDirectory form = new BaseFormDirectory(conn4, "material");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<BaseFormDirectory> list = null;
                list = MdiChildren.OfType<BaseFormDirectory>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "units")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    BaseFormDirectory form = new BaseFormDirectory(conn4, "units");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }

        private void MessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<MessengerMain> list = null;
                list = MdiChildren.OfType<MessengerMain>();
                bool isFinish = true;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.AccessibleDefaultActionDescription == "messengers")
                    {
                        list.First().Activate();
                        isFinish = true;
                        break;
                    }
                    else
                    {
                        isFinish = false;
                    }
                }
                if (isFinish == false)
                {
                    MessengerMain form = new MessengerMain(conn4, "messengers");
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы", ex.Message);
            }
        }
    }
}