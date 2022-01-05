using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Transform go1;
    [SerializeField] private Transform go2;
    [SerializeField] private Transform target;
    public float moveSpeed = 3f;

    void Update()
    {
        /* move the object towards the origin */
        MoveTowardsTarget(go1, Vector3.zero);

        /* move the object towards the target */
        MoveTowardsTarget(go2, target.position);
    }

	private void MoveTowardsTarget(Transform go, Vector3 targetPosition) {
		Vector3 currentPosition = go.position;

		/* first, check to see if we're close enough to the target */
		/* this check prevents us from oscillating back and forth over the target */
		/* if we're farther than 1 unit away, do the movement, otherwise do nothing */
		if(Vector3.Distance(currentPosition, targetPosition) > 1) { 
			
			/* get the direction we need to go by subtracting the current position from the target position */
			Vector3 directionOfTravel = targetPosition - currentPosition;

			/* now normalize the direction, since we only want the direction information */
			// directionOfTravel = (targetPosition - currentPosition).normalized;
			directionOfTravel.Normalize();
			
			/* now move at the specified speed in the direction of travel */
			/* scale the movement on each axis by the directionOfTravel vector components */
			go.Translate(
				(directionOfTravel.x * moveSpeed * Time.deltaTime),
				(directionOfTravel.y * moveSpeed * Time.deltaTime),
				(directionOfTravel.z * moveSpeed * Time.deltaTime),
				Space.World);
		}
	}       

}
