//RandomRotator.cs
using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
	public float tumble;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		// gives a random 3D vector for the velocity for the Asteroid
		rb.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}
