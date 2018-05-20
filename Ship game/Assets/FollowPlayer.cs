using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public GameObject player;
    [SerializeField]
    private Vector3 cameraOffset = new Vector3(0, 30, -30);
    public float viewOffset;
    [Range(0,1)]
    public float smoothSpeed = 0.125f;
    public bool enable = true;
    private Vector3 moveUp = new Vector3(0, 0, 1);
    private Vector3 moveDown = new Vector3(0, 0, -1);
    private Vector3 moveLeft = new Vector3(-1, 0, 0);
    private Vector3 moveRight = new Vector3(1, 0, 0);
    private Vector3 goDirection = new Vector3(0, 0, 0);

	
	// Update is called once per frame
	void FixedUpdate () {
        goDirection = Vector3.zero;
        if (enable)
        {
            if (Input.GetKey(KeyCode.W))
            {
                goDirection = goDirection + moveUp;
            }
            if (Input.GetKey(KeyCode.S))
            {
                goDirection = goDirection + moveDown;
            }
            if (Input.GetKey(KeyCode.A))
            {
                goDirection = goDirection + moveLeft;
            }
            if (Input.GetKey(KeyCode.D))
            {
                goDirection = goDirection + moveRight;
            }
            goDirection.Normalize();
        }
        Vector3 desiredPosition = player.transform.position + cameraOffset + (viewOffset * goDirection);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * 10 * Time.deltaTime);
        transform.position = smoothedPosition;
        
    }
}
