using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour {
	[SerializeField]Transform target;
	[SerializeField]Vector3 defaultDistance = new Vector3(0f, 2f, -10f);
	[SerializeField]float distanceDamp = 10f;
	Vector3 velocity = Vector3.one;

	void LateUpdate () {
		Vector3 toPosition = target.position + (target.rotation * defaultDistance);
		Vector3 currentPosition = Vector3.SmoothDamp(transform.position, toPosition, ref velocity, distanceDamp);

		transform.position = currentPosition;
		transform.LookAt(target, target.up);
	}
}
