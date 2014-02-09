using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour {
	private Player player;
	private Vector3 lastMousePosition;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

		lastMousePosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		CheckMouseInput();
	}

	private void CheckMouseInput() {
		if(Input.GetMouseButton(0)) {

			if(CheckMovingHalf()) {
				if(lastMousePosition != Vector3.zero) {
					Vector3 tempMousePos = Input.mousePosition;
					float dragY = tempMousePos.y - lastMousePosition.y;
					player.SetVerticalPosition(dragY);
				}
			} else {
				//which icon is clicked?
			}

			lastMousePosition = Input.mousePosition;
		}
	}

	private bool CheckMovingHalf() {
		if(Input.mousePosition.x <= Screen.width / 2) {
			return true;
		}
		return false;
	}
}