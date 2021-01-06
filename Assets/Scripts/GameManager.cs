﻿using UnityEngine;

	// public variables
	public GameObject player;
		{
			playerHealth = player.GetComponent<Health>();
			healthPoints.text = playerHealth.healthPoints.ToString();
			numbersOfLives.text = playerHealth.numberOfLives.ToString();
		}

		if (!gameIsOver) {
		

		// increase the score by the scoreAmount and update the text UI
		score += scoreAmount;
	{
		healthPoints.text = healthPointsLeft.ToString();

		numbersOfLives.text = (playerHealth.numberOfLives).ToString();

		crossHair.NegativeText("-2 Health");
	}
		// we are just loading a scene (or reloading this scene)
		// which is an easy way to restart the level
		SceneManager.LoadScene(restartLevelToLoad);

	// public function that can be called to go to the next level of the game
	public void NextLevel ()