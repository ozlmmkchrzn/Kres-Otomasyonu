
namespace KresOtomasyon
{
    partial class Frm_OgrKartSaglik
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
            this.comboBoxOgrKan = new System.Windows.Forms.ComboBox();
            this.OgrKan = new System.Windows.Forms.Label();
            this.OgrSaglikBilgileri = new System.Windows.Forms.Label();
            this.checkBoxHasMenenjit = new System.Windows.Forms.CheckBox();
            this.checkBoxHasZaturre = new System.Windows.Forms.CheckBox();
            this.checkBoxHasSuCicegi = new System.Windows.Forms.CheckBox();
            this.checkBoxHasKabakulak = new System.Windows.Forms.CheckBox();
            this.checkBoxHasHepatitA = new System.Windows.Forms.CheckBox();
            this.checkBoxHasSarilik = new System.Windows.Forms.CheckBox();
            this.checkBoxHasHepatitB = new System.Windows.Forms.CheckBox();
            this.checkBoxHasKizamik = new System.Windows.Forms.CheckBox();
            this.OgrSaglikHastalik = new System.Windows.Forms.Label();
            this.OgrSaglikAsilar = new System.Windows.Forms.Label();
            this.checkBoxOgrAsiHeapatitB = new System.Windows.Forms.CheckBox();
            this.checkBoxOgrAsiBDT = new System.Windows.Forms.CheckBox();
            this.checkBoxOgrAsiBCG = new System.Windows.Forms.CheckBox();
            this.checkBoxOgrAsiKizamik = new System.Windows.Forms.CheckBox();
            this.checkBoxOgrAsiFelc = new System.Windows.Forms.CheckBox();
            this.richTextBoxOgrSaglikNot = new System.Windows.Forms.RichTextBox();
            this.OgrSaglikNot = new System.Windows.Forms.Label();
            this.txt_OgrSaglikDiyet = new System.Windows.Forms.TextBox();
            this.OgrSaglikDiyet = new System.Windows.Forms.Label();
            this.txt_OgrSaglikIlac = new System.Windows.Forms.TextBox();
            this.OgrSaglikIlac = new System.Windows.Forms.Label();
            this.txt_OgrHastalik = new System.Windows.Forms.TextBox();
            this.OgrHastalik = new System.Windows.Forms.Label();
            this.txt_OgrSaglikDurum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxProtez = new System.Windows.Forms.RichTextBox();
            this.richTextBoxKronik = new System.Windows.Forms.RichTextBox();
            this.OgrProtez = new System.Windows.Forms.Label();
            this.OgrKronik = new System.Windows.Forms.Label();
            this.txt_Doktor = new System.Windows.Forms.TextBox();
            this.OgrDoktor = new System.Windows.Forms.Label();
            this.txt_OgrHastane = new System.Windows.Forms.TextBox();
            this.OgrHastane = new System.Windows.Forms.Label();
            this.checkBoxHastane = new System.Windows.Forms.CheckBox();
            this.checkBoxKaza = new System.Windows.Forms.CheckBox();
            this.checkBoxYurume = new System.Windows.Forms.CheckBox();
            this.checkBoxEngel = new System.Windows.Forms.CheckBox();
            this.checkBoxAlerji = new System.Windows.Forms.CheckBox();
            this.checkBoxSigorta = new System.Windows.Forms.CheckBox();
            this.checkBoxGorme = new System.Windows.Forms.CheckBox();
            this.checkBoxDavranis = new System.Windows.Forms.CheckBox();
            this.checkBoxKonusma = new System.Windows.Forms.CheckBox();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Duzenle = new System.Windows.Forms.Button();
            this.btn_Ileri = new System.Windows.Forms.Button();
            this.SaglikID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxOgrKan
            // 
            this.comboBoxOgrKan.FormattingEnabled = true;
            this.comboBoxOgrKan.Items.AddRange(new object[] {
            "0 Rh-Pozitif    ",
            "A Rh-pozitif    ",
            "A Rh-negatif   ",
            "B Rh-pozitif",
            "B Rh-negatif ",
            "AB Rh-pozitif ",
            "AB Rh-negatif "});
            this.comboBoxOgrKan.Location = new System.Drawing.Point(290, 313);
            this.comboBoxOgrKan.Name = "comboBoxOgrKan";
            this.comboBoxOgrKan.Size = new System.Drawing.Size(231, 21);
            this.comboBoxOgrKan.TabIndex = 95;
            // 
            // OgrKan
            // 
            this.OgrKan.AutoSize = true;
            this.OgrKan.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrKan.Location = new System.Drawing.Point(183, 313);
            this.OgrKan.Name = "OgrKan";
            this.OgrKan.Size = new System.Drawing.Size(91, 18);
            this.OgrKan.TabIndex = 94;
            this.OgrKan.Text = "Kan Grubu:";
            // 
            // OgrSaglikBilgileri
            // 
            this.OgrSaglikBilgileri.AutoSize = true;
            this.OgrSaglikBilgileri.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSaglikBilgileri.Location = new System.Drawing.Point(434, 36);
            this.OgrSaglikBilgileri.Name = "OgrSaglikBilgileri";
            this.OgrSaglikBilgileri.Size = new System.Drawing.Size(156, 23);
            this.OgrSaglikBilgileri.TabIndex = 93;
            this.OgrSaglikBilgileri.Text = "Sağlık Bilgileri";
            // 
            // checkBoxHasMenenjit
            // 
            this.checkBoxHasMenenjit.AutoSize = true;
            this.checkBoxHasMenenjit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasMenenjit.Location = new System.Drawing.Point(1110, 520);
            this.checkBoxHasMenenjit.Name = "checkBoxHasMenenjit";
            this.checkBoxHasMenenjit.Size = new System.Drawing.Size(78, 19);
            this.checkBoxHasMenenjit.TabIndex = 92;
            this.checkBoxHasMenenjit.Text = "Menenjit";
            this.checkBoxHasMenenjit.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasZaturre
            // 
            this.checkBoxHasZaturre.AutoSize = true;
            this.checkBoxHasZaturre.Location = new System.Drawing.Point(983, 522);
            this.checkBoxHasZaturre.Name = "checkBoxHasZaturre";
            this.checkBoxHasZaturre.Size = new System.Drawing.Size(60, 17);
            this.checkBoxHasZaturre.TabIndex = 91;
            this.checkBoxHasZaturre.Text = "Zatürre";
            this.checkBoxHasZaturre.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasSuCicegi
            // 
            this.checkBoxHasSuCicegi.AutoSize = true;
            this.checkBoxHasSuCicegi.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasSuCicegi.Location = new System.Drawing.Point(1110, 467);
            this.checkBoxHasSuCicegi.Name = "checkBoxHasSuCicegi";
            this.checkBoxHasSuCicegi.Size = new System.Drawing.Size(79, 19);
            this.checkBoxHasSuCicegi.TabIndex = 90;
            this.checkBoxHasSuCicegi.Text = "Su Çiçeği";
            this.checkBoxHasSuCicegi.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasKabakulak
            // 
            this.checkBoxHasKabakulak.AutoSize = true;
            this.checkBoxHasKabakulak.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasKabakulak.Location = new System.Drawing.Point(983, 470);
            this.checkBoxHasKabakulak.Name = "checkBoxHasKabakulak";
            this.checkBoxHasKabakulak.Size = new System.Drawing.Size(88, 19);
            this.checkBoxHasKabakulak.TabIndex = 89;
            this.checkBoxHasKabakulak.Text = "Kabakulak";
            this.checkBoxHasKabakulak.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasHepatitA
            // 
            this.checkBoxHasHepatitA.AutoSize = true;
            this.checkBoxHasHepatitA.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasHepatitA.Location = new System.Drawing.Point(1110, 414);
            this.checkBoxHasHepatitA.Name = "checkBoxHasHepatitA";
            this.checkBoxHasHepatitA.Size = new System.Drawing.Size(82, 19);
            this.checkBoxHasHepatitA.TabIndex = 88;
            this.checkBoxHasHepatitA.Text = "Hepatit A";
            this.checkBoxHasHepatitA.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasSarilik
            // 
            this.checkBoxHasSarilik.AutoSize = true;
            this.checkBoxHasSarilik.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasSarilik.Location = new System.Drawing.Point(983, 414);
            this.checkBoxHasSarilik.Name = "checkBoxHasSarilik";
            this.checkBoxHasSarilik.Size = new System.Drawing.Size(65, 19);
            this.checkBoxHasSarilik.TabIndex = 87;
            this.checkBoxHasSarilik.Text = "Sarılık";
            this.checkBoxHasSarilik.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasHepatitB
            // 
            this.checkBoxHasHepatitB.AutoSize = true;
            this.checkBoxHasHepatitB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasHepatitB.Location = new System.Drawing.Point(1110, 366);
            this.checkBoxHasHepatitB.Name = "checkBoxHasHepatitB";
            this.checkBoxHasHepatitB.Size = new System.Drawing.Size(81, 19);
            this.checkBoxHasHepatitB.TabIndex = 86;
            this.checkBoxHasHepatitB.Text = "Hepatit B";
            this.checkBoxHasHepatitB.UseVisualStyleBackColor = true;
            // 
            // checkBoxHasKizamik
            // 
            this.checkBoxHasKizamik.AutoSize = true;
            this.checkBoxHasKizamik.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHasKizamik.Location = new System.Drawing.Point(983, 366);
            this.checkBoxHasKizamik.Name = "checkBoxHasKizamik";
            this.checkBoxHasKizamik.Size = new System.Drawing.Size(73, 19);
            this.checkBoxHasKizamik.TabIndex = 85;
            this.checkBoxHasKizamik.Text = "Kızamık";
            this.checkBoxHasKizamik.UseVisualStyleBackColor = true;
            // 
            // OgrSaglikHastalik
            // 
            this.OgrSaglikHastalik.AutoSize = true;
            this.OgrSaglikHastalik.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSaglikHastalik.Location = new System.Drawing.Point(975, 292);
            this.OgrSaglikHastalik.Name = "OgrSaglikHastalik";
            this.OgrSaglikHastalik.Size = new System.Drawing.Size(217, 23);
            this.OgrSaglikHastalik.TabIndex = 84;
            this.OgrSaglikHastalik.Text = "Geçirdiği Hastalıklar";
            // 
            // OgrSaglikAsilar
            // 
            this.OgrSaglikAsilar.AutoSize = true;
            this.OgrSaglikAsilar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSaglikAsilar.Location = new System.Drawing.Point(1038, 73);
            this.OgrSaglikAsilar.Name = "OgrSaglikAsilar";
            this.OgrSaglikAsilar.Size = new System.Drawing.Size(69, 23);
            this.OgrSaglikAsilar.TabIndex = 83;
            this.OgrSaglikAsilar.Text = "Aşılar";
            // 
            // checkBoxOgrAsiHeapatitB
            // 
            this.checkBoxOgrAsiHeapatitB.AutoSize = true;
            this.checkBoxOgrAsiHeapatitB.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrAsiHeapatitB.Location = new System.Drawing.Point(979, 194);
            this.checkBoxOgrAsiHeapatitB.Name = "checkBoxOgrAsiHeapatitB";
            this.checkBoxOgrAsiHeapatitB.Size = new System.Drawing.Size(81, 19);
            this.checkBoxOgrAsiHeapatitB.TabIndex = 82;
            this.checkBoxOgrAsiHeapatitB.Text = "Hepatit B";
            this.checkBoxOgrAsiHeapatitB.UseVisualStyleBackColor = true;
            // 
            // checkBoxOgrAsiBDT
            // 
            this.checkBoxOgrAsiBDT.AutoSize = true;
            this.checkBoxOgrAsiBDT.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrAsiBDT.Location = new System.Drawing.Point(1100, 155);
            this.checkBoxOgrAsiBDT.Name = "checkBoxOgrAsiBDT";
            this.checkBoxOgrAsiBDT.Size = new System.Drawing.Size(51, 19);
            this.checkBoxOgrAsiBDT.TabIndex = 81;
            this.checkBoxOgrAsiBDT.Text = "BDT";
            this.checkBoxOgrAsiBDT.UseVisualStyleBackColor = true;
            // 
            // checkBoxOgrAsiBCG
            // 
            this.checkBoxOgrAsiBCG.AutoSize = true;
            this.checkBoxOgrAsiBCG.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrAsiBCG.Location = new System.Drawing.Point(979, 155);
            this.checkBoxOgrAsiBCG.Name = "checkBoxOgrAsiBCG";
            this.checkBoxOgrAsiBCG.Size = new System.Drawing.Size(51, 19);
            this.checkBoxOgrAsiBCG.TabIndex = 80;
            this.checkBoxOgrAsiBCG.Text = "BCG";
            this.checkBoxOgrAsiBCG.UseVisualStyleBackColor = true;
            // 
            // checkBoxOgrAsiKizamik
            // 
            this.checkBoxOgrAsiKizamik.AutoSize = true;
            this.checkBoxOgrAsiKizamik.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrAsiKizamik.Location = new System.Drawing.Point(1100, 115);
            this.checkBoxOgrAsiKizamik.Name = "checkBoxOgrAsiKizamik";
            this.checkBoxOgrAsiKizamik.Size = new System.Drawing.Size(73, 19);
            this.checkBoxOgrAsiKizamik.TabIndex = 79;
            this.checkBoxOgrAsiKizamik.Text = "Kızamık";
            this.checkBoxOgrAsiKizamik.UseVisualStyleBackColor = true;
            // 
            // checkBoxOgrAsiFelc
            // 
            this.checkBoxOgrAsiFelc.AutoSize = true;
            this.checkBoxOgrAsiFelc.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOgrAsiFelc.Location = new System.Drawing.Point(979, 115);
            this.checkBoxOgrAsiFelc.Name = "checkBoxOgrAsiFelc";
            this.checkBoxOgrAsiFelc.Size = new System.Drawing.Size(91, 19);
            this.checkBoxOgrAsiFelc.TabIndex = 78;
            this.checkBoxOgrAsiFelc.Text = "Çocuk Felci";
            this.checkBoxOgrAsiFelc.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOgrSaglikNot
            // 
            this.richTextBoxOgrSaglikNot.Location = new System.Drawing.Point(617, 440);
            this.richTextBoxOgrSaglikNot.Name = "richTextBoxOgrSaglikNot";
            this.richTextBoxOgrSaglikNot.Size = new System.Drawing.Size(299, 173);
            this.richTextBoxOgrSaglikNot.TabIndex = 77;
            this.richTextBoxOgrSaglikNot.Text = "";
            // 
            // OgrSaglikNot
            // 
            this.OgrSaglikNot.AutoSize = true;
            this.OgrSaglikNot.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSaglikNot.Location = new System.Drawing.Point(578, 408);
            this.OgrSaglikNot.Name = "OgrSaglikNot";
            this.OgrSaglikNot.Size = new System.Drawing.Size(338, 16);
            this.OgrSaglikNot.TabIndex = 76;
            this.OgrSaglikNot.Text = "Velinin Öğrenci İçin Dikkat Edilmesini İstediği Şeyler:";
            // 
            // txt_OgrSaglikDiyet
            // 
            this.txt_OgrSaglikDiyet.Location = new System.Drawing.Point(617, 365);
            this.txt_OgrSaglikDiyet.Name = "txt_OgrSaglikDiyet";
            this.txt_OgrSaglikDiyet.Size = new System.Drawing.Size(299, 20);
            this.txt_OgrSaglikDiyet.TabIndex = 75;
            // 
            // OgrSaglikDiyet
            // 
            this.OgrSaglikDiyet.AutoSize = true;
            this.OgrSaglikDiyet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSaglikDiyet.Location = new System.Drawing.Point(617, 329);
            this.OgrSaglikDiyet.Name = "OgrSaglikDiyet";
            this.OgrSaglikDiyet.Size = new System.Drawing.Size(132, 16);
            this.OgrSaglikDiyet.TabIndex = 74;
            this.OgrSaglikDiyet.Text = "Uyguladığı Diyetler:";
            // 
            // txt_OgrSaglikIlac
            // 
            this.txt_OgrSaglikIlac.Location = new System.Drawing.Point(617, 287);
            this.txt_OgrSaglikIlac.Name = "txt_OgrSaglikIlac";
            this.txt_OgrSaglikIlac.Size = new System.Drawing.Size(299, 20);
            this.txt_OgrSaglikIlac.TabIndex = 73;
            // 
            // OgrSaglikIlac
            // 
            this.OgrSaglikIlac.AutoSize = true;
            this.OgrSaglikIlac.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSaglikIlac.Location = new System.Drawing.Point(617, 254);
            this.OgrSaglikIlac.Name = "OgrSaglikIlac";
            this.OgrSaglikIlac.Size = new System.Drawing.Size(271, 16);
            this.OgrSaglikIlac.TabIndex = 72;
            this.OgrSaglikIlac.Text = "Sürekli Kullanmak Zorunda Olduğu İlaçlar:";
            // 
            // txt_OgrHastalik
            // 
            this.txt_OgrHastalik.Location = new System.Drawing.Point(617, 212);
            this.txt_OgrHastalik.Name = "txt_OgrHastalik";
            this.txt_OgrHastalik.Size = new System.Drawing.Size(299, 20);
            this.txt_OgrHastalik.TabIndex = 71;
            // 
            // OgrHastalik
            // 
            this.OgrHastalik.AutoSize = true;
            this.OgrHastalik.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrHastalik.Location = new System.Drawing.Point(617, 183);
            this.OgrHastalik.Name = "OgrHastalik";
            this.OgrHastalik.Size = new System.Drawing.Size(209, 16);
            this.OgrHastalik.TabIndex = 70;
            this.OgrHastalik.Text = "Öğrencinin Geçirdiği Hastalıklar:";
            // 
            // txt_OgrSaglikDurum
            // 
            this.txt_OgrSaglikDurum.Location = new System.Drawing.Point(617, 138);
            this.txt_OgrSaglikDurum.Name = "txt_OgrSaglikDurum";
            this.txt_OgrSaglikDurum.Size = new System.Drawing.Size(299, 20);
            this.txt_OgrSaglikDurum.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(614, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Sağlık Durumu:";
            // 
            // richTextBoxProtez
            // 
            this.richTextBoxProtez.Location = new System.Drawing.Point(290, 566);
            this.richTextBoxProtez.Name = "richTextBoxProtez";
            this.richTextBoxProtez.Size = new System.Drawing.Size(231, 85);
            this.richTextBoxProtez.TabIndex = 67;
            this.richTextBoxProtez.Text = "";
            // 
            // richTextBoxKronik
            // 
            this.richTextBoxKronik.Location = new System.Drawing.Point(290, 425);
            this.richTextBoxKronik.Name = "richTextBoxKronik";
            this.richTextBoxKronik.Size = new System.Drawing.Size(231, 116);
            this.richTextBoxKronik.TabIndex = 66;
            this.richTextBoxKronik.Text = "";
            // 
            // OgrProtez
            // 
            this.OgrProtez.AutoSize = true;
            this.OgrProtez.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrProtez.Location = new System.Drawing.Point(59, 566);
            this.OgrProtez.Name = "OgrProtez";
            this.OgrProtez.Size = new System.Drawing.Size(215, 18);
            this.OgrProtez.TabIndex = 65;
            this.OgrProtez.Text = "Kullandığı Protez ve Cihazlar:";
            // 
            // OgrKronik
            // 
            this.OgrKronik.AutoSize = true;
            this.OgrKronik.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrKronik.Location = new System.Drawing.Point(128, 424);
            this.OgrKronik.Name = "OgrKronik";
            this.OgrKronik.Size = new System.Drawing.Size(146, 18);
            this.OgrKronik.TabIndex = 64;
            this.OgrKronik.Text = "Kronik Hastalıkları:";
            // 
            // txt_Doktor
            // 
            this.txt_Doktor.Location = new System.Drawing.Point(290, 387);
            this.txt_Doktor.Name = "txt_Doktor";
            this.txt_Doktor.Size = new System.Drawing.Size(231, 20);
            this.txt_Doktor.TabIndex = 63;
            // 
            // OgrDoktor
            // 
            this.OgrDoktor.AutoSize = true;
            this.OgrDoktor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrDoktor.Location = new System.Drawing.Point(164, 390);
            this.OgrDoktor.Name = "OgrDoktor";
            this.OgrDoktor.Size = new System.Drawing.Size(110, 18);
            this.OgrDoktor.TabIndex = 62;
            this.OgrDoktor.Text = "Gittiği Doktor:";
            // 
            // txt_OgrHastane
            // 
            this.txt_OgrHastane.Location = new System.Drawing.Point(290, 351);
            this.txt_OgrHastane.Name = "txt_OgrHastane";
            this.txt_OgrHastane.Size = new System.Drawing.Size(231, 20);
            this.txt_OgrHastane.TabIndex = 61;
            // 
            // OgrHastane
            // 
            this.OgrHastane.AutoSize = true;
            this.OgrHastane.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrHastane.Location = new System.Drawing.Point(155, 353);
            this.OgrHastane.Name = "OgrHastane";
            this.OgrHastane.Size = new System.Drawing.Size(119, 18);
            this.OgrHastane.TabIndex = 60;
            this.OgrHastane.Text = "Gittiği Hastane:";
            // 
            // checkBoxHastane
            // 
            this.checkBoxHastane.AutoSize = true;
            this.checkBoxHastane.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHastane.Location = new System.Drawing.Point(384, 214);
            this.checkBoxHastane.Name = "checkBoxHastane";
            this.checkBoxHastane.Size = new System.Drawing.Size(161, 19);
            this.checkBoxHastane.TabIndex = 59;
            this.checkBoxHastane.Text = "Hastanede Yattı Mı?";
            this.checkBoxHastane.UseVisualStyleBackColor = true;
            // 
            // checkBoxKaza
            // 
            this.checkBoxKaza.AutoSize = true;
            this.checkBoxKaza.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxKaza.Location = new System.Drawing.Point(384, 178);
            this.checkBoxKaza.Name = "checkBoxKaza";
            this.checkBoxKaza.Size = new System.Drawing.Size(137, 19);
            this.checkBoxKaza.TabIndex = 58;
            this.checkBoxKaza.Text = "Kaza Geçirdi Mi?";
            this.checkBoxKaza.UseVisualStyleBackColor = true;
            // 
            // checkBoxYurume
            // 
            this.checkBoxYurume.AutoSize = true;
            this.checkBoxYurume.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxYurume.Location = new System.Drawing.Point(123, 249);
            this.checkBoxYurume.Name = "checkBoxYurume";
            this.checkBoxYurume.Size = new System.Drawing.Size(209, 19);
            this.checkBoxYurume.TabIndex = 57;
            this.checkBoxYurume.Text = "Yürüme Bozukluğu Var Mı?";
            this.checkBoxYurume.UseVisualStyleBackColor = true;
            // 
            // checkBoxEngel
            // 
            this.checkBoxEngel.AutoSize = true;
            this.checkBoxEngel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxEngel.Location = new System.Drawing.Point(384, 139);
            this.checkBoxEngel.Name = "checkBoxEngel";
            this.checkBoxEngel.Size = new System.Drawing.Size(123, 19);
            this.checkBoxEngel.TabIndex = 56;
            this.checkBoxEngel.Text = "Engeli Var Mı?";
            this.checkBoxEngel.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlerji
            // 
            this.checkBoxAlerji.AutoSize = true;
            this.checkBoxAlerji.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxAlerji.Location = new System.Drawing.Point(384, 99);
            this.checkBoxAlerji.Name = "checkBoxAlerji";
            this.checkBoxAlerji.Size = new System.Drawing.Size(130, 19);
            this.checkBoxAlerji.TabIndex = 55;
            this.checkBoxAlerji.Text = "Alerjisi Var Mı?";
            this.checkBoxAlerji.UseVisualStyleBackColor = true;
            // 
            // checkBoxSigorta
            // 
            this.checkBoxSigorta.AutoSize = true;
            this.checkBoxSigorta.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSigorta.Location = new System.Drawing.Point(123, 214);
            this.checkBoxSigorta.Name = "checkBoxSigorta";
            this.checkBoxSigorta.Size = new System.Drawing.Size(184, 19);
            this.checkBoxSigorta.TabIndex = 54;
            this.checkBoxSigorta.Text = "Sağlık Sigortası Var Mı?";
            this.checkBoxSigorta.UseVisualStyleBackColor = true;
            // 
            // checkBoxGorme
            // 
            this.checkBoxGorme.AutoSize = true;
            this.checkBoxGorme.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGorme.Location = new System.Drawing.Point(123, 178);
            this.checkBoxGorme.Name = "checkBoxGorme";
            this.checkBoxGorme.Size = new System.Drawing.Size(198, 19);
            this.checkBoxGorme.TabIndex = 53;
            this.checkBoxGorme.Text = "Görme Bozukluğu Var Mı?";
            this.checkBoxGorme.UseVisualStyleBackColor = true;
            // 
            // checkBoxDavranis
            // 
            this.checkBoxDavranis.AutoSize = true;
            this.checkBoxDavranis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDavranis.Location = new System.Drawing.Point(123, 139);
            this.checkBoxDavranis.Name = "checkBoxDavranis";
            this.checkBoxDavranis.Size = new System.Drawing.Size(215, 19);
            this.checkBoxDavranis.TabIndex = 52;
            this.checkBoxDavranis.Text = "Davranış Bozukluğu Var Mı?";
            this.checkBoxDavranis.UseVisualStyleBackColor = true;
            // 
            // checkBoxKonusma
            // 
            this.checkBoxKonusma.AutoSize = true;
            this.checkBoxKonusma.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxKonusma.Location = new System.Drawing.Point(123, 99);
            this.checkBoxKonusma.Name = "checkBoxKonusma";
            this.checkBoxKonusma.Size = new System.Drawing.Size(216, 19);
            this.checkBoxKonusma.TabIndex = 51;
            this.checkBoxKonusma.Text = "Konuşma Bozukluğu Var Mı?";
            this.checkBoxKonusma.UseVisualStyleBackColor = true;
            // 
            // btn_Geri
            // 
            this.btn_Geri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(158, 686);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri.TabIndex = 96;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Duzenle.Location = new System.Drawing.Point(560, 686);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_Duzenle.TabIndex = 97;
            this.btn_Duzenle.Text = "Düzenle";
            this.btn_Duzenle.UseVisualStyleBackColor = true;
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // btn_Ileri
            // 
            this.btn_Ileri.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ileri.Location = new System.Drawing.Point(968, 686);
            this.btn_Ileri.Name = "btn_Ileri";
            this.btn_Ileri.Size = new System.Drawing.Size(75, 23);
            this.btn_Ileri.TabIndex = 98;
            this.btn_Ileri.Text = "İleri";
            this.btn_Ileri.UseVisualStyleBackColor = true;
            this.btn_Ileri.Click += new System.EventHandler(this.btn_Ileri_Click);
            // 
            // SaglikID
            // 
            this.SaglikID.AutoSize = true;
            this.SaglikID.Location = new System.Drawing.Point(81, 475);
            this.SaglikID.Name = "SaglikID";
            this.SaglikID.Size = new System.Drawing.Size(47, 13);
            this.SaglikID.TabIndex = 99;
            this.SaglikID.Text = "SaglikID";
            this.SaglikID.Visible = false;
            // 
            // Frm_OgrKartSaglik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1271, 732);
            this.Controls.Add(this.SaglikID);
            this.Controls.Add(this.btn_Ileri);
            this.Controls.Add(this.btn_Duzenle);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.comboBoxOgrKan);
            this.Controls.Add(this.OgrKan);
            this.Controls.Add(this.OgrSaglikBilgileri);
            this.Controls.Add(this.checkBoxHasMenenjit);
            this.Controls.Add(this.checkBoxHasZaturre);
            this.Controls.Add(this.checkBoxHasSuCicegi);
            this.Controls.Add(this.checkBoxHasKabakulak);
            this.Controls.Add(this.checkBoxHasHepatitA);
            this.Controls.Add(this.checkBoxHasSarilik);
            this.Controls.Add(this.checkBoxHasHepatitB);
            this.Controls.Add(this.checkBoxHasKizamik);
            this.Controls.Add(this.OgrSaglikHastalik);
            this.Controls.Add(this.OgrSaglikAsilar);
            this.Controls.Add(this.checkBoxOgrAsiHeapatitB);
            this.Controls.Add(this.checkBoxOgrAsiBDT);
            this.Controls.Add(this.checkBoxOgrAsiBCG);
            this.Controls.Add(this.checkBoxOgrAsiKizamik);
            this.Controls.Add(this.checkBoxOgrAsiFelc);
            this.Controls.Add(this.richTextBoxOgrSaglikNot);
            this.Controls.Add(this.OgrSaglikNot);
            this.Controls.Add(this.txt_OgrSaglikDiyet);
            this.Controls.Add(this.OgrSaglikDiyet);
            this.Controls.Add(this.txt_OgrSaglikIlac);
            this.Controls.Add(this.OgrSaglikIlac);
            this.Controls.Add(this.txt_OgrHastalik);
            this.Controls.Add(this.OgrHastalik);
            this.Controls.Add(this.txt_OgrSaglikDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxProtez);
            this.Controls.Add(this.richTextBoxKronik);
            this.Controls.Add(this.OgrProtez);
            this.Controls.Add(this.OgrKronik);
            this.Controls.Add(this.txt_Doktor);
            this.Controls.Add(this.OgrDoktor);
            this.Controls.Add(this.txt_OgrHastane);
            this.Controls.Add(this.OgrHastane);
            this.Controls.Add(this.checkBoxHastane);
            this.Controls.Add(this.checkBoxKaza);
            this.Controls.Add(this.checkBoxYurume);
            this.Controls.Add(this.checkBoxEngel);
            this.Controls.Add(this.checkBoxAlerji);
            this.Controls.Add(this.checkBoxSigorta);
            this.Controls.Add(this.checkBoxGorme);
            this.Controls.Add(this.checkBoxDavranis);
            this.Controls.Add(this.checkBoxKonusma);
            this.Name = "Frm_OgrKartSaglik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Saglık Bilgileri";
            this.Load += new System.EventHandler(this.Frm_OgrKartSaglik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOgrKan;
        private System.Windows.Forms.Label OgrKan;
        private System.Windows.Forms.Label OgrSaglikBilgileri;
        private System.Windows.Forms.CheckBox checkBoxHasMenenjit;
        private System.Windows.Forms.CheckBox checkBoxHasZaturre;
        private System.Windows.Forms.CheckBox checkBoxHasSuCicegi;
        private System.Windows.Forms.CheckBox checkBoxHasKabakulak;
        private System.Windows.Forms.CheckBox checkBoxHasHepatitA;
        private System.Windows.Forms.CheckBox checkBoxHasSarilik;
        private System.Windows.Forms.CheckBox checkBoxHasHepatitB;
        private System.Windows.Forms.CheckBox checkBoxHasKizamik;
        private System.Windows.Forms.Label OgrSaglikHastalik;
        private System.Windows.Forms.Label OgrSaglikAsilar;
        private System.Windows.Forms.CheckBox checkBoxOgrAsiHeapatitB;
        private System.Windows.Forms.CheckBox checkBoxOgrAsiBDT;
        private System.Windows.Forms.CheckBox checkBoxOgrAsiBCG;
        private System.Windows.Forms.CheckBox checkBoxOgrAsiKizamik;
        private System.Windows.Forms.CheckBox checkBoxOgrAsiFelc;
        private System.Windows.Forms.RichTextBox richTextBoxOgrSaglikNot;
        private System.Windows.Forms.Label OgrSaglikNot;
        private System.Windows.Forms.TextBox txt_OgrSaglikDiyet;
        private System.Windows.Forms.Label OgrSaglikDiyet;
        private System.Windows.Forms.TextBox txt_OgrSaglikIlac;
        private System.Windows.Forms.Label OgrSaglikIlac;
        private System.Windows.Forms.TextBox txt_OgrHastalik;
        private System.Windows.Forms.Label OgrHastalik;
        private System.Windows.Forms.TextBox txt_OgrSaglikDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxProtez;
        private System.Windows.Forms.RichTextBox richTextBoxKronik;
        private System.Windows.Forms.Label OgrProtez;
        private System.Windows.Forms.Label OgrKronik;
        private System.Windows.Forms.TextBox txt_Doktor;
        private System.Windows.Forms.Label OgrDoktor;
        private System.Windows.Forms.TextBox txt_OgrHastane;
        private System.Windows.Forms.Label OgrHastane;
        private System.Windows.Forms.CheckBox checkBoxHastane;
        private System.Windows.Forms.CheckBox checkBoxKaza;
        private System.Windows.Forms.CheckBox checkBoxYurume;
        private System.Windows.Forms.CheckBox checkBoxEngel;
        private System.Windows.Forms.CheckBox checkBoxAlerji;
        private System.Windows.Forms.CheckBox checkBoxSigorta;
        private System.Windows.Forms.CheckBox checkBoxGorme;
        private System.Windows.Forms.CheckBox checkBoxDavranis;
        private System.Windows.Forms.CheckBox checkBoxKonusma;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Button btn_Ileri;
        private System.Windows.Forms.Label SaglikID;
    }
}