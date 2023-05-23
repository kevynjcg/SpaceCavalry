using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Wait : MonoBehaviour
{
    // Start is called before the first frame update
	
	public float wait_time = 15f;
	
    void Start()
    {
        StartCoroutine(Wait_for_intro());
    }

    // Update is called once per frame
   IEnumerator Wait_for_intro()
    {
        
		yield return new WaitForSeconds(wait_time);
		SceneManager.LoadScene(0);
		
    }
}
