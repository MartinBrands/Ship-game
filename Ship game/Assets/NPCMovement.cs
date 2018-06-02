using UnityEngine;

public class NPCMovement : MonoBehaviour {

    public new Rigidbody rigidbody;
    private float speedBoost = 100000;
    [Range(0,1)]
    public float speedFactor = 0.5f;
	[Range(0.8f, 0.1f)]
	public float stopFactor = 0.5f;
    private Vector3 forceToAdd = new Vector3(0, 0, 0);
	private Vector3 velocityMask;
	private Vector3 newVelocity;

	public Transform player;


	void FixedUpdate () {
        forceToAdd = Vector3.zero;

		forceToAdd = player.position - transform.position;

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
