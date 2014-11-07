using UnityEngine;
using System.Collections;

public class SoccerSaves : MonoBehaviour {

	public ScoreSoccerSaves saves;

		void OnTriggerEnter (Collider c)
		{

				if (c.gameObject.CompareTag ("Nancho")) {
				saves.IncrementScore ();
				Destroy(c.gameObject);
						
				}
		
		}
	
}
