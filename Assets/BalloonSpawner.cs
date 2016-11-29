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
		StartCoroutine (tickingTimer ());
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
	void tickingTimer() {
		public static float timer;
		int minutes = Mathf.FloorToInt(timer/60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string time = string.Format("{0:0}:{1:00}", minutes, seconds);

		GUI.Label(new Rect(10,10,250,100), time);	// how to figure out x and y points?

		// if EARN_MONEY then subtract 10 seconds - do these go under function InitializeBalloon()?
		// if SPEND_POSITIVE then add 10 seconds
		// if SPEND_NEGATIVE then subtract 10 seconds
	}
}
