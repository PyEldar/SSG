using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {
	[SerializeField]Asteroid asteroid;
	[SerializeField]int asteroidsOnAxis = 10;
	[SerializeField]int spacing = 30;
	[SerializeField]int offset = 15;

	void Start(){
		PlaceAsteroids();
	}
	void PlaceAsteroids(){
		for(int x=0; x < asteroidsOnAxis; x++){
			for(int y=0; y < asteroidsOnAxis; y++){
				for(int z=0; z < asteroidsOnAxis; z++){
					CreateAsteroid(x, y, z);
				}
			}
		}
	}

	void CreateAsteroid(int x, int y, int z){
		Vector3 newPosition = new Vector3(
			transform.position.x + (x * spacing) + CalculateOffset(),
			transform.position.y + (y * spacing) + CalculateOffset(),
			transform.position.z + (z * spacing) + CalculateOffset()
		);
		Instantiate(asteroid, newPosition, Quaternion.identity, transform);

	}

	float CalculateOffset(){
		return Random.Range(-offset, offset);
	}
}
