using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = new DataTable();
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                if (lines.Length > 0)
                {
                    // Assume the first row is the header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dataTable.Columns.Add(new DataColumn(headerWord));
                    }

                    // Data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dataTable.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dataTable.Rows.Add(dr);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dataTable = dataGridView1.DataSource as DataTable;
                if (dataTable != null)
                {
                    SaveDataTableToCSV(dataTable, saveFileDialog.FileName);
                }
            }
        }

        private void SaveDataTableToCSV(DataTable dataTable, string filePath)
        {
            StringBuilder fileContent = new StringBuilder();

            foreach (DataColumn col in dataTable.Columns)
            {
                fileContent.Append(col.ColumnName + ",");
            }
            fileContent.Remove(fileContent.Length - 1, 1);
            fileContent.Append(Environment.NewLine);

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var column in dr.ItemArray)
                {
                    fileContent.Append("\"" + column.ToString().Replace("\"", "\"\"") + "\",");
                }
                fileContent.Remove(fileContent.Length - 1, 1);
                fileContent.Append(Environment.NewLine);
            }

            File.WriteAllText(filePath, fileContent.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}