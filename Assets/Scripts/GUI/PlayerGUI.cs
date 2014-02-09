using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerGUI : MonoBehaviour {
	public Vector2 screenOffsetControls = Vector2.zero;
	public Vector2 screenOffsetHullIcon = Vector2.zero;

	public GameObject controls;
	public GameObject hullIcon;

	private Dictionary<GameObject, Vector2> guiElements;

	void Start () {
		guiElements = new Dictionary<GameObject, Vector2>();

		guiElements.Add(controls, screenOffsetControls);
		guiElements.Add (hullIcon, screenOffsetHullIcon);

		var keys = new List<GameObject>(guiElements.Keys);

		foreach(var key in keys) {
			guiElements[key] *= UIHandler.ScreenScale;
		}

		PlaceGUI();
	}

	private void PlaceGUI() {
		Vector3 scale = new Vector3((controls.transform.localScale.x * UIHandler.ScreenScale), (controls.transform.localScale.y * UIHandler.ScreenScale), 1);

		foreach(KeyValuePair<GameObject, Vector2> element in guiElements) {
			guiElement elementScript = element.Key.GetComponent<guiElement>();

			Vector3 elementPosition = Vector3.zero;

			elementPosition.x = PlaceGUIElementHorizontal	(element.Value.x, elementScript.left, elementScript.centerX);
			elementPosition.y = PlaceGUIElementVertical		(element.Value.y, elementScript.top, elementScript.centerY);

			element.Key.transform.localPosition = elementPosition;
			element.Key.transform.localScale 	= scale;
		}
	}

	private float PlaceGUIElementHorizontal (float screenOffset, bool left, bool centerX)
	{
		if(centerX)
			return 0f;

		float xPosition;

		if(left) {
			xPosition = (0 - (Screen.width / 2) + screenOffset);
		} else {
			xPosition = (0 + (Screen.width / 2) - screenOffset);
		}

		return xPosition;
	}

	private float PlaceGUIElementVertical (float screenOffset, bool top, bool centerY)
	{
		if(centerY)
			return 0f;

		float yPosition;

		if(top) {
			yPosition = (0 + (Screen.height / 2) + screenOffset);
		} else {
			yPosition = (0 - (Screen.height / 2) + screenOffset);
		}

		return yPosition;
	}
}