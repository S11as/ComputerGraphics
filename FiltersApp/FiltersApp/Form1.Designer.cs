﻿
namespace FiltersApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повышениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеВДвиженииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьСтруктурныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеErosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размыканиеOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замыканиеClosingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.чёрнобелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.морфологияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(717, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem1,
            this.матричныеToolStripMenuItem1});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem1
            // 
            this.точечныеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem1,
            this.эффектСтеклаToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem,
            this.чёрнобелыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem});
            this.точечныеToolStripMenuItem1.Name = "точечныеToolStripMenuItem1";
            this.точечныеToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem1.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem1
            // 
            this.инверсияToolStripMenuItem1.Name = "инверсияToolStripMenuItem1";
            this.инверсияToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.инверсияToolStripMenuItem1.Text = "Инверсия";
            this.инверсияToolStripMenuItem1.Click += new System.EventHandler(this.инверсияToolStripMenuItem1_Click);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект Стекла";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.волныToolStripMenuItem.Text = "Волны";
            this.волныToolStripMenuItem.Click += new System.EventHandler(this.волныToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem1
            // 
            this.матричныеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.повышениеРезкостиToolStripMenuItem,
            this.размытиеВДвиженииToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.операторПрюиттаToolStripMenuItem});
            this.матричныеToolStripMenuItem1.Name = "матричныеToolStripMenuItem1";
            this.матричныеToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem1.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // повышениеРезкостиToolStripMenuItem
            // 
            this.повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
            this.повышениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.повышениеРезкостиToolStripMenuItem.Text = "Повышение Резкости";
            this.повышениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеРезкостиToolStripMenuItem_Click);
            // 
            // размытиеВДвиженииToolStripMenuItem
            // 
            this.размытиеВДвиженииToolStripMenuItem.Name = "размытиеВДвиженииToolStripMenuItem";
            this.размытиеВДвиженииToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.размытиеВДвиженииToolStripMenuItem.Text = "Размытие В Движении";
            this.размытиеВДвиженииToolStripMenuItem.Click += new System.EventHandler(this.размытиеВДвиженииToolStripMenuItem_Click);
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.фильтрСобеляToolStripMenuItem.Text = "Оператор Собеля";
            this.фильтрСобеляToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляToolStripMenuItem_Click);
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            this.операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            this.операторПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            this.операторПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.операторПрюиттаToolStripMenuItem_Click);
            // 
            // морфологияToolStripMenuItem
            // 
            this.морфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьСтруктурныйЭлементToolStripMenuItem,
            this.расширениеToolStripMenuItem,
            this.сужениеErosionToolStripMenuItem,
            this.размыканиеOpeningToolStripMenuItem,
            this.замыканиеClosingToolStripMenuItem,
            this.gradToolStripMenuItem});
            this.морфологияToolStripMenuItem.Name = "морфологияToolStripMenuItem";
            this.морфологияToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.морфологияToolStripMenuItem.Text = "Морфология";
            // 
            // задатьСтруктурныйЭлементToolStripMenuItem
            // 
            this.задатьСтруктурныйЭлементToolStripMenuItem.Name = "задатьСтруктурныйЭлементToolStripMenuItem";
            this.задатьСтруктурныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.задатьСтруктурныйЭлементToolStripMenuItem.Text = "Задать Структурный элемент";
            this.задатьСтруктурныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.задатьСтруктурныйЭлементToolStripMenuItem_Click);
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.расширениеToolStripMenuItem.Text = "Расширение (Diliation)";
            this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.расширениеToolStripMenuItem_Click);
            // 
            // сужениеErosionToolStripMenuItem
            // 
            this.сужениеErosionToolStripMenuItem.Name = "сужениеErosionToolStripMenuItem";
            this.сужениеErosionToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.сужениеErosionToolStripMenuItem.Text = "Сужение (Erosion)";
            this.сужениеErosionToolStripMenuItem.Click += new System.EventHandler(this.сужениеErosionToolStripMenuItem_Click);
            // 
            // размыканиеOpeningToolStripMenuItem
            // 
            this.размыканиеOpeningToolStripMenuItem.Name = "размыканиеOpeningToolStripMenuItem";
            this.размыканиеOpeningToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.размыканиеOpeningToolStripMenuItem.Text = "Размыкание (Opening)";
            this.размыканиеOpeningToolStripMenuItem.Click += new System.EventHandler(this.размыканиеOpeningToolStripMenuItem_Click);
            // 
            // замыканиеClosingToolStripMenuItem
            // 
            this.замыканиеClosingToolStripMenuItem.Name = "замыканиеClosingToolStripMenuItem";
            this.замыканиеClosingToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.замыканиеClosingToolStripMenuItem.Text = "Замыкание (Closing)";
            this.замыканиеClosingToolStripMenuItem.Click += new System.EventHandler(this.замыканиеClosingToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.gradToolStripMenuItem.Text = "Grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 484);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(553, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // чёрнобелыйToolStripMenuItem
            // 
            this.чёрнобелыйToolStripMenuItem.Name = "чёрнобелыйToolStripMenuItem";
            this.чёрнобелыйToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.чёрнобелыйToolStripMenuItem.Text = "Чёрно-белый";
            this.чёрнобелыйToolStripMenuItem.Click += new System.EventHandler(this.чёрнобелыйToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повышениеРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеВДвиженииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem морфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеErosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размыканиеOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замыканиеClosingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьСтруктурныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чёрнобелыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
    }
}

