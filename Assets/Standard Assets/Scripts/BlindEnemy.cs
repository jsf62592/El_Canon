using UnityEngine;
using System.Collections;

// Handle basic AI for blind enemies
public class BlindEnemy : MonoBehaviour {
	// Get the player character to access noise level variable
	public GameObject playerCharacter;
	public PlayerNoise playerNoise;
	
	// Use this for initialization
	void Start () {
		playerCharacter = GameObject.Find("Player");
		PlayerNoise playerNoise = playerCharacter.GetComponent<PlayerNoise>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Calculate the distance between this enemy and the player
	Vector3 DistToPlayer(){
		return gameObject.transform.position - playerCharacter.transform.position;
		
	}
	
	// Calculate when the enemy should detect player based on noise
	void NoiseDetection(){
		// If the enemy is less than 10 units away from player in any direction
		if (DistToPlayer().x < 10 || DistToPlayer().y < 10 || DistToPlayer().z < 10){
			// If the noise level is over 20, trigger basic awareness of enemy
			if (playerNoise.noiseLevel > 20){
				// Invoke basic pathing
				
			// If the noise level is over 40, trigger seeking for player
			}else if(playerNoise.noiseLevel > 40){
				// Invoke seeking
			
			// If the noise level is over 70, enemy will know where player is
			}else if(playerNoise.noiseLevel > 70){
				// Invoke direct path to player
			}
		}
	}
}
