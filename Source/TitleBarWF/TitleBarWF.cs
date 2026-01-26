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

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TitleBarWF.Designers;

namespace TitleBarWF
{
	//*-------------------------------------------------------------------------*
	//*	TitleBarWF																															*
	//*-------------------------------------------------------------------------*
	/// <summary>
	/// Title bar control.
	/// </summary>
	[Designer(typeof(MenuAreaDesigner))]
	public partial class TitleBarWF : UserControl
	{
		//*************************************************************************
		//*	Private																																*
		//*************************************************************************
		private Color mBackgroundColor = Color.White;
		private bool mMouseDown = false;
		private Point mMouseLocation = Point.Empty;
		private Form mParentForm = null;

		//*-----------------------------------------------------------------------*
		//* mParentForm_Activated																									*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The parent form has been activated.
		/// </summary>
		/// <param name="sender">
		/// The object raising this event.
		/// </param>
		/// <param name="e">
		/// Standard event arguments.
		/// </param>
		private void mParentForm_Activated(object sender, EventArgs e)
		{
			Color color = mBackgroundColor;

			pnlIcon.BackColor = color;
			pnlMenu.BackColor = color;
			pnlWindowClose.BackColor = color;
			pnlWindowControl.BackColor = color;
			pnlWindowMinimize.BackColor = color;
			pnlWindowRestore.BackColor = color;
			foreach(Control control in pnlMenu.Controls)
			{
				control.Enabled = true;
				control.BackColor = color;
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* mParentForm_Deactivate																								*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The parent form has deactivated.
		/// </summary>
		/// <param name="sender">
		/// The object raising this event.
		/// </param>
		/// <param name="e">
		/// Standard event arguments.
		/// </param>
		private void mParentForm_Deactivate(object sender, EventArgs e)
		{
			Color color = ColorTranslator.FromHtml("#d0d0d0");

			pnlIcon.BackColor = color;
			pnlMenu.BackColor = color;
			pnlWindowClose.BackColor = color;
			pnlWindowControl.BackColor = color;
			pnlWindowMinimize.BackColor = color;
			pnlWindowRestore.BackColor = color;
			foreach(Control control in pnlMenu.Controls)
			{
				control.BackColor = color;
				control.Enabled = false;
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* mParentForm_Resize																										*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The parent form has been resized.
		/// </summary>
		/// <param name="sender">
		/// The object raising this event.
		/// </param>
		/// <param name="e">
		/// Standard event arguments.
		/// </param>
		private void mParentForm_Resize(object sender, EventArgs e)
		{
			pnlWindowMinimize.Visible = mParentForm.MinimizeBox;
			pnlWindowRestore.Visible = mParentForm.MaximizeBox;
			if(mParentForm.WindowState == FormWindowState.Maximized)
			{
				pnlWindowRestore.BackgroundImage =
					ResourceMain.WindowRestoreDown32;
			}
			else
			{
				pnlWindowRestore.BackgroundImage =
					ResourceMain.WindowRestoreUp32;
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlIcon_MouseDown																											*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has been depressed over the icon panel.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlIcon_MouseDown(object sender, MouseEventArgs e)
		{
			mMouseDown = true;
			mMouseLocation = e.Location;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlIcon_MouseMove																											*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has been moved over the icon panel.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlIcon_MouseMove(object sender, MouseEventArgs e)
		{
			Point delta = Point.Empty;

			if(mMouseDown)
			{
				delta = new Point(e.Location.X - mMouseLocation.X,
					e.Location.Y - mMouseLocation.Y);
				if(mParentForm != null)
				{
					mParentForm.Location = new Point(
						mParentForm.Location.X + delta.X,
						mParentForm.Location.Y + delta.Y);
				}
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlIcon_MouseUp																												*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has been released over the icon panel.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlIcon_MouseUp(object sender, MouseEventArgs e)
		{
			mMouseDown = false;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowClose_Click																									*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The Window Close button has been clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowClose_Click(object sender, EventArgs e)
		{
			if(mParentForm != null)
			{
				mParentForm.Close();
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowClose_MouseEnter																							*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has entered the Window Close button area.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowClose_MouseEnter(object sender, EventArgs e)
		{
			pnlWindowClose.BackColor = Color.FromArgb(255, 220, 220);
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowClose_MouseLeave																							*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has exited the area of the close button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowClose_MouseLeave(object sender, EventArgs e)
		{
			pnlWindowClose.BackColor = pnlIcon.BackColor;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowControl_MouseDown																						*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has been depressed over the window control.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowControl_MouseDown(object sender, MouseEventArgs e)
		{
			mMouseDown = true;
			mMouseLocation = e.Location;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowControl_MouseMove																						*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has been moved over the window control.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowControl_MouseMove(object sender, MouseEventArgs e)
		{
			Point delta = Point.Empty;

			if(mMouseDown)
			{
				delta = new Point(e.Location.X - mMouseLocation.X,
					e.Location.Y - mMouseLocation.Y);
				if(mParentForm != null)
				{
					mParentForm.Location = new Point(
						mParentForm.Location.X + delta.X,
						mParentForm.Location.Y + delta.Y);
				}
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowControl_MouseUp																							*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has been released over the window control.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowControl_MouseUp(object sender, MouseEventArgs e)
		{
			mMouseDown = false;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowMinimize_Click																								*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The window minimize button has been clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowMinimize_Click(object sender, EventArgs e)
		{
			if(mParentForm != null)
			{
				mParentForm.WindowState = FormWindowState.Minimized;
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowMinimize_MouseEnter																					*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has entered the area of the minimize button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowMinimize_MouseEnter(object sender, EventArgs e)
		{
			pnlWindowMinimize.BackColor = SystemColors.Control;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowMinimize_MouseLeave																					*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has left the area of the minimize button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowMinimize_MouseLeave(object sender, EventArgs e)
		{
			pnlWindowMinimize.BackColor = pnlIcon.BackColor;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowRestore_Click																								*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The window restore button has been clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowRestore_Click(object sender, EventArgs e)
		{
			if(mParentForm != null)
			{
				if(mParentForm.WindowState == FormWindowState.Maximized)
				{
					mParentForm.WindowState = FormWindowState.Normal;
				}
				else
				{
					mParentForm.WindowState = FormWindowState.Maximized;
				}
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowRestore_MouseEnter																						*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has entered the area of the restore button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowRestore_MouseEnter(object sender, EventArgs e)
		{
			pnlWindowRestore.BackColor = SystemColors.Control;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* pnlWindowRestore_MouseLeave																						*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The mouse has left the area of the restore button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlWindowRestore_MouseLeave(object sender, EventArgs e)
		{
			pnlWindowRestore.BackColor = pnlIcon.BackColor;
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//* titleBar_ParentChanged																								*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// The Parent property of the title bar has changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void titleBar_ParentChanged(object sender, EventArgs e)
		{
			Form form = null;


			if(mParentForm != null)
			{
				mParentForm.Resize -= mParentForm_Resize;
			}
			if(this.Parent != null)
			{
				form = this.Parent.FindForm();
				if(form != null)
				{
					pnlWindowMinimize.Visible = form.MinimizeBox;
					pnlWindowRestore.Visible = form.MaximizeBox;
					if(form.WindowState == FormWindowState.Maximized)
					{
						pnlWindowRestore.BackgroundImage =
							ResourceMain.WindowRestoreDown32;
					}
					else
					{
						pnlWindowRestore.BackgroundImage =
							ResourceMain.WindowRestoreUp32;
					}
					if(mParentForm != null)
					{
						mParentForm.Resize -= mParentForm_Resize;
						mParentForm.Deactivate -= mParentForm_Deactivate;
						mParentForm.Activated -= mParentForm_Activated;
					}
					mParentForm = form;
					mParentForm.Activated += mParentForm_Activated;
					mParentForm.Deactivate += mParentForm_Deactivate;
					mParentForm.Resize += mParentForm_Resize;
				}
			}
		}

		//*-----------------------------------------------------------------------*

		//*************************************************************************
		//*	Protected																															*
		//*************************************************************************
		//*************************************************************************
		//*	Public																																*
		//*************************************************************************
		//*-----------------------------------------------------------------------*
		//*	_Constructor																													*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Create a new instance of the TitleBarWF Item.
		/// </summary>
		public TitleBarWF()
		{
			InitializeComponent();
			this.BorderStyle = BorderStyle.FixedSingle;
			this.ParentChanged += titleBar_ParentChanged;

			pnlIcon.Cursor = Cursors.SizeAll;
			pnlIcon.MouseDown += pnlIcon_MouseDown;
			pnlIcon.MouseMove += pnlIcon_MouseMove;
			pnlIcon.MouseUp += pnlIcon_MouseUp;
			pnlWindowControl.Cursor = Cursors.SizeAll;
			pnlWindowControl.MouseDown += pnlWindowControl_MouseDown;
			pnlWindowControl.MouseMove += pnlWindowControl_MouseMove;
			pnlWindowControl.MouseUp += pnlWindowControl_MouseUp;

			pnlWindowClose.Cursor = Cursors.Default;
			pnlWindowClose.Click += pnlWindowClose_Click;
			pnlWindowClose.MouseEnter += pnlWindowClose_MouseEnter;
			pnlWindowClose.MouseLeave += pnlWindowClose_MouseLeave;
			pnlWindowMinimize.Cursor = Cursors.Default;
			pnlWindowMinimize.Click += pnlWindowMinimize_Click;
			pnlWindowMinimize.MouseEnter += pnlWindowMinimize_MouseEnter;
			pnlWindowMinimize.MouseLeave += pnlWindowMinimize_MouseLeave;
			pnlWindowRestore.Cursor = Cursors.Default;
			pnlWindowRestore.Click += pnlWindowRestore_Click;
			pnlWindowRestore.MouseEnter += pnlWindowRestore_MouseEnter;
			pnlWindowRestore.MouseLeave += pnlWindowRestore_MouseLeave;

		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//*	BackColor																															*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Get/Set the background color of the control.
		/// </summary>
		public override Color BackColor
		{
			get { return pnlIcon.BackColor; }
			set
			{
				base.BackColor = value;
				pnlIcon.BackColor = value;
				pnlMenu.BackColor = value;
				pnlWindowClose.BackColor = value;
				pnlWindowControl.BackColor = value;
				pnlWindowControlPadding.BackColor = value;
				pnlWindowMinimize.BackColor = value;
				pnlWindowRestore.BackColor = value;
			}
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//*	IconImage																															*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Get/Set a reference to the icon image to be displayed in the title bar.
		/// </summary>
		public Image IconImage
		{
			get { return pnlIcon.BackgroundImage; }
			set { pnlIcon.BackgroundImage = value; }
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//*	MenuArea																															*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Get a reference to the working menu area.
		/// </summary>
		[Category("Appearance")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Panel MenuArea
		{
			get { return pnlMenu; }
		}
		//*-----------------------------------------------------------------------*

		//*-----------------------------------------------------------------------*
		//*	WindowControlWidth																										*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Get/Set the window control take-up width.
		/// </summary>
		public int WindowControlWidth
		{
			get { return pnlWindowControl.Width; }
			set { pnlWindowControl.Width = value; }
		}
		//*-----------------------------------------------------------------------*

	}
	//*-------------------------------------------------------------------------*

}