using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AvitoClone
{
    partial class loginScreen
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            registerRepeatPassField = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            registerLoginField = new Guna.UI2.WinForms.Guna2TextBox();
            registerPassField = new Guna.UI2.WinForms.Guna2TextBox();
            registerButton = new Guna.UI2.WinForms.Guna2Button();
            tabPage2 = new TabPage();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            passField = new Guna.UI2.WinForms.Guna2TextBox();
            loginField = new Guna.UI2.WinForms.Guna2TextBox();
            loginButton = new Guna.UI2.WinForms.Guna2Button();
            logo = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            registerNumberField = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 50);
            panel1.Controls.Add(guna2TabControl1);
            panel1.Controls.Add(logo);
            panel1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 542);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(tabPage1);
            guna2TabControl1.Controls.Add(tabPage2);
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(260, 96);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(365, 389);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(46, 46, 50);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(46, 46, 50);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(46, 46, 50);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.Gold;
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 14;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(46, 46, 50);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(46, 46, 50);
            tabPage1.Controls.Add(registerNumberField);
            tabPage1.Controls.Add(registerRepeatPassField);
            tabPage1.Controls.Add(guna2CheckBox2);
            tabPage1.Controls.Add(registerLoginField);
            tabPage1.Controls.Add(registerPassField);
            tabPage1.Controls.Add(registerButton);
            tabPage1.Font = new Font("Kharkiv", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(357, 341);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Регистрация";
            tabPage1.Click += tabPage1_Click;
            // 
            // registerRepeatPassField
            // 
            registerRepeatPassField.BorderRadius = 20;
            registerRepeatPassField.CustomizableEdges = customizableEdges3;
            registerRepeatPassField.DefaultText = "";
            registerRepeatPassField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            registerRepeatPassField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            registerRepeatPassField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            registerRepeatPassField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            registerRepeatPassField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            registerRepeatPassField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerRepeatPassField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            registerRepeatPassField.Location = new Point(62, 128);
            registerRepeatPassField.Name = "registerRepeatPassField";
            registerRepeatPassField.PasswordChar = '\0';
            registerRepeatPassField.PlaceholderText = "Повторите пароль";
            registerRepeatPassField.SelectedText = "";
            registerRepeatPassField.ShadowDecoration.CustomizableEdges = customizableEdges4;
            registerRepeatPassField.Size = new Size(232, 45);
            registerRepeatPassField.TabIndex = 19;
            // 
            // guna2CheckBox2
            // 
            guna2CheckBox2.AutoSize = true;
            guna2CheckBox2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox2.CheckedState.BorderRadius = 0;
            guna2CheckBox2.CheckedState.BorderThickness = 0;
            guna2CheckBox2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CheckBox2.ForeColor = Color.White;
            guna2CheckBox2.Location = new Point(62, 241);
            guna2CheckBox2.Name = "guna2CheckBox2";
            guna2CheckBox2.Size = new Size(121, 19);
            guna2CheckBox2.TabIndex = 18;
            guna2CheckBox2.Text = "показать пароль";
            guna2CheckBox2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox2.UncheckedState.BorderRadius = 0;
            guna2CheckBox2.UncheckedState.BorderThickness = 0;
            guna2CheckBox2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // registerLoginField
            // 
            registerLoginField.BorderRadius = 20;
            registerLoginField.CustomizableEdges = customizableEdges5;
            registerLoginField.DefaultText = "";
            registerLoginField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            registerLoginField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            registerLoginField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            registerLoginField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            registerLoginField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            registerLoginField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerLoginField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            registerLoginField.Location = new Point(62, 26);
            registerLoginField.Name = "registerLoginField";
            registerLoginField.PasswordChar = '\0';
            registerLoginField.PlaceholderText = "Логин";
            registerLoginField.SelectedText = "";
            registerLoginField.ShadowDecoration.CustomizableEdges = customizableEdges6;
            registerLoginField.Size = new Size(232, 45);
            registerLoginField.TabIndex = 16;
            registerLoginField.TextChanged += guna2TextBox4_TextChanged;
            // 
            // registerPassField
            // 
            registerPassField.BorderRadius = 20;
            registerPassField.CustomizableEdges = customizableEdges7;
            registerPassField.DefaultText = "";
            registerPassField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            registerPassField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            registerPassField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            registerPassField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            registerPassField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            registerPassField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerPassField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            registerPassField.Location = new Point(62, 77);
            registerPassField.Name = "registerPassField";
            registerPassField.PasswordChar = '\0';
            registerPassField.PlaceholderText = "Пароль";
            registerPassField.SelectedText = "";
            registerPassField.ShadowDecoration.CustomizableEdges = customizableEdges8;
            registerPassField.Size = new Size(232, 45);
            registerPassField.TabIndex = 17;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registerButton.BorderRadius = 25;
            registerButton.Cursor = Cursors.Hand;
            registerButton.CustomizableEdges = customizableEdges9;
            registerButton.DisabledState.BorderColor = Color.DarkGray;
            registerButton.DisabledState.CustomBorderColor = Color.DarkGray;
            registerButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            registerButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            registerButton.FillColor = Color.Gold;
            registerButton.FocusedColor = Color.Olive;
            registerButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = Color.Black;
            registerButton.Location = new Point(62, 277);
            registerButton.Name = "registerButton";
            registerButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            registerButton.Size = new Size(232, 45);
            registerButton.TabIndex = 15;
            registerButton.Text = "Регистрация";
            registerButton.Click += registerButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(46, 46, 50);
            tabPage2.Controls.Add(guna2CheckBox1);
            tabPage2.Controls.Add(passField);
            tabPage2.Controls.Add(loginField);
            tabPage2.Controls.Add(loginButton);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(357, 341);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вход";
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2CheckBox1.ForeColor = Color.White;
            guna2CheckBox1.Location = new Point(73, 159);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(121, 19);
            guna2CheckBox1.TabIndex = 3;
            guna2CheckBox1.Text = "показать пароль";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // passField
            // 
            passField.BorderRadius = 20;
            passField.CustomizableEdges = customizableEdges11;
            passField.DefaultText = "";
            passField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passField.Location = new Point(62, 89);
            passField.Name = "passField";
            passField.PasswordChar = '●';
            passField.PlaceholderText = "Пароль";
            passField.SelectedText = "";
            passField.ShadowDecoration.CustomizableEdges = customizableEdges12;
            passField.Size = new Size(232, 45);
            passField.TabIndex = 2;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += guna2TextBox2_TextChanged;
            // 
            // loginField
            // 
            loginField.BorderRadius = 20;
            loginField.CustomizableEdges = customizableEdges13;
            loginField.DefaultText = "";
            loginField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            loginField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            loginField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            loginField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            loginField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            loginField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            loginField.Location = new Point(62, 26);
            loginField.Name = "loginField";
            loginField.PasswordChar = '\0';
            loginField.PlaceholderText = "Логин";
            loginField.SelectedText = "";
            loginField.ShadowDecoration.CustomizableEdges = customizableEdges14;
            loginField.Size = new Size(232, 45);
            loginField.TabIndex = 1;
            loginField.TextChanged += guna2TextBox1_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BorderRadius = 25;
            loginButton.Cursor = Cursors.Hand;
            loginButton.CustomizableEdges = customizableEdges15;
            loginButton.DisabledState.BorderColor = Color.DarkGray;
            loginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            loginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginButton.FillColor = Color.Gold;
            loginButton.FocusedColor = Color.Olive;
            loginButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(62, 257);
            loginButton.Name = "loginButton";
            loginButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            loginButton.Size = new Size(232, 45);
            loginButton.TabIndex = 0;
            loginButton.Text = "Вход";
            loginButton.Click += loginButton_Click;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Top;
            logo.Font = new Font("Colus", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            logo.ForeColor = Color.Gold;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(892, 58);
            logo.TabIndex = 13;
            logo.Text = "REFRACTION";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // registerNumberField
            // 
            registerNumberField.BorderRadius = 20;
            registerNumberField.CustomizableEdges = customizableEdges1;
            registerNumberField.DefaultText = "";
            registerNumberField.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            registerNumberField.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            registerNumberField.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            registerNumberField.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            registerNumberField.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            registerNumberField.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerNumberField.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            registerNumberField.Location = new Point(62, 179);
            registerNumberField.Name = "registerNumberField";
            registerNumberField.PasswordChar = '\0';
            registerNumberField.PlaceholderText = "Номер телефона";
            registerNumberField.SelectedText = "";
            registerNumberField.ShadowDecoration.CustomizableEdges = customizableEdges2;
            registerNumberField.Size = new Size(232, 45);
            registerNumberField.TabIndex = 20;
            // 
            // loginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(892, 542);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginScreen";
            Text = "loginScreen";
            Load += loginScreen_Load;
            MouseDown += loginScreen_MouseDown;
            MouseMove += loginScreen_MouseMove;
            panel1.ResumeLayout(false);
            guna2TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label logo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox passField;
        private Guna.UI2.WinForms.Guna2TextBox loginField;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox registerRepeatPassField;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2TextBox registerLoginField;
        private Guna.UI2.WinForms.Guna2TextBox registerPassField;
        private Guna.UI2.WinForms.Guna2Button registerButton;
        private Guna.UI2.WinForms.Guna2TextBox registerNumberField;
    }
}