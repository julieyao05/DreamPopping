using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	[SerializeField]
	private Object balloonPrefab;

	void Start()
	{
		StartCoroutine(potentialGoals());
	}

	// Update is called once per frame
	void Update () {

	}

	public enum BalloonType
	{
		SELECT_GOAL
	};

	public BalloonType type;

	public void InitializeBalloon(BalloonType type)
	{

		this.type = type;

		string newText = "";

		newText = TextOptions.goalOptions [Random.Range (0, TextOptions.goalOptions.Length)];


		UpdateText (newText);

	}

    public void UpdateText(string newText)
    {

        TextMesh balloonTextInChild = GetComponentInChildren<TextMesh>();

        balloonTextInChild.text = newText;

    } 

	private IEnumerator potentialGoals()
	{

		while (true) {

			Vector2 staticPosition1 = new Vector2 (5, 20);		// Balloon on top-left, how to figure out x and y points?

			Vector2 staticPosition2 = new Vector2 (20, 20);		// Balloon on top-right

			Vector2 staticPosition3 = new Vector2 (11, 10);		// Balloon on bottom-center

			GameObject staticBalloon1 = GameObject.Instantiate (balloonPrefab, staticPosition1, Quaternion.identity) as GameObject;

			GameObject staticBalloon2 = GameObject.Instantiate (balloonPrefab, staticPosition2, Quaternion.identity) as GameObject;

			GameObject staticBalloon3 = GameObject.Instantiate (balloonPrefab, staticPosition3, Quaternion.identity) as GameObject;
		}
	}
}