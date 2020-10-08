namespace Task_4
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
            this.tb_degree = new System.Windows.Forms.TextBox();
            this.tb_minute = new System.Windows.Forms.TextBox();
            this.tb_second = new System.Windows.Forms.TextBox();
            this.label_degree = new System.Windows.Forms.Label();
            this.label_minute = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_to_radian = new System.Windows.Forms.Button();
            this.label_output_1 = new System.Windows.Forms.Label();
            this.btn_result = new System.Windows.Forms.Button();
            this.label_output_2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_action = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.tb_number_multiply = new System.Windows.Forms.TextBox();
            this.btn_to_angle = new System.Windows.Forms.Button();
            this.tb_to_angle = new System.Windows.Forms.TextBox();
            this.label_to_angle = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_degree
            // 
            this.tb_degree.Location = new System.Drawing.Point(139, 42);
            this.tb_degree.Name = "tb_degree";
            this.tb_degree.Size = new System.Drawing.Size(100, 22);
            this.tb_degree.TabIndex = 0;
            // 
            // tb_minute
            // 
            this.tb_minute.Location = new System.Drawing.Point(139, 85);
            this.tb_minute.Name = "tb_minute";
            this.tb_minute.Size = new System.Drawing.Size(100, 22);
            this.tb_minute.TabIndex = 1;
            // 
            // tb_second
            // 
            this.tb_second.Location = new System.Drawing.Point(139, 127);
            this.tb_second.Name = "tb_second";
            this.tb_second.Size = new System.Drawing.Size(100, 22);
            this.tb_second.TabIndex = 2;
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Location = new System.Drawing.Point(60, 45);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(66, 17);
            this.label_degree.TabIndex = 3;
            this.label_degree.Text = "Градуси:";
            // 
            // label_minute
            // 
            this.label_minute.AutoSize = true;
            this.label_minute.Location = new System.Drawing.Point(60, 88);
            this.label_minute.Name = "label_minute";
            this.label_minute.Size = new System.Drawing.Size(68, 17);
            this.label_minute.TabIndex = 4;
            this.label_minute.Text = "Хвилини:";
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(61, 130);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(67, 17);
            this.label_second.TabIndex = 5;
            this.label_second.Text = "Секунди:";
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(108, 186);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(35, 35);
            this.btn_plus.TabIndex = 6;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(159, 186);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(35, 35);
            this.btn_minus.TabIndex = 7;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(92, 227);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(124, 48);
            this.btn_multiply.TabIndex = 8;
            this.btn_multiply.Text = "Помножити на число";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_to_radian
            // 
            this.btn_to_radian.Location = new System.Drawing.Point(92, 281);
            this.btn_to_radian.Name = "btn_to_radian";
            this.btn_to_radian.Size = new System.Drawing.Size(124, 48);
            this.btn_to_radian.TabIndex = 9;
            this.btn_to_radian.Text = "Перевести у радіани";
            this.btn_to_radian.UseVisualStyleBackColor = true;
            this.btn_to_radian.Click += new System.EventHandler(this.btn_to_radian_Click);
            // 
            // label_output_1
            // 
            this.label_output_1.AutoSize = true;
            this.label_output_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_1.Location = new System.Drawing.Point(367, 42);
            this.label_output_1.Name = "label_output_1";
            this.label_output_1.Size = new System.Drawing.Size(117, 29);
            this.label_output_1.TabIndex = 10;
            this.label_output_1.Text = "";
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(357, 184);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(137, 36);
            this.btn_result.TabIndex = 11;
            this.btn_result.Text = "Результат";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // label_output_2
            // 
            this.label_output_2.AutoSize = true;
            this.label_output_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_2.Location = new System.Drawing.Point(367, 125);
            this.label_output_2.Name = "label_output_2";
            this.label_output_2.Size = new System.Drawing.Size(117, 29);
            this.label_output_2.TabIndex = 12;
            this.label_output_2.Text = "";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_result.Location = new System.Drawing.Point(367, 233);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 29);
            this.label_result.TabIndex = 13;
            // 
            // label_action
            // 
            this.label_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_action.Location = new System.Drawing.Point(404, 78);
            this.label_action.Name = "label_action";
            this.label_action.Size = new System.Drawing.Size(25, 31);
            this.label_action.TabIndex = 0;
            this.label_action.Text = "";
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(374, 281);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(98, 28);
            this.btn_restart.TabIndex = 14;
            this.btn_restart.Text = "Оновити";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // tb_number_multiply
            // 
            this.tb_number_multiply.Location = new System.Drawing.Point(372, 125);
            this.tb_number_multiply.Name = "tb_number_multiply";
            this.tb_number_multiply.Size = new System.Drawing.Size(100, 22);
            this.tb_number_multiply.TabIndex = 15;
            // 
            // btn_to_angle
            // 
            this.btn_to_angle.Location = new System.Drawing.Point(127, 376);
            this.btn_to_angle.Name = "btn_to_angle";
            this.btn_to_angle.Size = new System.Drawing.Size(112, 47);
            this.btn_to_angle.TabIndex = 16;
            this.btn_to_angle.Text = "Перевести у кут";
            this.btn_to_angle.UseVisualStyleBackColor = true;
            this.btn_to_angle.Click += new System.EventHandler(this.btn_to_angle_Click);
            // 
            // tb_to_angle
            // 
            this.tb_to_angle.Location = new System.Drawing.Point(139, 348);
            this.tb_to_angle.Name = "tb_to_angle";
            this.tb_to_angle.Size = new System.Drawing.Size(100, 22);
            this.tb_to_angle.TabIndex = 17;
            // 
            // label_to_angle
            // 
            this.label_to_angle.AutoSize = true;
            this.label_to_angle.Location = new System.Drawing.Point(19, 351);
            this.label_to_angle.Name = "label_to_angle";
            this.label_to_angle.Size = new System.Drawing.Size(107, 17);
            this.label_to_angle.TabIndex = 18;
            this.label_to_angle.Text = "Кут в радіанах:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(498, 337);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 33);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Зберегти";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(498, 381);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(89, 36);
            this.btn_upload.TabIndex = 20;
            this.btn_upload.Text = "Відкрити";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label_to_angle);
            this.Controls.Add(this.tb_to_angle);
            this.Controls.Add(this.btn_to_angle);
            this.Controls.Add(this.tb_number_multiply);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.label_action);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_output_2);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.label_output_1);
            this.Controls.Add(this.btn_to_radian);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label_minute);
            this.Controls.Add(this.label_degree);
            this.Controls.Add(this.tb_second);
            this.Controls.Add(this.tb_minute);
            this.Controls.Add(this.tb_degree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_degree;
        private System.Windows.Forms.TextBox tb_minute;
        private System.Windows.Forms.TextBox tb_second;
        private System.Windows.Forms.Label label_degree;
        private System.Windows.Forms.Label label_minute;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_to_radian;
        private System.Windows.Forms.Label label_output_1;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label label_output_2;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_action;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.TextBox tb_number_multiply;
        private System.Windows.Forms.Button btn_to_angle;
        private System.Windows.Forms.TextBox tb_to_angle;
        private System.Windows.Forms.Label label_to_angle;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_upload;
    }
}

