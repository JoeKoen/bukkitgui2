﻿// Forwarder.cs in bukkitgui2/bukkitgui2
// Created 2014/01/17
// Last edited at 2014/06/22 12:34
// ©Bertware, visit http://bertware.net

using System;
using System.Windows.Forms;

namespace Net.Bertware.Bukkitgui2.AddOn.Forwarder
{
	internal class Forwarder : IAddon
	{
		private UserControl _tab;

		/// <summary>
		///     The addon name, ideally this name is the same as used in the tabpage
		/// </summary>
		public string Name
		{
			get { return "Forwarder"; }
		}

		/// <summary>
		///     True if this addon has a tab page
		/// </summary>
		public bool HasTab
		{
			get { return true; }
		}

		/// <summary>
		///     True if this addon has a config field
		/// </summary>
		public bool HasConfig
		{
			get { return false; }
		}

		/// <summary>
		///     Initialize all functions and the tabcontrol
		/// </summary>
		public void Initialize()
		{
			_tab = new ForwarderTab {Text = Name, ParentAddon = this};
		}

		public void Dispose()
		{
			// nothing to do
		}

		public UserControl TabPage { get; private set; }

		public UserControl ConfigPage { get; private set; }

		public bool CanDisable
		{
			get { return true; }
		}

		/// <summary>
		///     The tab control for this addon
		/// </summary>
		/// <returns>Returns the tabpage</returns>
		UserControl IAddon.TabPage
		{
			get { return _tab; }
		}
	}
}