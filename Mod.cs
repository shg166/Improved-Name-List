using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_ImprovedNameList
{
	public class JP_ImprovedNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Improved Name List (CNL) v1.0"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、Locale全般の名称などを日本風に変更します"; }
		}

	}
}