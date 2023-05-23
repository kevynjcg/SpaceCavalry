using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal_Up : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D col)
	{
		Destroy(gameObject,4);
		
		if(col.gameObject.tag=="Player")
		{
			col.gameObject.GetComponent<Ship>().AddHealth();
			Destroy(gameObject);
			
			
		}
		
		
		
		
	}
	
	
}
