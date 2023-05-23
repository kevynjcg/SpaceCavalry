using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonFunction : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	public void Quit()																	//Quit button method
	{
																					//Application.Quit();																//Quit the game
		SceneManager.LoadScene(0);
		
	}
	
	public void Play()																	//Start button method
	{
		PlayerPrefs.SetInt("Points",0);													//reset score when play
	
		SceneManager.LoadScene(3);														//loads to the game
		
		
	}
	
	public void HighScore()																	//Start button method
	{
		PlayerPrefs.SetInt("Points",0);													//reset score when play
	
		SceneManager.LoadScene(4);														//loads to the game
		
		
	}
	
	
	public void Return()																	//Return button method
	{
		
		SceneManager.LoadScene(2);
		
		
		
	}
	
	public void ReturnLevel()																	//Return button method
	{
		PlayerPrefs.SetInt("Points",0);
		SceneManager.LoadScene(3);					
			
		
	}

	public void StartGame()																	//Return button method
	{
		PlayerPrefs.SetInt("Coin",0);	
		PlayerPrefs.SetInt("levelsUnlocked",1);		
		SceneManager.LoadScene(1);					
		
		
	}
	
	public void StartGameInput()																	//Return button method
	{
										
		SceneManager.LoadScene(2);					
		
		
	}
	
	public void Shop()																	//Return button method
	{
										
		SceneManager.LoadScene(5);					
		
		
	}
	
	public void ExitGame()
	{
		
		
		Application.Quit();
		
	}
}

