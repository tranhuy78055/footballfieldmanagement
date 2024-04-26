using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
namespace QuanLySanBong.View
{
    public partial class TK_HoaDon : Form
    {
        public TK_HoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            ParameterValues inputday = new ParameterValues();
            ParameterValues outputday = new ParameterValues();
            ParameterDiscreteValue disinputday = new ParameterDiscreteValue();
            ParameterDiscreteValue disoutputday = new ParameterDiscreteValue();
            disinputday.Value = dtp_input.Value;
            disoutputday.Value = dtp_output.Value;
            inputday.Add(disinputday);
            outputday.Add(disoutputday);
            rpt.DataDefinition.ParameterFields[0].ApplyCurrentValues(inputday);
            rpt.DataDefinition.ParameterFields[1].ApplyCurrentValues(outputday);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

           
        }
    }
}
