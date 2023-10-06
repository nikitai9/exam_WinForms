using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class View
    {
        public event EventHandler DataRequested;

        public void ShowData(string data)
        {
            // Отображение данных на форме
            textBoxData.Text = data;
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            DataRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
