/*
 * Copyright (c). 2020-2026 Daniel Patterson, MCSD (danielanywhere).
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * 
 */

using System.Windows.Forms;

namespace TitleBarWF
{
	partial class TitleBarWF
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlIcon = new System.Windows.Forms.Panel();
			this.pnlWindowControl = new System.Windows.Forms.Panel();
			this.pnlWindowMinimize = new System.Windows.Forms.Panel();
			this.pnlWindowRestore = new System.Windows.Forms.Panel();
			this.pnlWindowClose = new System.Windows.Forms.Panel();
			this.pnlWindowControlPadding = new System.Windows.Forms.Panel();
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.pnlWindowControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlIcon
			// 
			this.pnlIcon.BackColor = System.Drawing.Color.White;
			this.pnlIcon.BackgroundImage = global::TitleBarWF.ResourceMain.ADT_Logo21_V1_01_32;
			this.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlIcon.Location = new System.Drawing.Point(0, 0);
			this.pnlIcon.Name = "pnlIcon";
			this.pnlIcon.Size = new System.Drawing.Size(44, 40);
			this.pnlIcon.TabIndex = 0;
			// 
			// pnlWindowControl
			// 
			this.pnlWindowControl.BackColor = System.Drawing.Color.White;
			this.pnlWindowControl.Controls.Add(this.pnlWindowMinimize);
			this.pnlWindowControl.Controls.Add(this.pnlWindowRestore);
			this.pnlWindowControl.Controls.Add(this.pnlWindowClose);
			this.pnlWindowControl.Controls.Add(this.pnlWindowControlPadding);
			this.pnlWindowControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWindowControl.Location = new System.Drawing.Point(544, 0);
			this.pnlWindowControl.Name = "pnlWindowControl";
			this.pnlWindowControl.Size = new System.Drawing.Size(256, 40);
			this.pnlWindowControl.TabIndex = 1;
			// 
			// pnlWindowMinimize
			// 
			this.pnlWindowMinimize.BackgroundImage = global::TitleBarWF.ResourceMain.WindowMinimize32;
			this.pnlWindowMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlWindowMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWindowMinimize.Location = new System.Drawing.Point(74, 0);
			this.pnlWindowMinimize.Name = "pnlWindowMinimize";
			this.pnlWindowMinimize.Size = new System.Drawing.Size(58, 40);
			this.pnlWindowMinimize.TabIndex = 1;
			// 
			// pnlWindowRestore
			// 
			this.pnlWindowRestore.BackgroundImage = global::TitleBarWF.ResourceMain.WindowRestoreUp32;
			this.pnlWindowRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlWindowRestore.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWindowRestore.Location = new System.Drawing.Point(132, 0);
			this.pnlWindowRestore.Name = "pnlWindowRestore";
			this.pnlWindowRestore.Size = new System.Drawing.Size(58, 40);
			this.pnlWindowRestore.TabIndex = 1;
			// 
			// pnlWindowClose
			// 
			this.pnlWindowClose.BackgroundImage = global::TitleBarWF.ResourceMain.WindowClose32;
			this.pnlWindowClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pnlWindowClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWindowClose.Location = new System.Drawing.Point(190, 0);
			this.pnlWindowClose.Name = "pnlWindowClose";
			this.pnlWindowClose.Size = new System.Drawing.Size(58, 40);
			this.pnlWindowClose.TabIndex = 1;
			// 
			// pnlWindowControlPadding
			// 
			this.pnlWindowControlPadding.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlWindowControlPadding.Location = new System.Drawing.Point(248, 0);
			this.pnlWindowControlPadding.Name = "pnlWindowControlPadding";
			this.pnlWindowControlPadding.Size = new System.Drawing.Size(8, 40);
			this.pnlWindowControlPadding.TabIndex = 0;
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.White;
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMenu.Location = new System.Drawing.Point(44, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(500, 40);
			this.pnlMenu.TabIndex = 2;
			// 
			// TitleBarWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlMenu);
			this.Controls.Add(this.pnlWindowControl);
			this.Controls.Add(this.pnlIcon);
			this.Name = "TitleBarWF";
			this.Size = new System.Drawing.Size(800, 40);
			this.pnlWindowControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlIcon;
		private Panel pnlWindowControl;
		private Panel pnlMenu;
		private Panel pnlWindowMinimize;
		private Panel pnlWindowRestore;
		private Panel pnlWindowClose;
		private Panel pnlWindowControlPadding;
	}
}