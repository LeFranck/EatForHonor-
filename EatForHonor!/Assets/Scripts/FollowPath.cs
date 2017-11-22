using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour {

	// Use this for initialization
	public PathRail path;
	public int speed;
	private int current = 0;

	// Update is called once per frame
	void Update ()
	{
		if (transform.position != path.points [current].position) 
		{
			Vector2 pos = Vector2.MoveTowards (transform.position, path.points [current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody2D> ().MovePosition (pos);
		} 
		else if(current == path.Npoints-1)
		{
			Destroy (this);
		}
		else
		{
			current += 1;
		}
	}

}
