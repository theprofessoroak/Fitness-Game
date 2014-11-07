using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {
	public string levelToLoad;
	GUIText text;
	public float score = 0;
	// Use this for initialization
	void Start () {
		text = GetComponent<GUIText> ();
		text.text = "Score: " + score.ToString ();
	}
	

	public void IncrementScore () {
		score ++;
		text.text = "Score: " + score.ToString ();
		if (score == 100) {
			text.text = "you hit 100 blocks";
		}
	}
}
