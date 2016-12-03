using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Text>().text = "Goal: " + Goal.gameGoal;
        Debug.Log("Started");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
