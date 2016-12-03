using UnityEngine;
using System.Collections;

public class GoalSpawner : MonoBehaviour {

    [SerializeField]
    private Object balloonPrefab;

    // Use this for initialization
    void Start () {

        createGoals();

    }

    // Update is called once per frame
    void Update () {
	
	}


    public void createGoals()
    {
        Vector2 staticPosition1 = new Vector2(5, 20);       // Balloon on top-left

        Vector2 staticPosition2 = new Vector2(20, 20);      // Balloon on top-right

        Vector2 staticPosition3 = new Vector2(11, 10);      // Balloon on bottom-center

        GameObject staticBalloon1 = GameObject.Instantiate(balloonPrefab, staticPosition1, Quaternion.identity) as GameObject;

        staticBalloon1.GetComponent<BalloonGoal>().InitializeBalloon();

        GameObject staticBalloon2 = GameObject.Instantiate(balloonPrefab, staticPosition2, Quaternion.identity) as GameObject;

        staticBalloon2.GetComponent<BalloonGoal>().InitializeBalloon();

        GameObject staticBalloon3 = GameObject.Instantiate(balloonPrefab, staticPosition3, Quaternion.identity) as GameObject;

        staticBalloon3.GetComponent<BalloonGoal>().InitializeBalloon();

    }
}
