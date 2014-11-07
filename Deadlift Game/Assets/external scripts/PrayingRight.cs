using UnityEngine;
using System.Collections;

public class PrayingRight : MonoBehaviour
{

	public string levelToLoad;
	public bool EndTrigger1;
	public bool EndTrigger2;

	void Start () {
		Screen.showCursor = true;
		Screen.lockCursor = true;
		Screen.lockCursor = false;
		Screen.showCursor = true;
	}




	void FixedUpdate () 
	{
		Screen.showCursor = true;
	}

	void OnTriggerEnter (Collider c) 
	{
		if (c.gameObject.CompareTag ("Player")) {
			EndTrigger1 = true;
			Debug.Log (EndTrigger1);
		}
		if (c.gameObject.CompareTag ("Player2")) {
			
			EndTrigger2 = true;
		}
		if(EndTrigger1 && EndTrigger2)
		{
			Application.LoadLevel (levelToLoad);

		}

}



}
