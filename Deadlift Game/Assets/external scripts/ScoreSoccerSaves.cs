using UnityEngine;
using System.Collections;

public class ScoreSoccerSaves : MonoBehaviour {
	public string levelToLoad;
	GUIText text;
	public float score = 0;
	// Use this for initialization
	void Start () {
		text = GetComponent<GUIText> ();
		text.text = "Saves: " + score.ToString ();
	}
	

	public void IncrementScore () {
		score ++;
		text.text = "Saves: " + score.ToString ();
		if (score >= 100) {
			text.text = "You saved 100 shots!";
		}
	}
}
