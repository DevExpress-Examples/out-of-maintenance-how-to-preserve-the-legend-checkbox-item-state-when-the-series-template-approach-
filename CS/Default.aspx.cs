using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    const string key = "uncheckedInLegendList";

    bool inUpdate;
    List<int> uncheckedSeriesIndexes = new List<int>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chart_LegendItemChecked(object sender, LegendItemCheckedEventArgs e) {
        if (inUpdate)
            return;
        Series series = e.CheckedElement as Series;
        if (series == null)
            return;
        if (e.NewCheckState == true)
            uncheckedSeriesIndexes.Remove(chart.Series.IndexOf(series));
        else
            uncheckedSeriesIndexes.Add(chart.Series.IndexOf(series));
        Session[key] = uncheckedSeriesIndexes;
    }
    protected void chart_BoundDataChanged(object sender, EventArgs e) {
        if (Session[key] != null)
            uncheckedSeriesIndexes = (List<int>)Session[key];
        inUpdate = true;

        for (int i = 0; i < chart.Series.Count; i++) {
            if (uncheckedSeriesIndexes.Contains(i))
                chart.Series[i].CheckedInLegend = false;
        }
        inUpdate = false;
    }
}