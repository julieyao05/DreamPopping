using UnityEngine;
using System.Collections;

public class BalloonInputHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);

            if (hit)
            {

                if (hit.collider.GetComponent<Balloon>())
                {

                    hit.collider.GetComponent<Balloon>().OnBalloonClick();
                    BalloonSpawner.popped = true;

                }
            }
        }
    }

}
