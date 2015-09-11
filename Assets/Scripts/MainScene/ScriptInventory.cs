using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class ScriptInventory : MonoBehaviour {

    public List<string> m_PossessedBowInventory = new List<string>();
    public List<string> m_PossessedSternInventory = new List<string>();
    public List<string> m_PossessedKeelInventory = new List<string>();
    public List<string> m_PossessedMastInventory = new List<string>();
    public List<string> m_PossessedSpecialistInventory = new List<string>();
    public List<string> m_PossessedWeaponInventory = new List<string>();
    public List<string> m_PossessedGadgetInventory = new List<string>();
    public List<string> m_PossessedUltimateInventory = new List<string>();

    public int m_BowInventoryAvailability;
    public int m_SternInventoryAvailability;
    public int m_KeelInventoryAvailability;
    public int m_MastInventoryAvailability;
    public int m_SpecialistInventoryAvailability;
    public int m_WeaponInventoryAvailability;
    public int m_GadgetInventoryAvailability;
    public int m_UltimateInventoryAvailability;


    string m_SaveString;

    public List<string> StringTest = new List<string>();

    void Awake ()
    {
       if (PlayerPrefs.GetInt("m_BowInventoryAvailability")!=0)
        { Load(m_PossessedBowInventory, "BowInventory"); }

        if (PlayerPrefs.GetInt("m_SternInventoryAvailability") != 0)
        { Load(m_PossessedSternInventory, "SternInventory"); }

        if (PlayerPrefs.GetInt("m_KeelInventoryAvailability") != 0)
        { Load(m_PossessedKeelInventory, "KeelInventory"); }

        if (PlayerPrefs.GetInt("m_MastInventoryAvailability") != 0)
        { Load(m_PossessedMastInventory, "MastInventory"); }

        if (PlayerPrefs.GetInt("m_SpecialistInventoryAvailability") != 0)
        { Load(m_PossessedSpecialistInventory, "SpecialistInventory"); }


        if (PlayerPrefs.GetInt("m_WeaponInventoryAvailability") != 0)
        { Load(m_PossessedWeaponInventory, "WeaponInventory"); }

        if (PlayerPrefs.GetInt("m_GadgetInventoryAvailability") != 0)
        { Load(m_PossessedGadgetInventory, "GadgetInventory"); }

        if (PlayerPrefs.GetInt("m_UltimateInventoryAvailability") != 0)
        { Load(m_PossessedUltimateInventory, "UltimateInventory"); }
        
        
            
    }
	
   

#region Save 

    public void SaveInventory(List<string> m_List, string m_File)
    {
        StringTest = m_List;

            foreach (string data in m_List)
            {
                m_SaveString += data + "|";
            }
        
        
        File.WriteAllText(Application.dataPath + m_File + ".txt", m_SaveString);
                  
    }
#endregion

    public void Load (List<string> m_List,string m_File)
    {
        StringReader Reader = new StringReader(File.ReadAllText(Application.dataPath + m_File +".txt"));

        string s = Reader.ReadLine();
       
        while (s != null)
        {
            char[] delimiter = { '|' };
            string[] result = s.Split(delimiter);

            

            for (int i=0; i<result.Length-1; i++)
            {
               
                m_List.Add(result[i]);
            }
            

            
            s = Reader.ReadLine();
        }

    }

  
}
