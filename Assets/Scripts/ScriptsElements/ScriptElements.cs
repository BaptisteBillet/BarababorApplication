using UnityEngine;
using System.Collections;

public class ScriptElements : MonoBehaviour {

	public int m_Speed;
	public int m_Damage;
	public int m_HealthPoint;
	public int m_Capacity;
	
	public string m_ElementName;

	public enum Type 
	{
		BOW,
		STERN,
		MAST,
		KEEL
	}

	Type m_Type;
}
