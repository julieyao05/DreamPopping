using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {


	public void InitializeBalloon(BalloonType type)
	{

		this.type = type;

		string newText = "";

		newText = TextOptions.goalOptions [Random.Range (0, TextOptions.goalOptions.Length)];


		UpdateText (newText);

		StartCoroutine (Float ());
	}

    public void UpdateText(string newText)
    {

        TextMesh balloonTextInChild = GetComponentInChildren<TextMesh>();

        balloonTextInChild.text = newText;

    } 

	Vector2 staticPosition1 = new Vector2(5, 20);		// Balloon on top-left

	Vector2 staticPosition2 = new Vector2(20, 20);		// Balloon on top-right

	Vector2 staticPosition3 = new Vector2(11, 10);		// Balloon on bottom-center

	GameObject staticBalloon1 = GameObject.Instantiate(balloonPrefab, staticPosition1, Quaternion.identity) as GameObject;

	GameObject staticBalloon2 = GameObject.Instantiate(balloonPrefab, staticPosition2, Quaternion.identity) as GameObject;

	GameObject staticBalloon3 = GameObject.Instantiate(balloonPrefab, staticPosition3, Quaternion.identity) as GameObject;
}