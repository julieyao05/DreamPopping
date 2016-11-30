using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	[SerializeField]
	private Object balloonPrefab;

    private int value;

	public int goalAmount;

	void Start()
	{
        createGoals();
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

        int randomVal = Random.Range(0, TextOptions.goalOptions.Length);


        newText = TextOptions.goalOptions[randomVal].Key;
        goalAmount = TextOptions.goalOptions[randomVal].Value;

        UpdateText (newText);

	}

    public void UpdateText(string newText)
    {

        TextMesh balloonTextInChild = GetComponentInChildren<TextMesh>();

        balloonTextInChild.text = newText;

    } 

    public void createGoals()
    {
        Vector2 staticPosition1 = new Vector2(5, 20);       // Balloon on top-left

        Vector2 staticPosition2 = new Vector2(20, 20);      // Balloon on top-right

        Vector2 staticPosition3 = new Vector2(11, 10);      // Balloon on bottom-center

        GameObject staticBalloon1 = GameObject.Instantiate(balloonPrefab, staticPosition1, Quaternion.identity) as GameObject;

        GameObject staticBalloon2 = GameObject.Instantiate(balloonPrefab, staticPosition2, Quaternion.identity) as GameObject;

        GameObject staticBalloon3 = GameObject.Instantiate(balloonPrefab, staticPosition3, Quaternion.identity) as GameObject;

    }
}