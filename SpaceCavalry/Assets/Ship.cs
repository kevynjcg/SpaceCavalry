using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ship : MonoBehaviour
{

	GameObject a,b;
	public GameObject bullet;
	public GameObject explosion;
	Rigidbody2D rb;
	public float speed;
	public int health;
	public int coin;
	public int maxHealth;
	public bool autoShoot = false;
	public float shootIntervalSeconds = 0.5f;
	public float shootDelaySeconds = 2.0f;
	public float shootTimer = 0f;
	public float delayTimer = 0f;
	public Healthbar healthBar;

	
	
	
	void Awake()
	{
		rb=GetComponent<Rigidbody2D>();
		a=transform.Find("a").gameObject;
		b=transform.Find("b").gameObject;	
		
		
		
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HealthPoints", health);
		maxHealth = health;
		healthBar.SetMaxHealth(maxHealth);
		

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal")*speed,0));   //to move horizontally
	    rb.AddForce(new Vector2(0,Input.GetAxis("Vertical")*speed));   //to move Vertically	
		
		if(autoShoot)
		{
			if(delayTimer >= shootDelaySeconds)
			{
				if(shootTimer >= shootIntervalSeconds)
				{
					Shoot();
					shootTimer =0;
				}
				else
				{
					shootTimer += Time.deltaTime;
				}	
			}
			else
			{
		
			delayTimer += Time.deltaTime;

			}
		}
    }
	
	
	public void Damage()
	{
	
		
		health=health-10;
		healthBar.SetHealth(health);
		

		
		PlayerPrefs.SetInt("HealthPoints", health);
		StartCoroutine(Blink());
		if(health <= 0)
		{
			Instantiate(explosion,transform.position,Quaternion.identity);	
			Destroy(gameObject);
		
			
		}
		
		
	}
	
	
	
	
	IEnumerator Blink()															//ship blinks when hit
	{
		
		GetComponent<SpriteRenderer>().color = new Color(1,0,0);				//color of the blink
		yield return new WaitForSeconds(0.2f);
		GetComponent<SpriteRenderer>().color = new Color(1,1,1);				// return to the color of the ship
	}
	
	void Shoot()
	{
		
		Instantiate(bullet,a.transform.position,Quaternion.identity);
		Instantiate(bullet,b.transform.position,Quaternion.identity);
		
	}
	
	public void AddHealth()
	{
		
		
		if(health == maxHealth )
		{
			
			
		}
		else
		{
			health=health+5;
			healthBar.SetHealth(health);
			
		}
		
		PlayerPrefs.SetInt("HealthPoints", health);
		
	}
	public void AddCoin()
	{
		
		
		
		
			
			PlayerPrefs.SetInt("Coin",PlayerPrefs.GetInt("Coin")+coin);
		
		
		
	}
	
}
