using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BUS.Model;

namespace BUS
{
    public class Utils
    {
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                if (prop.Name == "IDPRODUCT")
                    dataTable.Columns.Add("Mã sản phẩm", type);
                else if (prop.Name == "NAMEPRODUCT")
                    dataTable.Columns.Add("Tên sản phẩm", type);
                else if(prop.Name == "DESCRIPTIONPRODUCT")
                    dataTable.Columns.Add("Mô tả", type);
                else if(prop.Name == "PRICEPRODUCT")
                    dataTable.Columns.Add("Giá", type);
                else if(prop.Name == "IMAGEPRODUCT")
                    dataTable.Columns.Add("Hình ảnh", type);
                else if(prop.Name == "STATUS")
                    dataTable.Columns.Add("Tình trạng", type);
                else if (prop.Name == "IDCATEGORY")
                    dataTable.Columns.Add("Mã loại", type);
                else if (prop.Name == "NAMECATEGORY")
                    dataTable.Columns.Add("Tên loại", type);
                else if (prop.Name == "NAMECUSTOMER")
                    dataTable.Columns.Add("Tên khách hàng", type);
                else if (prop.Name == "NAMESTAFF")
                    dataTable.Columns.Add("Tên nhân viên", type);
                else if (prop.Name == "DATECONTECT")
                    dataTable.Columns.Add("Ngày đặt", type);
                else if (prop.Name == "DATERECIVED")
                    dataTable.Columns.Add("Ngày nhận", type);
                else if (prop.Name == "DATEPAY")
                    dataTable.Columns.Add("Ngày trả", type);
                else
                 dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }


        public static DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "S.No.";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }
        public static String PickImage(PictureBox pic_image, string image)
        {
            if (pic_image.Image == null)
            {
                image = "placeholder.jpg";
            }
            string path = System.IO.Directory.GetCurrentDirectory();
            //  MessageBox.Show(path);
            if (image != path + image.ToString())
            {
                string imageName = System.IO.Path.GetFileName(image);
                image = imageName;
                if (!System.IO.File.Exists(path  + imageName))
                    System.IO.File.Copy(image, path + imageName);
            }
            return image;
        }
        public static Image LoadImage(string name)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            var imgDir = Path.Combine(path, "");
            var imgPath = Path.Combine(imgDir, name);
            return Image.FromFile(imgPath);
        }
        public static void setCurrentDictionary()
        {
            string currentDir = Environment.CurrentDirectory;
            if (currentDir.EndsWith("Hinh"))
            {
                Directory.SetCurrentDirectory(currentDir.ToString() != "" ? currentDir.ToString() : "");
            }
            else
            {
                int idx = currentDir.IndexOf("bin");
                string currentDirectory = "";
                if (idx != -1)
                {
                    currentDirectory = currentDir.Substring(0, idx) + "Hinh";
                }
                Directory.SetCurrentDirectory(currentDirectory.ToString() != "" ? currentDirectory.ToString() : "");
            }
        }

        //background color listview
        public static void RepaintListView(ListView lw)
        {
            foreach (ListViewItem item in lw.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightSeaGreen : Color.White;
            }
        }
    }
}
