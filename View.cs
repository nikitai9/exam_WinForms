using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class UserViewForm : Form
    {
        private UserController controller;

        public UserViewForm(UserController controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public UserController Controller { get => controller; set => controller = value; }

    }
}
