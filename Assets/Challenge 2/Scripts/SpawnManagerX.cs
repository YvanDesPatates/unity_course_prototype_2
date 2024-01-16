using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBall());
    }

    // Spawn random ball at random x position at top of play area
    private IEnumerator SpawnRandomBall()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, ballPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[0].transform.rotation);

            float randomDelay = Random.Range(2, 4);
            yield return new WaitForSeconds(randomDelay);
        }
    }
}