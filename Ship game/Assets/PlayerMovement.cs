using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public new Rigidbody rigidbody;
    private float speedBoost = 100000;
    [Range(0,1)]
    public float speedFactor = 0.5f;
    [Range(0.8f, 0.1f)]
    public float stopFactor = 0.5f;
    private Vector3 moveUp = new Vector3(0, 0, 1);
    private Vector3 moveDown = new Vector3(0, 0, -1);
    private Vector3 moveLeft = new Vector3(-1, 0, 0);
    private Vector3 moveRight = new Vector3(1, 0, 0);
    private Vector3 forceToAdd = new Vector3(0, 0, 0);
	private Vector3 velocityMask;
	private Vector3 newVelocity;
	
	void FixedUpdate () {
        forceToAdd = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
			forceToAdd += moveUp;
		}
        if (Input.GetKey(KeyCode.S))
        {
			forceToAdd += moveDown;
		}
        if (Input.GetKey(KeyCode.A))
        {
			forceToAdd += moveLeft;
		}
        if (Input.GetKey(KeyCode.D))
        {
            forceToAdd += moveRight;
        }
        forceToAdd.Normalize();

        rigidbody.AddForce(forceToAdd * Time.fixedDeltaTime * speedBoost * speedFactor);
		newVelocity = rigidbody.velocity * stopFactor;
		velocityMask.Set(1, 1 / stopFactor, 1);
		newVelocity.Scale(velocityMask);
		rigidbody.velocity = newVelocity;
	}

    private void OnTriggerEnter(Collider other)
    {
        speedFactor = 0.2f;
    }

    private void OnTriggerExit(Collider other)
    {
        speedFactor = 0.7f;
    }
}
