//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class BOOTSRow : IGoogle2uRow
	{
		public string _Name;
		public int _Cost;
		public int _Appearance;
		public string _ShownName;
		public BOOTSRow(string __ID, string __Name, string __Cost, string __Appearance, string __ShownName) 
		{
			_Name = __Name.Trim();
			{
			int res;
				if(int.TryParse(__Cost, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Cost = res;
				else
					Debug.LogError("Failed To Convert _Cost string: "+ __Cost +" to int");
			}
			{
			int res;
				if(int.TryParse(__Appearance, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Appearance = res;
				else
					Debug.LogError("Failed To Convert _Appearance string: "+ __Appearance +" to int");
			}
			_ShownName = __ShownName.Trim();
		}

		public int Length { get { return 4; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _Name.ToString();
					break;
				case 1:
					ret = _Cost.ToString();
					break;
				case 2:
					ret = _Appearance.ToString();
					break;
				case 3:
					ret = _ShownName.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Name":
					ret = _Name.ToString();
					break;
				case "Cost":
					ret = _Cost.ToString();
					break;
				case "Appearance":
					ret = _Appearance.ToString();
					break;
				case "ShownName":
					ret = _ShownName.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Cost" + " : " + _Cost.ToString() + "} ";
			ret += "{" + "Appearance" + " : " + _Appearance.ToString() + "} ";
			ret += "{" + "ShownName" + " : " + _ShownName.ToString() + "} ";
			return ret;
		}
	}
	public sealed class BOOTS : IGoogle2uDB
	{
		public enum rowIds {
			Boots1
		};
		public string [] rowNames = {
			"Boots1"
		};
		public System.Collections.Generic.List<BOOTSRow> Rows = new System.Collections.Generic.List<BOOTSRow>();

		public static BOOTS Instance
		{
			get { return NestedBOOTS.instance; }
		}

		private class NestedBOOTS
		{
			static NestedBOOTS() { }
			internal static readonly BOOTS instance = new BOOTS();
		}

		private BOOTS()
		{
			Rows.Add( new BOOTSRow("Boots1", "Boots1", "11", "0", "Boots1"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public BOOTSRow GetRow(rowIds in_RowID)
		{
			BOOTSRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public BOOTSRow GetRow(string in_RowString)
		{
			BOOTSRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
