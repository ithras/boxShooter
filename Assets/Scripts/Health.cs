using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	public float healthPoints = 10f;
	public float respawnHealthPoints = 10f;

	public int numberOfLives = 1;
	public bool isAlive;

	private Vector3 respawnPosition;
	private Quaternion respawnRotation;

	// Start is called before the first frame update
	void Start()
	{
		respawnPosition = transform.position;
		respawnRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update()
	{
		if (healthPoints <= 0)
		{
			if (numberOfLives > 0)
			{
				transform.position = respawnPosition;
				transform.rotation = respawnRotation;
				healthPoints = respawnHealthPoints;
			} 
			else
			{
				isAlive = false;
			}
		}
	}

	public void ApplyDamage(float amount)
	{
		healthPoints = healthPoints - amount;

		if (healthPoints < 0)
			healthPoints = 0;
		
		if (healthPoints <= 0 && numberOfLives > 0)
			numberOfLives--;

		GameManager.gm.playerHit(healthPoints);
	}

	public void ApplyHeal(float amount)
	{
		healthPoints = healthPoints + amount;
	}

	public void ApplyBonusLife(int amount)
	{
		numberOfLives = numberOfLives + amount;
	}
}
