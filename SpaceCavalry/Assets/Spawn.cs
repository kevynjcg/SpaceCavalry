using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public float rate;
	public float timeLimit;

	public GameObject[] enemies;
	public GameObject finishline;
	public int waves = 1;
	int spawned=0;
	float timer;
	float timer1=0;
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("SpawnEnemy",rate,rate);
    }
	
	 void Update()
    {
        timer += Time.deltaTime;
		timer1 += Time.deltaTime;
        if(timer>timeLimit){
            CancelInvoke("SpawnEnemy");
			

			
			StartCoroutine(LoadGameOver());
			}
			
         if(timer1>25){
            rate=rate-0.5f;
			waves =waves+1;
			if(rate<0)
			{
				
				rate=rate*-1;
				
			}
			
			timer1=0;
			
			
			}   
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
		for(int i=0 ; i<waves;i++)
		{
			Instantiate(enemies[(int)Random.Range(0,enemies.Length)],new Vector3(Random.Range(-8.11f,8.13f),5.46f,1),Quaternion.identity);
		}
	}
	
	
	
	IEnumerator LoadGameOver()												
	{
		
		yield return new WaitForSeconds(5f);								
			if(spawned==0){
			Instantiate(finishline, new Vector3(-0.13f,7,0), Quaternion.identity);
			spawned=1;
			
            }
		
	}
	
	

}
