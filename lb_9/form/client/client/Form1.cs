using client.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        CarApi carApi = new CarApi();
        public Form1()
        {
            InitializeComponent();
            initialCarDataGridView();
        }

        private void getCarsButton_Click(object sender, EventArgs e)
        {
            resetDataGridView(dataGridView1);
            refetchData();
        }

        void initialCarDataGridView()
        {
            DataGridViewTextBoxColumn car_id = new DataGridViewTextBoxColumn();
            car_id.HeaderText = "car_id";
            DataGridViewTextBoxColumn car_name = new DataGridViewTextBoxColumn();
            car_name.HeaderText = "car_name";
            DataGridViewTextBoxColumn car_price = new DataGridViewTextBoxColumn();
            car_price.HeaderText = "car_price";
            DataGridViewTextBoxColumn buyerName = new DataGridViewTextBoxColumn();
            buyerName.HeaderText = "buyerName";

            dataGridView1.Columns.Add(car_id);
            dataGridView1.Columns.Add(car_name);
            dataGridView1.Columns.Add(car_price);
            dataGridView1.Columns.Add(buyerName);
        }

        private void getCarByIdButton_Click(object sender, EventArgs e)
        {
            resetDataGridView(dataGridView1);
            string car_id = carId.Text;
            var res = carApi.getCarInformationById(car_id);
            if (res == null) return;
            if (res.Count() == 0)
            {
                MessageBox.Show("Запрос не выдал результатов");
                return;
            }

            foreach (var item in res)
            {
                dataGridView1.Rows.Add(item.car_id, item.name, item.price, item.buyerName);
            }
        }

        private void resetDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        private void deleteCarByID_Click(object sender, EventArgs e)
        {
            resetDataGridView(dataGridView1);
            
            carApi.deleteCarID(deleteCarID.Text);

            refetchData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            resetDataGridView(dataGridView1);
            carApi.updateCarByID(updateID.Text, car_name.Text, int.Parse(car_price.Text));
            refetchData();
        }

        private void refetchData()
        {
            var res = carApi.getAllCars();

            foreach (var item in res)
            {
                dataGridView1.Rows.Add(item.car_id, item.name, item.price, item.buyerName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetDataGridView(dataGridView1);
            carApi.CreateCarBy(create_car_id.Text, create_car_name.Text, int.Parse(create_car_price.Text));
            refetchData();
        }
    }
}
