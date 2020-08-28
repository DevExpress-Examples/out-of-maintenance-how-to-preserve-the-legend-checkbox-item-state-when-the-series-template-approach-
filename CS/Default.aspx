<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dxchartsui" %>
<%@ Register assembly="DevExpress.XtraCharts.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dxchartsui:WebChartControl ID="chart" runat="server" CrosshairEnabled="True" 
            Height="322px" Width="613px" 
            OnLegendItemChecked="chart_LegendItemChecked" DataSourceID="AccessDataSource1" 
            SeriesDataMember="CategoryName" 
            onbounddatachanged="chart_BoundDataChanged">
            <diagramserializable>
                <cc1:XYDiagram>
                    <axisx visibleinpanesserializable="-1">
                    </axisx>
                    <axisy visibleinpanesserializable="-1">
                    </axisy>
                </cc1:XYDiagram>
            </diagramserializable>
            <legend usecheckboxes="True"></legend>
            <seriestemplate argumentdatamember="SupplierID" 
                valuedatamembersserializable="UnitsInStock">
            </seriestemplate>
        </dxchartsui:WebChartControl>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/nwind.mdb" 
            
            SelectCommand="SELECT Products.UnitsInStock, Categories.CategoryName, Products.SupplierID FROM (Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID)">
        </asp:AccessDataSource>
    
    </div>
    </form>
</body>
</html>
