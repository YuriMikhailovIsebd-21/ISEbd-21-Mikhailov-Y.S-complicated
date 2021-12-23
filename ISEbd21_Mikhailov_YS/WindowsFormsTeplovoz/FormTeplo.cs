using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTeplovoz
{
    public partial class FormTeplo : Form
    {
        private ITransport Teplo;
        public FormTeplo()
        {
            InitializeComponent();
            comboBoxNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNumber.SelectedIndex = 0;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.SelectedIndex = 0;
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTeplo.Width, pictureBoxTeplo.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Teplo.DrawTeplo(gr);
            pictureBoxTeplo.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Createn"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreaten_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int countDop = Convert.ToInt32(comboBoxNumber.SelectedItem);
            int tubeType = Convert.ToInt32(comboBoxType.SelectedIndex);
            Teplo = new Teplovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Blue, true, true, countDop, tubeType);
            Teplo.SetPosition(rnd.Next(100, 400), rnd.Next(100, 400), pictureBoxTeplo.Width, pictureBoxTeplo.Height);
            Draw();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click (object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "ButtonUp":
                    Teplo.MoveTeplo(Direction.Up);
                    break;
                case "ButtonDown":
                    Teplo.MoveTeplo(Direction.Down);
                    break;
                case "ButtonLeft":
                    Teplo.MoveTeplo(Direction.Left);
                    break;
                case "ButtonRight": 
                    Teplo.MoveTeplo(Direction.Right);
                    break;
                case "buttonMove_Click":
                    break;
            }
            Draw(); 
        }
    }
}
