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
    private float timer;

    [SerializeField]
    private float timerStart = 120.0f;
    private bool timerActive = false;
    public Text timerText;

    [SerializeField]
    private Text balanceText;

    [SerializeField]
    private GameObject balanceWarning;

    [SerializeField]
    private GameObject balanceDefinition;

    private bool warningDone = false;

    private int balance;

  

    public static bool popped = false;

    public bool paused = false;

    // Use this for initialization
    void Start()
    {

        BalloonSpawner.popped = false;

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

		while( balance < BalloonGoal.goalAmount && timer >= 0)

		{	
			//float xPos = Random.Range(xMin, xMax);
		
			var xPos = -4;
			var textOption = 0;
			for(var count=0; count<3; count++)
			{
				Vector2 spawnPosition = new Vector2 (xPos, yHeight);

				GameObject spawnedBalloon = GameObject.Instantiate(balloonPrefab, spawnPosition, Quaternion.identity) as GameObject;
				spawnedBalloon.tag = "Respawn";
				if (count == 0) {
					textOption = 0;
				} else if (count == 1) {
					textOption = 1;
				} else {
					textOption = 2;
				}

				spawnedBalloon.GetComponent<Balloon>().InitializeBalloon((Balloon.BalloonType)textOption, this);
				spawnedBalloon.transform.localScale = new Vector3 (4F, 4F, transform.localScale.z);

				xPos = xPos + 4;
			}

            float timePassed = 0.0f;

            while (timePassed < 8.0f && !popped)
            {
                timePassed += Time.deltaTime;
                yield return null;
            }

            popped = false;



            /*
            if (timer < 0)
            {
                // redirect to final page
            }
            // redirect to final page
            else if (balance >= goalAmount)
            {
                // Redirect to Congratulations page
            } 

			*/
        }

        
		if (timer >= 0 && balance >= BalloonGoal.goalAmount) {
			
			Application.LoadLevel("GameWon");
		} else if(timer==0 && balance < BalloonGoal.goalAmount){
			Application.LoadLevel("GameLost");
		}
		/*if (timer > 0 && balance >= BalloonGoal.goalAmount) {

			buttonsLogic.ChangeScene("GameWon");
		} else {
			buttonsLogic.ChangeScene ("GameLost");
		}*/
       
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

                if (timer > 0 && !paused)
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
            balanceText.text = "Balance $" + balance;
        }
        else
        {
            ToggleBalanceWarning(true);
            balanceText.text = "Owe $" + -balance;
         }
    }

    public void addBalance(int valueAdd)
    {

        setBalance(balance + valueAdd);
    }
    
    public void ToggleBalanceWarning(bool active)
    {
        if (!active)
        {
            balanceWarning.SetActive(active);

            paused = false;

            return;
        }

        if (active && !warningDone)
        {

            paused = true;

            balanceWarning.SetActive(active);

            warningDone = true;

        }
    }
}
