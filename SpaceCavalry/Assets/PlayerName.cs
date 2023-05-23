using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerName : MonoBehaviour
{
	
	public InputField inputName;
	public string myname;
	
	void start()
	{
		myname= inputName.text;
		PlayerPrefs.SetString("PlayerName", myname);
		
	}
	
	
		
}
