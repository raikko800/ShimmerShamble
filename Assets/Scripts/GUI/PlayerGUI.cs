using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerGUI : MonoBehaviour {
	public Vector2 screenOffsetControls = Vector2.zero;

	public GameObject controls;

	void Start () {
		screenOffsetControls *= UIHandler.ScreenScale;

		PlaceGUI();
	}

	private void PlaceGUI() {
		Vector3 scale = new Vector3((controls.transform.localScale.x * UIHandler.ScreenScale), (controls.transform.localScale.y * UIHandler.ScreenScale), 1);
		Vector3 controlsPosition = Vector3.zero;

		float controlPosX = (0 + (Screen.width / 2) + screenOffsetControls.x);
		float controlPosY = (0 + (Screen.height / 2) + screenOffsetControls.y);

		controlsPosition.x = controlPosX;
		controlsPosition.y = controlPosY;

		controls.transform.position = controlsPosition;
		controls.transform.localScale = scale;
	}
}