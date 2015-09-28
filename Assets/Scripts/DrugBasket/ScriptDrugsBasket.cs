using UnityEngine;
using System.Collections;

public class ScriptDrugsBasket : MonoBehaviour
{

    void Start ()
    {
        Location();
    }

    void OnTriggerEnter (Collider other)
    {
        //Debug.Log("OY");
    }
	
    public void Location()
    {
        this.transform.position =new Vector3 (Random.Range(-2f, 2f),-1.5f,20.36f);
    }
}
