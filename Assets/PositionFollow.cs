using UnityEngine;
using System.Collections;

public class PositionFollow : MonoBehaviour {

	public Transform FollowTarget;

	// Update is called once per frame
	void Update () {
		if (FollowTarget != null) 
		{
			this.transform.position = FollowTarget.position;
		}
	}
}
