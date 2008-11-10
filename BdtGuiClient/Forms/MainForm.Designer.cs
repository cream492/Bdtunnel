﻿namespace Bdt.GuiClient.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BottomSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.QuitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyContextMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "NotifyIcon";
            this.NotifyIcon.Visible = true;
            // 
            // NotifyContextMenu
            // 
            this.NotifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoItem,
            this.TopSeparator,
            this.StartItem,
            this.StopItem,
            this.ConfigureItem,
            this.AdminItem,
            this.LogsItem,
            this.BottomSeparator,
            this.QuitItem});
            this.NotifyContextMenu.Name = "ContextMenu";
            this.NotifyContextMenu.Size = new System.Drawing.Size(200, 192);
            this.NotifyContextMenu.Opened += new System.EventHandler(this.NotifyContextMenu_Opened);
            // 
            // InfoItem
            // 
            this.InfoItem.Enabled = false;
            this.InfoItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.InfoItem.Name = "InfoItem";
            this.InfoItem.Size = new System.Drawing.Size(199, 22);
            // 
            // TopSeparator
            // 
            this.TopSeparator.Name = "TopSeparator";
            this.TopSeparator.Size = new System.Drawing.Size(196, 6);
            // 
            // BottomSeparator
            // 
            this.BottomSeparator.Name = "BottomSeparator";
            this.BottomSeparator.Size = new System.Drawing.Size(196, 6);
            // 
            // QuitItem
            // 
            this.QuitItem.Name = "QuitItem";
            this.QuitItem.Size = new System.Drawing.Size(199, 22);
            this.QuitItem.Text = global::Bdt.GuiClient.Resources.Strings.MAINFORM_EXIT;
            this.QuitItem.Click += new System.EventHandler(this.QuitItem_Click);
            // 
            // StartItem
            // 
            this.StartItem.Image = global::Bdt.GuiClient.Properties.Resources.start;
            this.StartItem.Name = "StartItem";
            this.StartItem.Size = new System.Drawing.Size(199, 22);
            this.StartItem.Text = global::Bdt.GuiClient.Resources.Strings.MAINFORM_START_CLIENT;
            this.StartItem.Click += new System.EventHandler(this.StartItem_Click);
            // 
            // StopItem
            // 
            this.StopItem.Image = global::Bdt.GuiClient.Properties.Resources.stop;
            this.StopItem.Name = "StopItem";
            this.StopItem.Size = new System.Drawing.Size(199, 22);
            this.StopItem.Text = global::Bdt.GuiClient.Resources.Strings.MAINFORM_STOP_CLIENT;
            this.StopItem.Click += new System.EventHandler(this.StopItem_Click);
            // 
            // ConfigureItem
            // 
            this.ConfigureItem.Image = global::Bdt.GuiClient.Properties.Resources.setup;
            this.ConfigureItem.Name = "ConfigureItem";
            this.ConfigureItem.Size = new System.Drawing.Size(199, 22);
            this.ConfigureItem.Text = global::Bdt.GuiClient.Resources.Strings.MAINFORM_CONFIGURE_CLIENT;
            this.ConfigureItem.Click += new System.EventHandler(this.ConfigureItem_Click);
            // 
            // AdminItem
            // 
            this.AdminItem.Image = global::Bdt.GuiClient.Properties.Resources.server;
            this.AdminItem.ImageTransparentColor = System.Drawing.Color.White;
            this.AdminItem.Name = "AdminItem";
            this.AdminItem.Size = new System.Drawing.Size(199, 22);
            this.AdminItem.Text = "Remote admin server...";
            this.AdminItem.Click += new System.EventHandler(this.AdminItem_Click);
            // 
            // LogsItem
            // 
            this.LogsItem.Image = global::Bdt.GuiClient.Properties.Resources.logs;
            this.LogsItem.Name = "LogsItem";
            this.LogsItem.Size = new System.Drawing.Size(199, 22);
            this.LogsItem.Text = global::Bdt.GuiClient.Resources.Strings.MAINFORM_VIEW_LOGS;
            this.LogsItem.Click += new System.EventHandler(this.LogsItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(115, 26);
            this.ControlBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NotifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip NotifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem StartItem;
        private System.Windows.Forms.ToolStripMenuItem StopItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigureItem;
        private System.Windows.Forms.ToolStripSeparator BottomSeparator;
        private System.Windows.Forms.ToolStripMenuItem QuitItem;
        private System.Windows.Forms.ToolStripMenuItem InfoItem;
        private System.Windows.Forms.ToolStripSeparator TopSeparator;
        private System.Windows.Forms.ToolStripMenuItem LogsItem;
        internal System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem AdminItem;
    }
}