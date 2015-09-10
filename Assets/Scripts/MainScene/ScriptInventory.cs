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

    
    string m_SaveString;

    public List<string> StringTest = new List<string>();

    void Awake ()
    {
        if (File.ReadAllText(Application.dataPath + "BowInventory.txt") != null)
        { Load(m_PossessedBowInventory, "BowInventory"); }

        if (File.ReadAllText(Application.dataPath + "SternInventory.txt") != null)
        { Load(m_PossessedSternInventory, "SternInventory"); }

        if (File.ReadAllText(Application.dataPath + "KeelInventory.txt") != null)
        { Load(m_PossessedKeelInventory, "KeelInventory"); }

        if (File.ReadAllText(Application.dataPath + "MastInventory.txt") != null)
        { Load(m_PossessedMastInventory, "MastInventory"); }

        if (File.ReadAllText(Application.dataPath+"SpecialistInventory.txt")!=null)
        { Load(m_PossessedSpecialistInventory, "SpecialistInventory"); }

        if (File.ReadAllText(Application.dataPath + "WeaponInventory.txt") != null)
        { Load(m_PossessedWeaponInventory, "WeaponInventory"); }

        if (File.ReadAllText(Application.dataPath + "GadgetInventory.txt") != null)
        { Load(m_PossessedGadgetInventory, "GadgetInventory"); }

        if (File.ReadAllText(Application.dataPath + "UltimateInventory.txt") != null)
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
