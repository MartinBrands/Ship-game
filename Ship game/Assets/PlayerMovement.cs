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
            //rigidbody.AddForce(moveUp * Time.deltaTime * speedBoost * speedFactor);
            forceToAdd = forceToAdd + (moveUp * Time.deltaTime * speedBoost * speedFactor);
            //transform.Translate(moveUp * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveUp * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            forceToAdd = forceToAdd + (moveDown * Time.deltaTime * speedBoost * speedFactor);
            //rigidbody.AddForce(moveDown * Time.deltaTime * speedBoost * speedFactor);
            //transform.Translate(moveDown * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveDown * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            forceToAdd = forceToAdd + (moveLeft * Time.deltaTime * speedBoost * speedFactor);
            //rigidbody.AddForce(moveLeft * Time.deltaTime * speedBoost * speedFactor);
            //transform.Translate(moveLeft * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveLeft * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            forceToAdd = forceToAdd + (moveRight * Time.deltaTime * speedBoost * speedFactor);
            //rigidbody.AddForce(moveRight * Time.deltaTime * speedBoost * speedFactor);
            //transform.Translate(moveRight * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveRight * Time.deltaTime;
        }
        forceToAdd.Normalize();

        rigidbody.AddForce(forceToAdd * Time.deltaTime * speedBoost * speedFactor);
        rigidbody.velocity = rigidbody.velocity * stopFactor;
    }
}
