using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public new Rigidbody rigidbody;
    private float speedBoost = 100000;
    [Range(0,1)]
    public float speedFactor = 0.5f;
    [Range(1, 0)]
    public float stopFactor = 0.5f;
    private Vector3 moveUp = new Vector3(0, 0, 1);
    private Vector3 moveDown = new Vector3(0, 0, -1);
    private Vector3 moveLeft = new Vector3(-1, 0, 0);
    private Vector3 moveRight = new Vector3(1, 0, 0);
    private Vector3 forceToAdd = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        forceToAdd = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            forceToAdd = forceToAdd + (moveUp * Time.deltaTime * speedBoost * speedFactor);
        }
        if (Input.GetKey(KeyCode.S))
        {
            forceToAdd = forceToAdd + (moveDown * Time.deltaTime * speedBoost * speedFactor);
        }
        if (Input.GetKey(KeyCode.A))
        {
            forceToAdd = forceToAdd + (moveLeft * Time.deltaTime * speedBoost * speedFactor);
        }
        if (Input.GetKey(KeyCode.D))
        {
            forceToAdd = forceToAdd + (moveRight * Time.deltaTime * speedBoost * speedFactor);
        }
        forceToAdd.Normalize();

        rigidbody.AddForce(forceToAdd * Time.deltaTime * speedBoost * speedFactor);
        rigidbody.velocity = rigidbody.velocity * stopFactor;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger: " + other.name);
        speedFactor = 0.03f;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("release: " + other.name);
        speedFactor = 0.3f;
    }
}
