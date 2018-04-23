using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;

namespace WindowsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDBDataSet1.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet1.Cars);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //dataLayoutControl1.RetrieveFields();
            RetrieveFields(dataLayoutControl1);
        }

        public void RetrieveFields(DataLayoutControl lc)
        {
            lc.Clear();
            LayoutElementsBindingInfoHelper bindingHelper = new LayoutElementsBindingInfoHelper(lc);
            LayoutElementsBindingInfo info;
            info = bindingHelper.CreateDataLayoutElementsBindingInfo();
            bindingHelper.FillWithSuggestedValues(info);
            List<LayoutElementBindingInfo> bindingsInfo = info.GetAllBindings(); 
            foreach (LayoutElementBindingInfo bindingInfo in bindingsInfo) {
                if (bindingInfo.DataInfo.Name == "Description") {
                    bindingInfo.EditorType = typeof(MemoEdit);
                    break;
                } 
            }
            LayoutCreator creator = new LayoutCreator(lc);
            creator.CreateLayout(info);
            foreach (BaseLayoutItem item in lc.Items) {
                if (item is LayoutControlItem) {
                    Control c = (item as LayoutControlItem).Control;
                    if (c.DataBindings[0].BindingMemberInfo.BindingMember == "Description") {
                        (item as LayoutControlItem).SizeConstraintsType = SizeConstraintsType.Custom;
                        (item as LayoutControlItem).MinSize = new Size(0, 100);
                    }
                }
            }
        }
    }
}