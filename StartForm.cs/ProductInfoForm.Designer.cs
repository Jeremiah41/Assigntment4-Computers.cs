namespace StartForm.cs
{
    partial class ProductInfoForm
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
            this.GroupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.TextBoxOS = new System.Windows.Forms.TextBox();
            this.TextBoxManufacturer = new System.Windows.Forms.TextBox();
            this.TextBoxPlatform = new System.Windows.Forms.TextBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelOS = new System.Windows.Forms.Label();
            this.LabelManufacturer = new System.Windows.Forms.Label();
            this.LabelPlatform = new System.Windows.Forms.Label();
            this.GroupBoxTechSpecs = new System.Windows.Forms.GroupBox();
            this.TextBoxWebcam = new System.Windows.Forms.TextBox();
            this.TextBoxGPU = new System.Windows.Forms.TextBox();
            this.TextBoxHDD = new System.Windows.Forms.TextBox();
            this.TextBoxCPUSpeed = new System.Windows.Forms.TextBox();
            this.TextBoxCPUType = new System.Windows.Forms.TextBox();
            this.TextBoxLCD = new System.Windows.Forms.TextBox();
            this.TextBoxCPUBrand = new System.Windows.Forms.TextBox();
            this.TextBoxCPUNumber = new System.Windows.Forms.TextBox();
            this.TextBoxMemory = new System.Windows.Forms.TextBox();
            this.LabelHDD = new System.Windows.Forms.Label();
            this.LabelGPUType = new System.Windows.Forms.Label();
            this.LabelWebCam = new System.Windows.Forms.Label();
            this.LabelLCDSize = new System.Windows.Forms.Label();
            this.LabelCPUNumber = new System.Windows.Forms.Label();
            this.LabelCPUSpeed = new System.Windows.Forms.Label();
            this.LabelCPUType = new System.Windows.Forms.Label();
            this.LabelCPUBrand = new System.Windows.Forms.Label();
            this.LabelMemory = new System.Windows.Forms.Label();
            this.LabelCondition = new System.Windows.Forms.Label();
            this.LabelProductID = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxProductID = new System.Windows.Forms.TextBox();
            this.TextBoxCondition = new System.Windows.Forms.TextBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.ButtonSelectAnotherProduct = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.MenuStripProductInfoForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxProductInfo.SuspendLayout();
            this.GroupBoxTechSpecs.SuspendLayout();
            this.MenuStripProductInfoForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxProductInfo
            // 
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxModel);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxOS);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxManufacturer);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxPlatform);
            this.GroupBoxProductInfo.Controls.Add(this.LabelModel);
            this.GroupBoxProductInfo.Controls.Add(this.LabelOS);
            this.GroupBoxProductInfo.Controls.Add(this.LabelManufacturer);
            this.GroupBoxProductInfo.Controls.Add(this.LabelPlatform);
            this.GroupBoxProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxProductInfo.Location = new System.Drawing.Point(22, 122);
            this.GroupBoxProductInfo.Name = "GroupBoxProductInfo";
            this.GroupBoxProductInfo.Size = new System.Drawing.Size(832, 100);
            this.GroupBoxProductInfo.TabIndex = 0;
            this.GroupBoxProductInfo.TabStop = false;
            this.GroupBoxProductInfo.Text = "Product Info";
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxModel.Location = new System.Drawing.Point(410, 60);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(406, 26);
            this.TextBoxModel.TabIndex = 25;
            // 
            // TextBoxOS
            // 
            this.TextBoxOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOS.Location = new System.Drawing.Point(410, 19);
            this.TextBoxOS.Name = "TextBoxOS";
            this.TextBoxOS.Size = new System.Drawing.Size(406, 26);
            this.TextBoxOS.TabIndex = 24;
            this.TextBoxOS.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // TextBoxManufacturer
            // 
            this.TextBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxManufacturer.Location = new System.Drawing.Point(133, 60);
            this.TextBoxManufacturer.Name = "TextBoxManufacturer";
            this.TextBoxManufacturer.Size = new System.Drawing.Size(201, 26);
            this.TextBoxManufacturer.TabIndex = 23;
            // 
            // TextBoxPlatform
            // 
            this.TextBoxPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPlatform.Location = new System.Drawing.Point(133, 19);
            this.TextBoxPlatform.Name = "TextBoxPlatform";
            this.TextBoxPlatform.Size = new System.Drawing.Size(201, 26);
            this.TextBoxPlatform.TabIndex = 22;
            this.TextBoxPlatform.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModel.Location = new System.Drawing.Point(347, 60);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(57, 20);
            this.LabelModel.TabIndex = 7;
            this.LabelModel.Text = "Model";
            // 
            // LabelOS
            // 
            this.LabelOS.AutoSize = true;
            this.LabelOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOS.Location = new System.Drawing.Point(370, 19);
            this.LabelOS.Name = "LabelOS";
            this.LabelOS.Size = new System.Drawing.Size(34, 20);
            this.LabelOS.TabIndex = 6;
            this.LabelOS.Text = "OS";
            // 
            // LabelManufacturer
            // 
            this.LabelManufacturer.AutoSize = true;
            this.LabelManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManufacturer.Location = new System.Drawing.Point(3, 60);
            this.LabelManufacturer.Name = "LabelManufacturer";
            this.LabelManufacturer.Size = new System.Drawing.Size(116, 20);
            this.LabelManufacturer.TabIndex = 5;
            this.LabelManufacturer.Text = "Manufacturer";
            // 
            // LabelPlatform
            // 
            this.LabelPlatform.AutoSize = true;
            this.LabelPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlatform.Location = new System.Drawing.Point(43, 19);
            this.LabelPlatform.Name = "LabelPlatform";
            this.LabelPlatform.Size = new System.Drawing.Size(76, 20);
            this.LabelPlatform.TabIndex = 4;
            this.LabelPlatform.Text = "Platform";
            // 
            // GroupBoxTechSpecs
            // 
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxWebcam);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxGPU);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxHDD);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxCPUSpeed);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxCPUType);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxLCD);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxCPUBrand);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxCPUNumber);
            this.GroupBoxTechSpecs.Controls.Add(this.TextBoxMemory);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelHDD);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelGPUType);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelWebCam);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelLCDSize);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUNumber);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUSpeed);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUType);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelCPUBrand);
            this.GroupBoxTechSpecs.Controls.Add(this.LabelMemory);
            this.GroupBoxTechSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxTechSpecs.Location = new System.Drawing.Point(22, 260);
            this.GroupBoxTechSpecs.Name = "GroupBoxTechSpecs";
            this.GroupBoxTechSpecs.Size = new System.Drawing.Size(832, 184);
            this.GroupBoxTechSpecs.TabIndex = 0;
            this.GroupBoxTechSpecs.TabStop = false;
            this.GroupBoxTechSpecs.Text = "Tech Specs";
            // 
            // TextBoxWebcam
            // 
            this.TextBoxWebcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWebcam.Location = new System.Drawing.Point(534, 128);
            this.TextBoxWebcam.Name = "TextBoxWebcam";
            this.TextBoxWebcam.Size = new System.Drawing.Size(282, 26);
            this.TextBoxWebcam.TabIndex = 33;
            // 
            // TextBoxGPU
            // 
            this.TextBoxGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGPU.Location = new System.Drawing.Point(534, 86);
            this.TextBoxGPU.Name = "TextBoxGPU";
            this.TextBoxGPU.Size = new System.Drawing.Size(282, 26);
            this.TextBoxGPU.TabIndex = 32;
            // 
            // TextBoxHDD
            // 
            this.TextBoxHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHDD.Location = new System.Drawing.Point(534, 43);
            this.TextBoxHDD.Name = "TextBoxHDD";
            this.TextBoxHDD.Size = new System.Drawing.Size(282, 26);
            this.TextBoxHDD.TabIndex = 31;
            // 
            // TextBoxCPUSpeed
            // 
            this.TextBoxCPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCPUSpeed.Location = new System.Drawing.Point(332, 128);
            this.TextBoxCPUSpeed.Name = "TextBoxCPUSpeed";
            this.TextBoxCPUSpeed.Size = new System.Drawing.Size(100, 26);
            this.TextBoxCPUSpeed.TabIndex = 30;
            // 
            // TextBoxCPUType
            // 
            this.TextBoxCPUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCPUType.Location = new System.Drawing.Point(106, 128);
            this.TextBoxCPUType.Name = "TextBoxCPUType";
            this.TextBoxCPUType.Size = new System.Drawing.Size(100, 26);
            this.TextBoxCPUType.TabIndex = 29;
            this.TextBoxCPUType.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // TextBoxLCD
            // 
            this.TextBoxLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLCD.Location = new System.Drawing.Point(332, 43);
            this.TextBoxLCD.Name = "TextBoxLCD";
            this.TextBoxLCD.Size = new System.Drawing.Size(100, 26);
            this.TextBoxLCD.TabIndex = 28;
            // 
            // TextBoxCPUBrand
            // 
            this.TextBoxCPUBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCPUBrand.Location = new System.Drawing.Point(106, 86);
            this.TextBoxCPUBrand.Name = "TextBoxCPUBrand";
            this.TextBoxCPUBrand.Size = new System.Drawing.Size(100, 26);
            this.TextBoxCPUBrand.TabIndex = 27;
            this.TextBoxCPUBrand.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // TextBoxCPUNumber
            // 
            this.TextBoxCPUNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCPUNumber.Location = new System.Drawing.Point(332, 86);
            this.TextBoxCPUNumber.Name = "TextBoxCPUNumber";
            this.TextBoxCPUNumber.Size = new System.Drawing.Size(100, 26);
            this.TextBoxCPUNumber.TabIndex = 27;
            // 
            // TextBoxMemory
            // 
            this.TextBoxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMemory.Location = new System.Drawing.Point(106, 43);
            this.TextBoxMemory.Name = "TextBoxMemory";
            this.TextBoxMemory.Size = new System.Drawing.Size(100, 26);
            this.TextBoxMemory.TabIndex = 26;
            this.TextBoxMemory.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // LabelHDD
            // 
            this.LabelHDD.AutoSize = true;
            this.LabelHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHDD.Location = new System.Drawing.Point(480, 43);
            this.LabelHDD.Name = "LabelHDD";
            this.LabelHDD.Size = new System.Drawing.Size(48, 20);
            this.LabelHDD.TabIndex = 17;
            this.LabelHDD.Text = "HDD";
            // 
            // LabelGPUType
            // 
            this.LabelGPUType.AutoSize = true;
            this.LabelGPUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGPUType.Location = new System.Drawing.Point(438, 86);
            this.LabelGPUType.Name = "LabelGPUType";
            this.LabelGPUType.Size = new System.Drawing.Size(90, 20);
            this.LabelGPUType.TabIndex = 16;
            this.LabelGPUType.Text = "GPU Type";
            // 
            // LabelWebCam
            // 
            this.LabelWebCam.AutoSize = true;
            this.LabelWebCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWebCam.Location = new System.Drawing.Point(447, 128);
            this.LabelWebCam.Name = "LabelWebCam";
            this.LabelWebCam.Size = new System.Drawing.Size(81, 20);
            this.LabelWebCam.TabIndex = 15;
            this.LabelWebCam.Text = "WebCam";
            // 
            // LabelLCDSize
            // 
            this.LabelLCDSize.AutoSize = true;
            this.LabelLCDSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLCDSize.Location = new System.Drawing.Point(242, 43);
            this.LabelLCDSize.Name = "LabelLCDSize";
            this.LabelLCDSize.Size = new System.Drawing.Size(84, 20);
            this.LabelLCDSize.TabIndex = 14;
            this.LabelLCDSize.Text = "LCD Size";
            // 
            // LabelCPUNumber
            // 
            this.LabelCPUNumber.AutoSize = true;
            this.LabelCPUNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCPUNumber.Location = new System.Drawing.Point(214, 86);
            this.LabelCPUNumber.Name = "LabelCPUNumber";
            this.LabelCPUNumber.Size = new System.Drawing.Size(112, 20);
            this.LabelCPUNumber.TabIndex = 13;
            this.LabelCPUNumber.Text = "CPU Number";
            // 
            // LabelCPUSpeed
            // 
            this.LabelCPUSpeed.AutoSize = true;
            this.LabelCPUSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCPUSpeed.Location = new System.Drawing.Point(224, 128);
            this.LabelCPUSpeed.Name = "LabelCPUSpeed";
            this.LabelCPUSpeed.Size = new System.Drawing.Size(102, 20);
            this.LabelCPUSpeed.TabIndex = 12;
            this.LabelCPUSpeed.Text = "CPU Speed";
            // 
            // LabelCPUType
            // 
            this.LabelCPUType.AutoSize = true;
            this.LabelCPUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCPUType.Location = new System.Drawing.Point(12, 128);
            this.LabelCPUType.Name = "LabelCPUType";
            this.LabelCPUType.Size = new System.Drawing.Size(88, 20);
            this.LabelCPUType.TabIndex = 10;
            this.LabelCPUType.Text = "CPU Type";
            // 
            // LabelCPUBrand
            // 
            this.LabelCPUBrand.AutoSize = true;
            this.LabelCPUBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCPUBrand.Location = new System.Drawing.Point(2, 86);
            this.LabelCPUBrand.Name = "LabelCPUBrand";
            this.LabelCPUBrand.Size = new System.Drawing.Size(98, 20);
            this.LabelCPUBrand.TabIndex = 9;
            this.LabelCPUBrand.Text = "CPU Brand";
            // 
            // LabelMemory
            // 
            this.LabelMemory.AutoSize = true;
            this.LabelMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMemory.Location = new System.Drawing.Point(29, 43);
            this.LabelMemory.Name = "LabelMemory";
            this.LabelMemory.Size = new System.Drawing.Size(71, 20);
            this.LabelMemory.TabIndex = 8;
            this.LabelMemory.Text = "Memory";
            // 
            // LabelCondition
            // 
            this.LabelCondition.AutoSize = true;
            this.LabelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCondition.Location = new System.Drawing.Point(305, 52);
            this.LabelCondition.Name = "LabelCondition";
            this.LabelCondition.Size = new System.Drawing.Size(85, 20);
            this.LabelCondition.TabIndex = 1;
            this.LabelCondition.Text = "Condition";
            // 
            // LabelProductID
            // 
            this.LabelProductID.AutoSize = true;
            this.LabelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductID.Location = new System.Drawing.Point(34, 52);
            this.LabelProductID.Name = "LabelProductID";
            this.LabelProductID.Size = new System.Drawing.Size(95, 20);
            this.LabelProductID.TabIndex = 2;
            this.LabelProductID.Text = "Product ID";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCost.Location = new System.Drawing.Point(552, 52);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(46, 20);
            this.LabelCost.TabIndex = 3;
            this.LabelCost.Text = "Cost";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 482);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(299, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Click Next to Confirm Your Selection";
            // 
            // TextBoxProductID
            // 
            this.TextBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProductID.Location = new System.Drawing.Point(140, 52);
            this.TextBoxProductID.Name = "TextBoxProductID";
            this.TextBoxProductID.Size = new System.Drawing.Size(128, 26);
            this.TextBoxProductID.TabIndex = 19;
            this.TextBoxProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxCondition
            // 
            this.TextBoxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCondition.Location = new System.Drawing.Point(396, 52);
            this.TextBoxCondition.Name = "TextBoxCondition";
            this.TextBoxCondition.Size = new System.Drawing.Size(128, 26);
            this.TextBoxCondition.TabIndex = 20;
            this.TextBoxCondition.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCost.Location = new System.Drawing.Point(609, 52);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.Size = new System.Drawing.Size(128, 26);
            this.TextBoxCost.TabIndex = 21;
            this.TextBoxCost.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ButtonSelectAnotherProduct
            // 
            this.ButtonSelectAnotherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectAnotherProduct.Location = new System.Drawing.Point(450, 472);
            this.ButtonSelectAnotherProduct.Name = "ButtonSelectAnotherProduct";
            this.ButtonSelectAnotherProduct.Size = new System.Drawing.Size(177, 33);
            this.ButtonSelectAnotherProduct.TabIndex = 22;
            this.ButtonSelectAnotherProduct.Text = "Select Another Product";
            this.ButtonSelectAnotherProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(645, 472);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(87, 33);
            this.ButtonCancel.TabIndex = 23;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(750, 472);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(87, 33);
            this.ButtonNext.TabIndex = 24;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            // 
            // MenuStripProductInfoForm
            // 
            this.MenuStripProductInfoForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MenuStripProductInfoForm.Location = new System.Drawing.Point(0, 0);
            this.MenuStripProductInfoForm.Name = "MenuStripProductInfoForm";
            this.MenuStripProductInfoForm.Size = new System.Drawing.Size(866, 24);
            this.MenuStripProductInfoForm.TabIndex = 26;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(866, 529);
            this.Controls.Add(this.MenuStripProductInfoForm);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSelectAnotherProduct);
            this.Controls.Add(this.TextBoxCost);
            this.Controls.Add(this.TextBoxCondition);
            this.Controls.Add(this.TextBoxProductID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelProductID);
            this.Controls.Add(this.LabelCondition);
            this.Controls.Add(this.GroupBoxTechSpecs);
            this.Controls.Add(this.GroupBoxProductInfo);
            this.MainMenuStrip = this.MenuStripProductInfoForm;
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.GroupBoxProductInfo.ResumeLayout(false);
            this.GroupBoxProductInfo.PerformLayout();
            this.GroupBoxTechSpecs.ResumeLayout(false);
            this.GroupBoxTechSpecs.PerformLayout();
            this.MenuStripProductInfoForm.ResumeLayout(false);
            this.MenuStripProductInfoForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxProductInfo;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.TextBox TextBoxOS;
        private System.Windows.Forms.TextBox TextBoxManufacturer;
        private System.Windows.Forms.TextBox TextBoxPlatform;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelOS;
        private System.Windows.Forms.Label LabelManufacturer;
        private System.Windows.Forms.Label LabelPlatform;
        private System.Windows.Forms.GroupBox GroupBoxTechSpecs;
        private System.Windows.Forms.TextBox TextBoxWebcam;
        private System.Windows.Forms.TextBox TextBoxGPU;
        private System.Windows.Forms.TextBox TextBoxHDD;
        private System.Windows.Forms.TextBox TextBoxCPUSpeed;
        private System.Windows.Forms.TextBox TextBoxCPUType;
        private System.Windows.Forms.TextBox TextBoxLCD;
        private System.Windows.Forms.TextBox TextBoxCPUBrand;
        private System.Windows.Forms.TextBox TextBoxCPUNumber;
        private System.Windows.Forms.TextBox TextBoxMemory;
        private System.Windows.Forms.Label LabelHDD;
        private System.Windows.Forms.Label LabelGPUType;
        private System.Windows.Forms.Label LabelWebCam;
        private System.Windows.Forms.Label LabelLCDSize;
        private System.Windows.Forms.Label LabelCPUNumber;
        private System.Windows.Forms.Label LabelCPUSpeed;
        private System.Windows.Forms.Label LabelCPUType;
        private System.Windows.Forms.Label LabelCPUBrand;
        private System.Windows.Forms.Label LabelMemory;
        private System.Windows.Forms.Label LabelCondition;
        private System.Windows.Forms.Label LabelProductID;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TextBoxProductID;
        private System.Windows.Forms.TextBox TextBoxCondition;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.Button ButtonSelectAnotherProduct;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.MenuStrip MenuStripProductInfoForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}