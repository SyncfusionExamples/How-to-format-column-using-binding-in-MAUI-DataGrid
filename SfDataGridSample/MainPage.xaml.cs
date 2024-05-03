using Syncfusion.Maui.DataGrid;
using System.Data;
using System.Reflection;
namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn; ;
        }

        private void DataGrid_AutoGeneratingColumn(object? sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.MappingName == "Salary")
            {
                e.Column = new DataGridTextColumn() { MappingName = "Salary", HeaderText = "Salary" };
                e.Column.DisplayBinding = new Binding() { Path = "Salary", StringFormat = "{0:C}" };
            }
        }
    } 
}
