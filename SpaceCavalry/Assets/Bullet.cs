using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	
	Rigidbody2D rb;
	int direction = 1;
    // Start is called before the first frame update
	
		void Awake()
	{
		rb=GetComponent<Rigidbody2D>();

	
	}
	
	
	
    public void ChangeDirection()
    {
        direction*=-1;
		
    }
	
	public void ChangeColor(Color col)
	{
		GetComponent<SpriteRenderer>().color=col;
		
		
		
	}
	
	


    // Update is called once per frame
    void Update()
    {
        rb.velocity=new Vector2(0,10*direction);							//movement direction of bullet
    }
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(direction==1)
		{
			if(col.gameObject.tag=="Enemy")										//if bullet tags enemy, it will damage
			{
				col.gameObject.GetComponent<Enemy>().Damage();
				
				Destroy(gameObject);											//Destroy bullet if it tags enemy
			}
			
		}
		
		else
		{			
			if(col.gameObject.tag=="Player")										//if bullet tags enemy, it will damage
			{
				col.gameObject.GetComponent<Ship>().Damage();
			
				Destroy(gameObject);											//Destroy bullet if it tags enemy
			}
		}
	}
}
