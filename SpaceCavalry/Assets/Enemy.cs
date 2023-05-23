using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
	Rigidbody2D rb;

	public GameObject bullet, explosion, Heal_Up, Coins;
	
	public Color bulletcolor;
	public float xSpeed;
	public float ySpeed;
	public int score;
	public int coin;
	public float speed;
	public bool canShoot;
	public float fireRate;
	public float health;
	public bool canMove;
	public int dmgPoints;
	float sinCenterX;
	public float amplitude = 2;
	public float frequency = 0.5f;
	public bool inverted;
	public float shootIntervalSeconds = 0.5f;
	public float shootDelaySeconds = 2.0f;
	public float shootTimer = 0f;
	public float delayTimer = 0f;	
	
	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		
		
		
	}
	
    // Start is called before the first frame update
    void Start()
    {
		
		
		
		if(canShoot)
		{
			
			InvokeRepeating("Shoot", fireRate,fireRate);
			
		}
        
		
			
		sinCenterX = transform.position.x;
			
    }



    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed,ySpeed*-1);
		
		if(canMove)
		{
			Vector2 pos = transform.position;

			float sin = Mathf.Sin(pos.y * frequency ) * amplitude;
				if (inverted)
				{
					sin *= -1;
				}
			pos.x = sinCenterX + sin;

			transform.position = pos;
		}
    
	
	
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag=="Player" )														//if enemy tag the ship, it will die
		{
			col.gameObject.GetComponent<Ship>().Damage();										//if enemy tag the ship, ship get damage

			Die();
			
			
		}
		
		
		
	}
	
	void Die()																					//Destroy method
	{
			
		if((int)Random.Range(0,8)==0){															//chances of heal up to spawn
			Instantiate(Heal_Up,transform.position,Quaternion.identity);						//spawn heal up
			
		}
		if((int)Random.Range(0,7)==0){															//chances of heal up to spawn
									
			Instantiate(Coins,transform.position,Quaternion.identity);
		}
		
		Instantiate(explosion,transform.position,Quaternion.identity);							//explode when die
		PlayerPrefs.SetInt("Points",PlayerPrefs.GetInt("Points")+score);						//adds score
		
		
		
		
		
		Destroy(gameObject);	
		
		//Destroy object
		
	}
	
	public void Damage()																		//damage method
	{
		
		health--;																			//if hit, health will decrease
		if (health == 0 )																		//if health =0, object will die
		{
			
			Die();
			
		}
		
		
	}
	
	
	void Shoot()																						//Shoot method
	{
		
		GameObject temp = (GameObject) Instantiate(bullet,transform.position,Quaternion.identity);		//spawn bullet
		temp.GetComponent<Bullet>().ChangeDirection();
			
		
		
	}
	
	
}
