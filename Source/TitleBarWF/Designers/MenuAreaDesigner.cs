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

using System.Windows.Forms.Design;

namespace TitleBarWF.Designers
{
	//*-------------------------------------------------------------------------*
	//*	MenuAreaDesigner																												*
	//*-------------------------------------------------------------------------*
	/// <summary>
	/// Menu area designer for the hosting system.
	/// </summary>
	public class MenuAreaDesigner : ParentControlDesigner
	{
		//*************************************************************************
		//*	Private																																*
		//*************************************************************************
		//*************************************************************************
		//*	Protected																															*
		//*************************************************************************
		//*************************************************************************
		//*	Public																																*
		//*************************************************************************
		//*-----------------------------------------------------------------------*
		//*	Initialize																														*
		//*-----------------------------------------------------------------------*
		/// <summary>
		/// Initialize the control.
		/// </summary>
		/// <param name="component">
		/// Reference to the component being initialized.
		/// </param>
		public override void Initialize(System.ComponentModel.IComponent component)
		{
			base.Initialize(component);

			if(this.Control is TitleBarWF)
			{
				this.EnableDesignMode(((TitleBarWF)this.Control).MenuArea, "MenuArea");
			}
		}
		//*-----------------------------------------------------------------------*


	}
	//*-------------------------------------------------------------------------*

}
