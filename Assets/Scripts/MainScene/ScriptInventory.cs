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

    void Start ()
    {
        //Count();
        //m_PossessedSpecialistInventory.Add(PlayerPrefs.GetString(m_PossessedSpecialistInventory[0]));
        //Debug.Log(m_PossessedSpecialistInventory[0]);

        
        Load(m_PossessedBowInventory, "BowInventory.txt");
        Load(m_PossessedSternInventory, "SternInventory.txt");
        Load(m_PossessedKeelInventory, "KeelInventory.txt");
        Load(m_PossessedMastInventory, "MastInventory.txt");
        Load(m_PossessedSpecialistInventory, "SpecialistInventory.txt");
        Load(m_PossessedWeaponInventory, "WeaponInventory.txt");
        Load(m_PossessedGadgetInventory, "GadgetInventory.txt");
        Load(m_PossessedUltimateInventory, "UltimateInventory.txt");
        

    }
	
   

#region Save 

    public void SaveInventory(List<string> m_List, string m_File)
    {
            foreach (string data in m_List)
            {
                m_SaveString += data + "/";
            }

            File.WriteAllText(Application.persistentDataPath + m_File, m_SaveString);
                  
    }
#endregion

    public void Load (List<string> m_List,string m_File)
    {
        StringReader Reader = new StringReader(File.ReadAllText(Application.persistentDataPath + m_File + ".txt"));

        string s = Reader.ReadLine();

        while (s != null)
        {
            char[] delimiter = { '/' };
            string[] result = s.Split(delimiter);

            for (int i=0; i<result.Length; i++)
            {
                m_List.Add(result[i]);
            }
            

            
            s = Reader.ReadLine();
        }

    }
}
