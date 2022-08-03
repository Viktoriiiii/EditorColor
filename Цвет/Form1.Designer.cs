namespace Цвет
{
    partial class FormColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColor));
            this.panelPict = new System.Windows.Forms.Panel();
            this.pictureBoxPict = new System.Windows.Forms.PictureBox();
            this.menuStripEditor = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осветлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затемнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовойШумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсинениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подкраснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мозаикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйБезИзмененияКрасногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.textBoxTrans = new System.Windows.Forms.TextBox();
            this.trackBarTrans = new System.Windows.Forms.TrackBar();
            this.labelTrans = new System.Windows.Forms.Label();
            this.labelDesire = new System.Windows.Forms.Label();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFlipLeftRight = new System.Windows.Forms.Button();
            this.buttonFlipTopBottom = new System.Windows.Forms.Button();
            this.buttonCounterClockwise = new System.Windows.Forms.Button();
            this.buttonClockwise = new System.Windows.Forms.Button();
            this.buttonOriginal = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.labelAdmit = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.textBoxAdmit = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.trackBarAdmit = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.textBoxDesire = new System.Windows.Forms.TextBox();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.pictureBoxDesire = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.buttonPalette = new System.Windows.Forms.Button();
            this.buttonRecolor = new System.Windows.Forms.Button();
            this.colorDialogEditor = new System.Windows.Forms.ColorDialog();
            this.panelPict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPict)).BeginInit();
            this.menuStripEditor.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAdmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPict
            // 
            this.panelPict.AutoScroll = true;
            this.panelPict.Controls.Add(this.pictureBoxPict);
            this.panelPict.Location = new System.Drawing.Point(12, 12);
            this.panelPict.Name = "panelPict";
            this.panelPict.Size = new System.Drawing.Size(533, 467);
            this.panelPict.TabIndex = 0;
            // 
            // pictureBoxPict
            // 
            this.pictureBoxPict.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPict.Image")));
            this.pictureBoxPict.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPict.Name = "pictureBoxPict";
            this.pictureBoxPict.Size = new System.Drawing.Size(291, 400);
            this.pictureBoxPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPict.TabIndex = 0;
            this.pictureBoxPict.TabStop = false;
            this.pictureBoxPict.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPict_MouseClick);
            // 
            // menuStripEditor
            // 
            this.menuStripEditor.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.эффектыToolStripMenuItem});
            this.menuStripEditor.Location = new System.Drawing.Point(9, 9);
            this.menuStripEditor.Name = "menuStripEditor";
            this.menuStripEditor.Size = new System.Drawing.Size(126, 24);
            this.menuStripEditor.TabIndex = 1;
            this.menuStripEditor.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // эффектыToolStripMenuItem
            // 
            this.эффектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чернобелыйToolStripMenuItem,
            this.негативToolStripMenuItem,
            this.осветлениеToolStripMenuItem,
            this.затемнениеToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.цветовойШумToolStripMenuItem,
            this.подсинениеToolStripMenuItem,
            this.подкраснениеToolStripMenuItem,
            this.мозаикаToolStripMenuItem,
            this.размытиеToolStripMenuItem,
            this.чернобелыйБезИзмененияКрасногоToolStripMenuItem});
            this.эффектыToolStripMenuItem.Name = "эффектыToolStripMenuItem";
            this.эффектыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.эффектыToolStripMenuItem.Text = "Эффекты";
            // 
            // чернобелыйToolStripMenuItem
            // 
            this.чернобелыйToolStripMenuItem.Name = "чернобелыйToolStripMenuItem";
            this.чернобелыйToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.чернобелыйToolStripMenuItem.Text = "Черно-белый";
            this.чернобелыйToolStripMenuItem.Click += new System.EventHandler(this.чернобелыйToolStripMenuItem_Click);
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            this.негативToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.негативToolStripMenuItem.Text = "Негатив";
            this.негативToolStripMenuItem.Click += new System.EventHandler(this.негативToolStripMenuItem_Click);
            // 
            // осветлениеToolStripMenuItem
            // 
            this.осветлениеToolStripMenuItem.Name = "осветлениеToolStripMenuItem";
            this.осветлениеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.осветлениеToolStripMenuItem.Text = "Осветление";
            this.осветлениеToolStripMenuItem.Click += new System.EventHandler(this.осветлениеToolStripMenuItem_Click);
            // 
            // затемнениеToolStripMenuItem
            // 
            this.затемнениеToolStripMenuItem.Name = "затемнениеToolStripMenuItem";
            this.затемнениеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.затемнениеToolStripMenuItem.Text = "Затемнение";
            this.затемнениеToolStripMenuItem.Click += new System.EventHandler(this.затемнениеToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // цветовойШумToolStripMenuItem
            // 
            this.цветовойШумToolStripMenuItem.Name = "цветовойШумToolStripMenuItem";
            this.цветовойШумToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.цветовойШумToolStripMenuItem.Text = "Цветовой шум";
            this.цветовойШумToolStripMenuItem.Click += new System.EventHandler(this.цветовойШумToolStripMenuItem_Click);
            // 
            // подсинениеToolStripMenuItem
            // 
            this.подсинениеToolStripMenuItem.Name = "подсинениеToolStripMenuItem";
            this.подсинениеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.подсинениеToolStripMenuItem.Text = "Подсинение";
            this.подсинениеToolStripMenuItem.Click += new System.EventHandler(this.подсинениеToolStripMenuItem_Click);
            // 
            // подкраснениеToolStripMenuItem
            // 
            this.подкраснениеToolStripMenuItem.Name = "подкраснениеToolStripMenuItem";
            this.подкраснениеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.подкраснениеToolStripMenuItem.Text = "Подкраснение";
            this.подкраснениеToolStripMenuItem.Click += new System.EventHandler(this.подкраснениеToolStripMenuItem_Click);
            // 
            // мозаикаToolStripMenuItem
            // 
            this.мозаикаToolStripMenuItem.Name = "мозаикаToolStripMenuItem";
            this.мозаикаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.мозаикаToolStripMenuItem.Text = "Мозаика";
            this.мозаикаToolStripMenuItem.Click += new System.EventHandler(this.мозаикаToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // чернобелыйБезИзмененияКрасногоToolStripMenuItem
            // 
            this.чернобелыйБезИзмененияКрасногоToolStripMenuItem.Name = "чернобелыйБезИзмененияКрасногоToolStripMenuItem";
            this.чернобелыйБезИзмененияКрасногоToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.чернобелыйБезИзмененияКрасногоToolStripMenuItem.Text = "Черно-белый без изменения красного";
            this.чернобелыйБезИзмененияКрасногоToolStripMenuItem.Click += new System.EventHandler(this.чернобелыйБезИзмененияКрасногоToolStripMenuItem_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.textBoxTrans);
            this.panelControl.Controls.Add(this.trackBarTrans);
            this.panelControl.Controls.Add(this.labelTrans);
            this.panelControl.Controls.Add(this.labelDesire);
            this.panelControl.Controls.Add(this.labelOriginal);
            this.panelControl.Controls.Add(this.buttonClear);
            this.panelControl.Controls.Add(this.buttonFlipLeftRight);
            this.panelControl.Controls.Add(this.buttonFlipTopBottom);
            this.panelControl.Controls.Add(this.buttonCounterClockwise);
            this.panelControl.Controls.Add(this.buttonClockwise);
            this.panelControl.Controls.Add(this.buttonOriginal);
            this.panelControl.Controls.Add(this.buttonDecrease);
            this.panelControl.Controls.Add(this.buttonIncrease);
            this.panelControl.Controls.Add(this.labelAdmit);
            this.panelControl.Controls.Add(this.labelBlue);
            this.panelControl.Controls.Add(this.labelGreen);
            this.panelControl.Controls.Add(this.labelRed);
            this.panelControl.Controls.Add(this.textBoxAdmit);
            this.panelControl.Controls.Add(this.textBoxBlue);
            this.panelControl.Controls.Add(this.textBoxGreen);
            this.panelControl.Controls.Add(this.textBoxRed);
            this.panelControl.Controls.Add(this.trackBarAdmit);
            this.panelControl.Controls.Add(this.trackBarBlue);
            this.panelControl.Controls.Add(this.trackBarGreen);
            this.panelControl.Controls.Add(this.trackBarRed);
            this.panelControl.Controls.Add(this.textBoxDesire);
            this.panelControl.Controls.Add(this.textBoxOriginal);
            this.panelControl.Controls.Add(this.pictureBoxDesire);
            this.panelControl.Controls.Add(this.pictureBoxOriginal);
            this.panelControl.Controls.Add(this.buttonPalette);
            this.panelControl.Controls.Add(this.buttonRecolor);
            this.panelControl.Location = new System.Drawing.Point(551, 12);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(462, 467);
            this.panelControl.TabIndex = 1;
            // 
            // textBoxTrans
            // 
            this.textBoxTrans.Location = new System.Drawing.Point(385, 353);
            this.textBoxTrans.MaxLength = 3;
            this.textBoxTrans.Name = "textBoxTrans";
            this.textBoxTrans.Size = new System.Drawing.Size(62, 20);
            this.textBoxTrans.TabIndex = 30;
            this.textBoxTrans.Text = "1";
            this.textBoxTrans.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // trackBarTrans
            // 
            this.trackBarTrans.Location = new System.Drawing.Point(126, 353);
            this.trackBarTrans.Maximum = 255;
            this.trackBarTrans.Name = "trackBarTrans";
            this.trackBarTrans.Size = new System.Drawing.Size(253, 45);
            this.trackBarTrans.TabIndex = 29;
            this.trackBarTrans.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrans.Location = new System.Drawing.Point(54, 357);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(66, 12);
            this.labelTrans.TabIndex = 28;
            this.labelTrans.Text = "Прозрачность";
            // 
            // labelDesire
            // 
            this.labelDesire.AutoSize = true;
            this.labelDesire.Location = new System.Drawing.Point(363, 10);
            this.labelDesire.Name = "labelDesire";
            this.labelDesire.Size = new System.Drawing.Size(90, 13);
            this.labelDesire.TabIndex = 27;
            this.labelDesire.Text = "Желаемый цвет";
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(68, 10);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(84, 13);
            this.labelOriginal.TabIndex = 26;
            this.labelOriginal.Text = "Исходный цвет";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(14, 425);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(31, 32);
            this.buttonClear.TabIndex = 25;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFlipLeftRight
            // 
            this.buttonFlipLeftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlipLeftRight.Location = new System.Drawing.Point(14, 366);
            this.buttonFlipLeftRight.Name = "buttonFlipLeftRight";
            this.buttonFlipLeftRight.Size = new System.Drawing.Size(31, 32);
            this.buttonFlipLeftRight.TabIndex = 24;
            this.buttonFlipLeftRight.Text = "⇔";
            this.buttonFlipLeftRight.UseVisualStyleBackColor = true;
            this.buttonFlipLeftRight.Click += new System.EventHandler(this.buttonFlipLeftRight_Click);
            // 
            // buttonFlipTopBottom
            // 
            this.buttonFlipTopBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFlipTopBottom.Location = new System.Drawing.Point(14, 307);
            this.buttonFlipTopBottom.Name = "buttonFlipTopBottom";
            this.buttonFlipTopBottom.Size = new System.Drawing.Size(31, 32);
            this.buttonFlipTopBottom.TabIndex = 23;
            this.buttonFlipTopBottom.Text = "⇕";
            this.buttonFlipTopBottom.UseVisualStyleBackColor = true;
            this.buttonFlipTopBottom.Click += new System.EventHandler(this.buttonFlipTopBottom_Click);
            // 
            // buttonCounterClockwise
            // 
            this.buttonCounterClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCounterClockwise.Location = new System.Drawing.Point(14, 242);
            this.buttonCounterClockwise.Name = "buttonCounterClockwise";
            this.buttonCounterClockwise.Size = new System.Drawing.Size(31, 32);
            this.buttonCounterClockwise.TabIndex = 22;
            this.buttonCounterClockwise.Text = "↺";
            this.buttonCounterClockwise.UseVisualStyleBackColor = true;
            this.buttonCounterClockwise.Click += new System.EventHandler(this.buttonCounterClockwise_Click);
            // 
            // buttonClockwise
            // 
            this.buttonClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClockwise.Location = new System.Drawing.Point(14, 183);
            this.buttonClockwise.Name = "buttonClockwise";
            this.buttonClockwise.Size = new System.Drawing.Size(31, 32);
            this.buttonClockwise.TabIndex = 21;
            this.buttonClockwise.Text = "↻";
            this.buttonClockwise.UseVisualStyleBackColor = true;
            this.buttonClockwise.Click += new System.EventHandler(this.buttonClockwise_Click);
            // 
            // buttonOriginal
            // 
            this.buttonOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOriginal.Location = new System.Drawing.Point(14, 122);
            this.buttonOriginal.Name = "buttonOriginal";
            this.buttonOriginal.Size = new System.Drawing.Size(31, 32);
            this.buttonOriginal.TabIndex = 20;
            this.buttonOriginal.Text = "⌂";
            this.buttonOriginal.UseVisualStyleBackColor = true;
            this.buttonOriginal.Click += new System.EventHandler(this.buttonOriginal_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.Location = new System.Drawing.Point(14, 63);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(31, 32);
            this.buttonDecrease.TabIndex = 19;
            this.buttonDecrease.Text = "—";
            this.buttonDecrease.UseVisualStyleBackColor = true;
            this.buttonDecrease.Click += new System.EventHandler(this.buttonDecrease_Click);
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.Location = new System.Drawing.Point(14, 10);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(31, 32);
            this.buttonIncrease.TabIndex = 18;
            this.buttonIncrease.Text = "+";
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // labelAdmit
            // 
            this.labelAdmit.AutoSize = true;
            this.labelAdmit.Location = new System.Drawing.Point(68, 422);
            this.labelAdmit.Name = "labelAdmit";
            this.labelAdmit.Size = new System.Drawing.Size(45, 13);
            this.labelAdmit.TabIndex = 17;
            this.labelAdmit.Text = "Допуск";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(68, 301);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(38, 13);
            this.labelBlue.TabIndex = 16;
            this.labelBlue.Text = "Синий";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(68, 236);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(52, 13);
            this.labelGreen.TabIndex = 15;
            this.labelGreen.Text = "Зеленый";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(68, 171);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(52, 13);
            this.labelRed.TabIndex = 14;
            this.labelRed.Text = "Красный";
            // 
            // textBoxAdmit
            // 
            this.textBoxAdmit.Location = new System.Drawing.Point(385, 415);
            this.textBoxAdmit.MaxLength = 3;
            this.textBoxAdmit.Name = "textBoxAdmit";
            this.textBoxAdmit.Size = new System.Drawing.Size(62, 20);
            this.textBoxAdmit.TabIndex = 13;
            this.textBoxAdmit.Text = "1";
            this.textBoxAdmit.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxAdmit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(385, 294);
            this.textBoxBlue.MaxLength = 3;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(62, 20);
            this.textBoxBlue.TabIndex = 12;
            this.textBoxBlue.Text = "1";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(385, 229);
            this.textBoxGreen.MaxLength = 3;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(62, 20);
            this.textBoxGreen.TabIndex = 11;
            this.textBoxGreen.Text = "1";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(385, 170);
            this.textBoxRed.MaxLength = 3;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(62, 20);
            this.textBoxRed.TabIndex = 10;
            this.textBoxRed.Text = "1";
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRed_KeyPress);
            // 
            // trackBarAdmit
            // 
            this.trackBarAdmit.Location = new System.Drawing.Point(126, 415);
            this.trackBarAdmit.Maximum = 100;
            this.trackBarAdmit.Name = "trackBarAdmit";
            this.trackBarAdmit.Size = new System.Drawing.Size(253, 45);
            this.trackBarAdmit.TabIndex = 9;
            this.trackBarAdmit.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(126, 294);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(253, 45);
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(126, 229);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(253, 45);
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(126, 170);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(253, 45);
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // textBoxDesire
            // 
            this.textBoxDesire.Location = new System.Drawing.Point(283, 122);
            this.textBoxDesire.Name = "textBoxDesire";
            this.textBoxDesire.ReadOnly = true;
            this.textBoxDesire.Size = new System.Drawing.Size(170, 20);
            this.textBoxDesire.TabIndex = 5;
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(71, 122);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.ReadOnly = true;
            this.textBoxOriginal.Size = new System.Drawing.Size(170, 20);
            this.textBoxOriginal.TabIndex = 4;
            // 
            // pictureBoxDesire
            // 
            this.pictureBoxDesire.Location = new System.Drawing.Point(391, 41);
            this.pictureBoxDesire.Name = "pictureBoxDesire";
            this.pictureBoxDesire.Size = new System.Drawing.Size(62, 56);
            this.pictureBoxDesire.TabIndex = 3;
            this.pictureBoxDesire.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(71, 41);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(62, 56);
            this.pictureBoxOriginal.TabIndex = 2;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // buttonPalette
            // 
            this.buttonPalette.Location = new System.Drawing.Point(283, 41);
            this.buttonPalette.Name = "buttonPalette";
            this.buttonPalette.Size = new System.Drawing.Size(87, 56);
            this.buttonPalette.TabIndex = 1;
            this.buttonPalette.Text = "Палитра";
            this.buttonPalette.UseVisualStyleBackColor = true;
            this.buttonPalette.Click += new System.EventHandler(this.buttonPalette_Click);
            // 
            // buttonRecolor
            // 
            this.buttonRecolor.Location = new System.Drawing.Point(154, 41);
            this.buttonRecolor.Name = "buttonRecolor";
            this.buttonRecolor.Size = new System.Drawing.Size(87, 56);
            this.buttonRecolor.TabIndex = 0;
            this.buttonRecolor.Text = "Перекрасить";
            this.buttonRecolor.UseVisualStyleBackColor = true;
            this.buttonRecolor.Click += new System.EventHandler(this.buttonRecolor_Click);
            // 
            // FormColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 491);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStripEditor);
            this.Controls.Add(this.panelPict);
            this.MainMenuStrip = this.menuStripEditor;
            this.Name = "FormColor";
            this.Text = "Редактор цвета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormColor_FormClosing);
            this.Load += new System.EventHandler(this.FormColor_Load);
            this.panelPict.ResumeLayout(false);
            this.panelPict.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPict)).EndInit();
            this.menuStripEditor.ResumeLayout(false);
            this.menuStripEditor.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAdmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPict;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox pictureBoxPict;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFlipLeftRight;
        private System.Windows.Forms.Button buttonFlipTopBottom;
        private System.Windows.Forms.Button buttonCounterClockwise;
        private System.Windows.Forms.Button buttonClockwise;
        private System.Windows.Forms.Button buttonOriginal;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.Label labelAdmit;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.TextBox textBoxAdmit;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TrackBar trackBarAdmit;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TextBox textBoxDesire;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxDesire;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Button buttonPalette;
        private System.Windows.Forms.Button buttonRecolor;
        private System.Windows.Forms.Label labelDesire;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.MenuStrip menuStripEditor;
        private System.Windows.Forms.ColorDialog colorDialogEditor;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTrans;
        private System.Windows.Forms.TrackBar trackBarTrans;
        private System.Windows.Forms.Label labelTrans;
        private System.Windows.Forms.ToolStripMenuItem эффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осветлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затемнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовойШумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсинениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подкраснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мозаикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйБезИзмененияКрасногоToolStripMenuItem;
    }
}

