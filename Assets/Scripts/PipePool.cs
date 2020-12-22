using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    // Positions and Spawn Rates
    public float spawnRate = 4f;
    public int pipePoolSize = 5;
    public float pipeYMin = -2f;
    public float pipeYMax = 2f;

    // Keeps track of the spawning
    private float timeSinceLastSpawn;
    private float spawnXPos = 10f;
    private int currentPipe = 0;

    // The referance to the pipes prefabs
    public GameObject pipesPrefab;
    
    // This is the array of pips, the pipes pool.
    private GameObject[] pipes;
    // This will generate the pipes away from the character so the player cannot see it
    private Vector2 objectPoolPosition = new Vector2(-15, 25f);
	
    // this method is called pooling which is more iffecant

    // Use this for initialization
	void Start ()
    {
        pipes = new GameObject[pipePoolSize];
        // we will keep using the 5 of the pipes
        for(int i = 0; i < pipePoolSize; i++)
        {
            pipes[i] = Instantiate(pipesPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if(!GameControl.Instance.isGameOver&&timeSinceLastSpawn>=spawnRate)
        {
            timeSinceLastSpawn = 0;

            float spawnYPos = Random.Range(pipeYMin, pipeYMax);
            pipes[currentPipe].transform.position = new Vector2(spawnXPos, spawnYPos);

            currentPipe++;

            if (currentPipe >= pipePoolSize)
            {
                currentPipe = 0;
            }
        }
	}
}
