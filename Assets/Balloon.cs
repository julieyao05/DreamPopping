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

    private string balloonText;

    private float floatTime = 10.0f;
	
	// Update is called once per frame
	void Update () {
	
	}


    public void InitializeBalloon(BalloonType type)
    {

        this.type = type;

        string newText = "";

        if (type == Balloon.BalloonType.EARN_MONEY)
        {
            newText = TextOptions.earnOptions[Random.Range(0, TextOptions.earnOptions.Length)];
        }

        if (type == Balloon.BalloonType.SPEND_POSITIVE)
        {
            newText = TextOptions.positiveOptions[Random.Range(0, TextOptions.positiveOptions.Length)];
        }

        if (type == Balloon.BalloonType.SPEND_NEGATIVE)
        {
            newText = TextOptions.negativeOptions[Random.Range(0, TextOptions.negativeOptions.Length)];
        }

        UpdateText(newText);

        StartCoroutine(Float());

    }

    public IEnumerator Float()
    {

        Vector2 startPosition = this.transform.position;
        Vector2 endPosition = startPosition;
        endPosition.y += 20.0f;

        for (float i = 0; i < floatTime; i+= Time.deltaTime)
        {

            Vector2 floatPosition = Vector2.Lerp(startPosition, endPosition, i / floatTime);

            this.transform.position = floatPosition;

            yield return null;

        }
    }
    
    public void UpdateText(string newText)
    {

        TextMesh balloonTextInChild = GetComponentInChildren<TextMesh>();

        balloonTextInChild.text = newText;




    } 
}
