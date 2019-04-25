using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numEnemies = 3;
    public GameObject[] powerUps;
	//add this variable to the top of the spawn manager script under the powerUps variable
	public bool canSpawn = false;
	//rename the Start method to StartSpawning

    public void StartSpawning()
    {
        for(int i = 0; i<numEnemies; i++){
            float randX = Random.Range(-7f,7f)/2;
            float randY = Random.Range(7f,15f)/2;     
            Instantiate(enemyPrefab,new Vector3(randX, randY, 0), Quaternion.identity);
        }

		canSpawn = true;
        StartCoroutine(PowerupSpawn());
    }

    public IEnumerator PowerupSpawn(){

	while(canSpawn){
        int randPowerup = Random.Range(0,3);
        float randX = Random.Range(-7f,7f);     
        Instantiate(powerUps[randPowerup],new Vector3(randX, 7f, 0), Quaternion.identity);
        yield return new WaitForSeconds(5);
       }
    }


}
