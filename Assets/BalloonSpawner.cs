using UnityEngine;
using System.Collections;

public class BalloonSpawner : MonoBehaviour {

    [SerializeField]
    private float yHeight;

    [SerializeField]
    private float xMin;

    [SerializeField]
    private float xMax;

    [SerializeField]
    private Object balloonPrefab;

    [SerializeField]
    private float spawnDelay;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnBalloons());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private IEnumerator SpawnBalloons()
    {

        while (true)
        {

            float xPos = Random.Range(xMin, xMax);

            Vector2 spawnPosition = new Vector2(xPos, yHeight);

            GameObject spawnedBalloon = GameObject.Instantiate(balloonPrefab, spawnPosition, Quaternion.identity) as GameObject;

            int randomBalloonType = Random.Range(0, 3);

            spawnedBalloon.GetComponent<Balloon>().InitializeBalloon((Balloon.BalloonType)randomBalloonType);

            yield return new WaitForSeconds(spawnDelay);


        }
    }
}
