using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    // This is to define the rigidbody that this code will be applied to and named it.
    private Rigidbody2D rb2d;
	// Use this for initialization
	void Start ()
    {
        // rb2d will be the rigidbody 2d because we got that component.
        //rb2d will have a velocity by using the GameControl script that we wrote before by using the Instance of that class which inhearated everything
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameControl.Instance.scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        // this checks if the isGameOver form the GameControl script is now true and if so the scrolling of the sprites stops.
		if(GameControl.Instance.isGameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
	}
}
