using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHighScore : MonoBehaviour
{
	public float rate;
	public GameObject[] enemies;
	public int waves;
	float timer=10;
    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("SpawnEnemy",rate,rate);
    }
	
	void Update()
    {
        timer += Time.deltaTime;
	
        if(timer>30){
            rate=rate-0.5f;
			waves =waves+1;
			if(rate<0)
			{
				
				rate=rate*-1;
				
			}
			
			timer=0;
			
			
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
	
}
