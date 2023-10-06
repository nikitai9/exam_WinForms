using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;

            view.DataRequested += (sender, args) => GetData();
        }

        private void GetData()
        {
            string data = model.GetData();
            view.ShowData(data);
        }
    }
}
