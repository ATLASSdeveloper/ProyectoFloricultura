using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Repo : Form
    {
        public Repo()
        {
            InitializeComponent();
            this.cargaDatos();
        }

        public void cargaDatos()
        {
            LogicaEstadistica log = new LogicaEstadistica();
            DataTable tabla = log.tabla();
            ArrayList arlist = new ArrayList();
            ArrayList arlist2 = new ArrayList();
            ArrayList arlist3 = new ArrayList();
            for (int i = 0;i< tabla.Rows.Count;i++)
            {
                arlist.Add(tabla.Rows[i]["FECHA"].ToString());
                arlist2.Add(Convert.ToDouble(tabla.Rows[i]["ROUND((SUM(TEMPERATURA))/COUNT(ID))"]));
                arlist3.Add(Convert.ToDouble(tabla.Rows[i]["ROUND((SUM(HUMEDAD))/COUNT(ID))"]));
            }
            estadistica.Series[0].Points.DataBindXY(arlist,arlist2);
            estadistica.Series[1].Points.DataBindXY(arlist, arlist3);
        }
    }
}
