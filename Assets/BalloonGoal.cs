using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BalloonGoal : MonoBehaviour
{
    private int value;

    public int goalAmount;

    void Start()
    {

        InitializeBalloon();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InitializeBalloon()
    {
        string newText = "";

        int randomVal = Random.Range(0, TextOptions.goalOptions.Length);

        newText = TextOptions.goalOptions[randomVal].Key;
        goalAmount = TextOptions.goalOptions[randomVal].Value;

        UpdateText(newText);

    }

    public void UpdateText(string newText)
    {

        TextMesh balloonTextInChild = GetComponentInChildren<TextMesh>();

        balloonTextInChild.text = newText;

    }

    public void OnGoalClick()
    {

        Goal.gameGoal = goalAmount;

        SceneManager.LoadScene("GameScene");

    }
}