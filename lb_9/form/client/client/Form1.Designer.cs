namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.getCarsButton = new System.Windows.Forms.Button();
            this.getCarByIdButton = new System.Windows.Forms.Button();
            this.carId = new System.Windows.Forms.TextBox();
            this.deleteCarByID = new System.Windows.Forms.Button();
            this.deleteCarID = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.updateID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.car_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.car_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.create_car_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.create_car_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.create_car_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Машины";
            // 
            // getCarsButton
            // 
            this.getCarsButton.Location = new System.Drawing.Point(12, 273);
            this.getCarsButton.Name = "getCarsButton";
            this.getCarsButton.Size = new System.Drawing.Size(147, 42);
            this.getCarsButton.TabIndex = 2;
            this.getCarsButton.Text = "Загрузить машины";
            this.getCarsButton.UseVisualStyleBackColor = true;
            this.getCarsButton.Click += new System.EventHandler(this.getCarsButton_Click);
            // 
            // getCarByIdButton
            // 
            this.getCarByIdButton.Location = new System.Drawing.Point(12, 321);
            this.getCarByIdButton.Name = "getCarByIdButton";
            this.getCarByIdButton.Size = new System.Drawing.Size(147, 42);
            this.getCarByIdButton.TabIndex = 3;
            this.getCarByIdButton.Text = "Загрузить машины по id";
            this.getCarByIdButton.UseVisualStyleBackColor = true;
            this.getCarByIdButton.Click += new System.EventHandler(this.getCarByIdButton_Click);
            // 
            // carId
            // 
            this.carId.Location = new System.Drawing.Point(187, 333);
            this.carId.Name = "carId";
            this.carId.Size = new System.Drawing.Size(100, 20);
            this.carId.TabIndex = 4;
            // 
            // deleteCarByID
            // 
            this.deleteCarByID.Location = new System.Drawing.Point(12, 380);
            this.deleteCarByID.Name = "deleteCarByID";
            this.deleteCarByID.Size = new System.Drawing.Size(147, 42);
            this.deleteCarByID.TabIndex = 5;
            this.deleteCarByID.Text = "Удалить машину по ID";
            this.deleteCarByID.UseVisualStyleBackColor = true;
            this.deleteCarByID.Click += new System.EventHandler(this.deleteCarByID_Click);
            // 
            // deleteCarID
            // 
            this.deleteCarID.Location = new System.Drawing.Point(187, 392);
            this.deleteCarID.Name = "deleteCarID";
            this.deleteCarID.Size = new System.Drawing.Size(100, 20);
            this.deleteCarID.TabIndex = 6;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(517, 42);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(147, 42);
            this.update.TabIndex = 7;
            this.update.Text = "Обновить данные о машине";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // updateID
            // 
            this.updateID.Location = new System.Drawing.Point(754, 51);
            this.updateID.Name = "updateID";
            this.updateID.Size = new System.Drawing.Size(100, 20);
            this.updateID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CarID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // car_price
            // 
            this.car_price.Location = new System.Drawing.Point(757, 118);
            this.car_price.Name = "car_price";
            this.car_price.Size = new System.Drawing.Size(100, 20);
            this.car_price.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "name";
            // 
            // car_name
            // 
            this.car_name.Location = new System.Drawing.Point(757, 82);
            this.car_name.Name = "car_name";
            this.car_name.Size = new System.Drawing.Size(100, 20);
            this.car_name.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "name";
            // 
            // create_car_name
            // 
            this.create_car_name.Location = new System.Drawing.Point(757, 287);
            this.create_car_name.Name = "create_car_name";
            this.create_car_name.Size = new System.Drawing.Size(100, 20);
            this.create_car_name.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price";
            // 
            // create_car_price
            // 
            this.create_car_price.Location = new System.Drawing.Point(757, 323);
            this.create_car_price.Name = "create_car_price";
            this.create_car_price.Size = new System.Drawing.Size(100, 20);
            this.create_car_price.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "CarID";
            // 
            // create_car_id
            // 
            this.create_car_id.Location = new System.Drawing.Point(754, 256);
            this.create_car_id.Name = "create_car_id";
            this.create_car_id.Size = new System.Drawing.Size(100, 20);
            this.create_car_id.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Создать машину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.create_car_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.create_car_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.create_car_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.car_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.car_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.deleteCarID);
            this.Controls.Add(this.deleteCarByID);
            this.Controls.Add(this.carId);
            this.Controls.Add(this.getCarByIdButton);
            this.Controls.Add(this.getCarsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getCarsButton;
        private System.Windows.Forms.Button getCarByIdButton;
        private System.Windows.Forms.TextBox carId;
        private System.Windows.Forms.Button deleteCarByID;
        private System.Windows.Forms.TextBox deleteCarID;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox updateID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox car_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox car_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox create_car_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox create_car_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox create_car_id;
        private System.Windows.Forms.Button button1;
    }
}

