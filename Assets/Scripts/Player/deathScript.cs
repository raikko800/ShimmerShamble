using UnityEngine;
using System.Collections;

public class deathScript : MonoBehaviour {
	public void Restart() {
		Application.LoadLevel("Level");
	}
}
