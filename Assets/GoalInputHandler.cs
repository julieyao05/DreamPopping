using UnityEngine;
using System.Collections;

public class GoalInputHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update () {

		if (Input.GetMouseButtonDown(0))
		{

			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);

			if (hit)
			{

				if (hit.collider.GetComponent<BalloonGoal>())
				{
					hit.collider.GetComponent<BalloonGoal>().OnGoalClick();
				}
			}
		}
	}
}
