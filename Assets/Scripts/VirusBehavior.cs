using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehavior: MonoBehaviour
{
	public float damageAmount = 2f;
	public GameObject explosionPrefab;
	public AudioClip damageSFX;

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Projectile")
		{
			if (explosionPrefab)
			{
				// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate(explosionPrefab, transform.position, transform.rotation);
			}

			// destroy the projectile
			Destroy(col.gameObject);

			// destroy self
			Destroy(gameObject);
		}

		else if (col.gameObject.GetComponent<Health>()) { 
			col.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);

			if (explosionPrefab)
				Instantiate(explosionPrefab, transform.position, transform.rotation);

			Destroy(gameObject);
		}

		
	}
}
