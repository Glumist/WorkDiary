using System;
using System.Windows.Forms;
using WorkDiary.Classes;

namespace WorkDiary.Forms
{
    public partial class FormLink : Form
    {
        public Link EditedLink;

        public FormLink()
        {
            InitializeComponent();

            EditedLink = new Link();
        }

        public FormLink(Link link)
        {
            InitializeComponent();

            EditedLink = link;
            tbDefinition.Text = link.Definition;
            tbAddress.Text = link.Address;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedLink.Definition = tbDefinition.Text;
            EditedLink.Address = tbAddress.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}