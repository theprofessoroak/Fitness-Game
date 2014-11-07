using UnityEngine;
using System.Collections;

public class EatNanchos : MonoBehaviour {

	public ScoreController score;

		void OnTriggerEnter (Collider c)
		{

				if (c.gameObject.CompareTag ("Nancho")) {
				score.IncrementScore ();
				Destroy(c.gameObject);
						
				}
		
		}
	
}
