using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
	Rigidbody2D rb;
	public float xSpeed;
	public float ySpeed;
	public int levelToUnlock;
	int numberOfUnlockedLevels;
	GameObject Enemy;
	bool gameSuccess=false;
    // Start is called before the first frame update
    
		void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		
		
		
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		
		
		if(col.gameObject.tag=="Player"&&!gameSuccess)
		{
			IfGameSuccess();
			numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");
			if(numberOfUnlockedLevels<=levelToUnlock)
			{
				
				PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels+1);
				
			}
			
		
			
			
		}
	}
	void IfGameSuccess()
	{
		
		gameSuccess=true;
		
		
		StartCoroutine(LoadGameSuccess());
		
	}
	
	IEnumerator LoadGameSuccess()												//load game over scene
	{
		
		yield return new WaitForSeconds(3f);								//wait 3sec to the next line
		SceneManager.LoadScene(7);		
		
	}	
		
		
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed,ySpeed*-1);
    }
}
