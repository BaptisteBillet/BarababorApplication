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
               
       // Load(m_PossessedBowInventory, "BowInventory");
       // Load(m_PossessedSternInventory, "SternInventory");
       // Load(m_PossessedKeelInventory, "KeelInventory");
       // Load(m_PossessedMastInventory, "MastInventory");
        Load(m_PossessedSpecialistInventory, "SpecialistInventory");
        //  Load(m_PossessedWeaponInventory, "WeaponInventory");
        // Load(m_PossessedGadgetInventory, "GadgetInventory");
        // Load(m_PossessedUltimateInventory, "UltimateInventory");

        //Debug.Log(m_PossessedSpecialistInventory[0]);

        //test();
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

    public void test (List<string> m_List)
    {
        for (int i=0; i<m_List.Count;i++)
        {
            
        }
    }
}
