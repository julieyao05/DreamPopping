using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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

    private float timer;

    [SerializeField]
    private float timerStart = 120.0f;
    private bool timerActive = false;
    public Text timerText;

    [SerializeField]
    private Text balanceText;

    private int balance;

    // Use this for initialization
    void Start()
    {
        setBalance(0);

        // Initializes timer value
        ResetTimer();

        StartCoroutine(SpawnBalloons());
		StartCoroutine (tickingTimer());


        // TODO: Move this to correct location
        SetTimerActive(true);


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

            spawnedBalloon.GetComponent<Balloon>().InitializeBalloon((Balloon.BalloonType)randomBalloonType, this);

            yield return new WaitForSeconds(spawnDelay);


        }
    }

    public void SetTimerActive(bool active)
    {

        timerActive = active;

    }

	IEnumerator tickingTimer() {

        while (true)
        {

            if (timerActive)
            {

                if (timer > 0)
                {

                    AddToTimer(-Time.deltaTime);

                }
            }

            yield return null;

        }

		// if EARN_MONEY then subtract 10 seconds - do these go under function InitializeBalloon()?
		// if SPEND_POSITIVE then add 10 seconds
		// if SPEND_NEGATIVE then subtract 10 seconds
	}

    public void AddToTimer(float timerDelta)
    {

        SetTimer(timer + timerDelta);

    }

    public void UpdateTimer()
    {

        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        string time = string.Format("{0:0}:{1:00}", minutes, seconds);

        timerText.text = time;
    }

    public void SetTimer(float value)
    {

        if (value > 0)
        {

            timer = value;

        }
        else
        {

            timer = 0;
            OnTimerDone();

        }

        UpdateTimer();


    }

    public void ResetTimer()
    {

        SetTimer(timerStart);     

    }

    public void OnTimerDone()
    {

        // Do stuff when the timer is done


    }

    public void setBalance(int value)
    {
        balance = value;
        if (balance >= 0)
        {
            balanceText.text = "$" + balance;
        }
        else
        {
            balanceText.text = "-$" + -balance;
         }
    }

    public void addBalance(int valueAdd)
    {

        setBalance(balance + valueAdd);
    }
}
