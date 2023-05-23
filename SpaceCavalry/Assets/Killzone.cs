using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
	{
		
		
		Destroy(col.gameObject);                 //destroy the ships that are passed by the screen
		
		
		
	}
}
  