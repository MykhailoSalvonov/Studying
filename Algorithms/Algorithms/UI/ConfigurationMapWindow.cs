using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ConfigurationMapWindow : Form
    {
        public ConfigurationMapWindow()
        {
            InitializeComponent();
        }

        private void addCityBtn_Click(object sender, EventArgs e)
        {
            // Додавання нового стовпця
            int columnIndex = mapGrid.Columns.Add(cityValue.Text, cityValue.Text);

            // Додавання нового рядка
            int rowIndex = mapGrid.Rows.Add();

            // Встановлення заголовка рядка
            mapGrid.Rows[rowIndex].HeaderCell.Value = cityValue.Text;

            // Перевірка, що стовпець та рядок дійсно були додані
            if (columnIndex >= 0 && rowIndex >= 0)
            {
                // Встановлення відстані до самого себе як 0
                mapGrid.Rows[rowIndex].Cells[columnIndex].Value = 0;
            }
        }

        public void FillGridWithData(int[,] distances)
        {
            int rows = distances.GetLength(0); // Кількість рядків у масиві
            int cols = distances.GetLength(1); // Кількість стовпців у масиві

            mapGrid.ColumnCount = cols;

            // Налаштування назв стовпців та рядків (припустимо, що міста мають назви "City 1", "City 2", і т.д.)
            for (int i = 0; i < cols; i++)
            {
                mapGrid.Columns[i].Name = $"City {i + 1}";
            }

            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = distances[i, j].ToString();
                }

                mapGrid.Rows.Add(row);
                mapGrid.Rows[i].HeaderCell.Value = $"City {i + 1}"; // Назва рядка
            }
        }

        public int[,] ExtractDataFromGrid()
        {
            int rows = mapGrid.RowCount-1;
            int cols = mapGrid.ColumnCount;

            int[,] distances = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mapGrid.Rows[i].Cells[j].Value != null)
                    {
                        if (int.TryParse(mapGrid.Rows[i].Cells[j].Value.ToString(), out int value))
                        {
                            distances[i, j] = value;
                        }
                        else
                        {
                            distances[i, j] = 0;
                        }
                    }
                }
            }

            return distances;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            mapGrid.Rows.Clear();
            mapGrid.Columns.Clear();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            mapGrid.Rows.Clear();
            mapGrid.Columns.Clear();

            Close();
        }
    }
}
