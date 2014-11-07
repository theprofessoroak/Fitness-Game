using UnityEngine;
using System.Collections;

public class BackStraight : MonoBehaviour
{
	public bool EndTrigger1;
	public bool EndTrigger2;
	public bool EndTrigger3;
		public AudioClip BackCheck;
		public bool StraightBack;


	
		void OnTriggerEnter (Collider c) 
		{
				if (c.gameObject.CompareTag ("UpperSpine")) {
						EndTrigger1 = true;
						Debug.Log (EndTrigger1);
			if (EndTrigger1 && EndTrigger2 && EndTrigger3) {
				audio.loop = true;
				audio.clip = BackCheck;
				audio.Play ();
			}
				}
				if (c.gameObject.CompareTag ("Spine")) {
				
						EndTrigger2 = true;
						Debug.Log (EndTrigger2);
			if (EndTrigger1 && EndTrigger2 && EndTrigger3) {
				audio.loop = true;
				audio.clip = BackCheck;
				audio.Play ();
			}
				}
				if (c.gameObject.CompareTag ("Hip")) {
						EndTrigger3 = true;
						Debug.Log (EndTrigger3);
			if (EndTrigger1 && EndTrigger2 && EndTrigger3) {
				audio.loop = true;
				audio.clip = BackCheck;
				audio.Play ();
			}
				}		

			
		if (EndTrigger1 && EndTrigger2 && EndTrigger3) {
						audio.loop = true;
						audio.clip = BackCheck;
						audio.Play ();
				}

		}


	void OnTriggerExit (Collider c) 
	{
		if (c.gameObject.CompareTag ("UpperSpine")) {
			EndTrigger1 = false;
			Debug.Log (EndTrigger1);
			audio.loop = false;
			audio.clip = BackCheck;
			audio.Stop ();
		}
		if (c.gameObject.CompareTag ("Spine")) {
			
			EndTrigger2 = false;
			Debug.Log (EndTrigger2);
			audio.loop = false;
			audio.clip = BackCheck;
			audio.Stop ();
		}
		if (c.gameObject.CompareTag ("Hip")) {
			EndTrigger3 = false;
			Debug.Log (EndTrigger3);
			audio.loop = false;
			audio.clip = BackCheck;
			audio.Stop ();
		}	

}
}



		//	void Update () 
//	{
//		if (this.gameObject.CompareTag ("UpperSpine")) {
//			EndTrigger1 = true;
//			Debug.Log (EndTrigger1);
//		}
//		if (this.gameObject.CompareTag ("Spine")) {
//			
//			EndTrigger2 = true;
//			Debug.Log (EndTrigger2);
//		}
//		if (this.gameObject.CompareTag ("Hip")) {
//			EndTrigger3 = true;
//			Debug.Log (EndTrigger3);
//		}		
//		
//		
//		if (EndTrigger1 && EndTrigger2 && EndTrigger3) 
//		{
//			StraightBack = true;
//		}
//		else 
//		{
//			StraightBack = false;	
//		}
//
//
//
//		if (StraightBack == true) {
//		
//			audio.loop = true; audio.clip = BackCheck; audio.Play();
//
//		if (StraightBack == false) {
//
//				audio.loop = false;	audio.Stop();
//
//		}
//	}
//	}

