using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
	public GameObject corkPrefab;
	public GameObject PointBlockPrefab;
	public GameObject launchPoint;
	public float firePower = 100;
	public float shakeAmount = 2;

	Vector3 origin;
	Vector3 shake;
	Vector3 rotation;

	void Start() {
		Screen.lockCursor = true;
		origin = transform.eulerAngles;
		rotation = origin;
	}

	void PerformAiming ()
	{
		transform.eulerAngles = rotation + shake;
	}

	void FireCork ()
	{
		var g = Instantiate (corkPrefab, launchPoint.transform.position, launchPoint.transform.rotation) as GameObject;
		g.rigidbody.AddRelativeForce (Vector3.forward * firePower);
	}

	void FirePointBlock ()
	{
		var g = Instantiate (PointBlockPrefab, launchPoint.transform.position, launchPoint.transform.rotation) as GameObject;
		g.rigidbody.AddRelativeForce (Vector3.forward * firePower);
	}

	void CheckForShoot ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			FireCork();
		}
		if (Input.GetButtonDown ("Fire2")) {
			FirePointBlock();
		}
	}


	void GunShake ()
	{
		shake.x = Mathf.Sin (Time.time) * shakeAmount;
		shake.y = Mathf.Cos (Time.time) * shakeAmount;
	}

	void Update () {
		GunShake ();
		PerformAiming ();
		CheckForShoot ();
	}
}
