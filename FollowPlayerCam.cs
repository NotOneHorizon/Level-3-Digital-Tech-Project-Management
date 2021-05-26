using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCam : MonoBehaviour
{
    public float DampTime = 10f;
    public Transform Player;
    public float XOffset = 0;
    public float YOffset = 0;

	private float margin = 0.1f;
	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (Player)
		{
			float targetX = Player.position.x + XOffset;
			float targetY = Player.position.y + YOffset;

			if (Mathf.Abs(transform.position.x - targetX) > margin)
				targetX = Mathf.Lerp(transform.position.x, targetX, 1 / DampTime * Time.deltaTime);

			if (Mathf.Abs(transform.position.y - targetY) > margin)
				targetY = Mathf.Lerp(transform.position.y, targetY, DampTime * Time.deltaTime);

			transform.position = new Vector3(targetX, targetY, transform.position.z);
		}
	}
}
