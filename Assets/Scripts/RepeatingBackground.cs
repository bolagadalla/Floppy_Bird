using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

	// Use this for initialization
	void Start ()
    {
        // This is equalling the groundCollider to the BoxCollider2D class which then becomes and Instance of that class and inharating all of its functions and variables
        groundCollider = GetComponent<BoxCollider2D>(); // this is a refrance point of the BoxCollider2D class
        // the size is a variable of the class BoxCollider2D
        groundHorizontalLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
	}
    /// <summary>
    /// It will reposition the background to have the effect of a loop
    /// </summary>
    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
