using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
   public GameObject button1;
   public GameObject button2;
   public GameObject button3;
   
   
   public GameObject tab1;
   public GameObject tab2;
   public GameObject tab3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	public void HideTabs()
	{
		
		tab1.SetActive(false);
		tab2.SetActive(false);
		tab3.SetActive(false);
		
		
		
	}
	
	public void ShowTab1()
	{
		HideTabs();
		tab1.SetActive(true);
	}
	
	public void ShowTab2()
	{
		HideTabs();
		tab2.SetActive(true);
	}
	public void ShowTab3()
	{
		HideTabs();
		tab3.SetActive(true);
	}
	
}

