using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

    public enum BalloonType
    {
        SPEND_POSITIVE,
        SPEND_NEGATIVE,
        EARN_MONEY
   };


    public BalloonType type;

    public int value;

    private string balloonText;

    private float floatTime = 10.0f;

    private BalloonSpawner spawner;
	
	// Update is called once per frame
	void Update () {
	
	}


    public void InitializeBalloon(BalloonType type, BalloonSpawner spawner)
    {

        this.type = type;

        this.spawner = spawner;

        string newText = "";

        if (type == Balloon.BalloonType.EARN_MONEY)
        {

            int randomIndex = Random.Range(0, TextOptions.earnOptions.Length);

            newText = TextOptions.earnOptions[randomIndex].Key;
            value = TextOptions.earnOptions[randomIndex].Value;
        }

        if (type == Balloon.BalloonType.SPEND_POSITIVE)
        {

            int randomIndex = Random.Range(0, TextOptions.positiveOptions.Length);

            newText = TextOptions.positiveOptions[randomIndex].Key;
            value = TextOptions.positiveOptions[randomIndex].Value;
        }

        if (type == Balloon.BalloonType.SPEND_NEGATIVE)
        {

            int randomIndex = Random.Range(0, TextOptions.negativeOptions.Length);

            newText = TextOptions.negativeOptions[randomIndex].Key;
            value = TextOptions.negativeOptions[randomIndex].Value;
        }

        UpdateText(newText);

        StartCoroutine(Float());

    }

    public IEnumerator Float()
    {

        Vector2 startPosition = this.transform.position;
        Vector2 endPosition = startPosition;
        endPosition.y += 25.0f;

        for (float i = 0; i < floatTime; i+= Time.deltaTime)
        {

            Vector2 floatPosition = Vector2.Lerp(startPosition, endPosition, i / floatTime);

            this.transform.position = floatPosition;

            yield return null;

        }

        Destroy(this.gameObject);

    }
    
    public void UpdateText(string newText)
    {

        TextMesh balloonTextInChild = GetComponentInChildren<TextMesh>();

        balloonTextInChild.text = newText;
    }

    /// <summary>
    /// Called when the balloon is clicked or pressed by a user.
    /// </summary>
    public void OnBalloonClick()
    {
       // Debug.Log("Pressed");

        switch (type)
        {

			case BalloonType.EARN_MONEY:
				spawner.AddToTimer (-10.0f);
				spawner.addBalance (value);
				break;

            case BalloonType.SPEND_NEGATIVE:

                spawner.AddToTimer(-10.0f);
                spawner.addBalance(-value);
                break;

            case BalloonType.SPEND_POSITIVE:

                spawner.AddToTimer(10.0f);
                spawner.addBalance(-value);
                break;

        }
		var balloons = GameObject.FindGameObjectsWithTag("Respawn");
		foreach (GameObject o in balloons) {
			Destroy(o);
		}

    }
    /*
	if() {
		StartCoroutine(ShowMessage("Your 'balance' or 'budget' is the amount of money you have in your bank account.", pause game));
	}

	IEnumerator ShowMessage (string message, float delay) {
		guiText.text = message;
		guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		guiText.enabled = false;
	}
    */
}
