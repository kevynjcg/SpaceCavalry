using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverlevel : MonoBehaviour
{
	
	GameObject player;
	bool gameOver=false;
    // Start is called before the first frame update
    void Start()
    {
		
		player = GameObject.FindGameObjectWithTag("Player");				//find the player
        
    }

    // Update is called once per frame
    void Update()
    {
		if(player==null&&!gameOver)
		{
			
			IfGameOver();
			
		}
        
    }
	
	void IfGameOver()
	{
		
		gameOver=true;
		if(PlayerPrefs.GetInt("Points")>PlayerPrefs.GetInt("HighScore"))
			PlayerPrefs.SetInt("HighScore",PlayerPrefs.GetInt("Points"));
		
		StartCoroutine(LoadGameOver());
		
	}
	
	IEnumerator LoadGameOver()												//load game over scene
	{
		
		yield return new WaitForSeconds(3f);								//wait 3sec to the next line
		SceneManager.LoadScene(8);		
		
	}
	
}
