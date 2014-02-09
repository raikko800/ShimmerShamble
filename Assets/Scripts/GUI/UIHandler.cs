using UnityEngine;
using System.Collections;

public class UIHandler : MonoBehaviour {
	public Vector2 defaultResolution = new Vector2(1600, 1200);
	private static float screenScale;

	void Awake() {
		CalculateScreenScale();
	}

	private void CalculateScreenScale() {
		float widthScale  = Screen.width / defaultResolution.x;
		float heightScale = Screen.height / defaultResolution.y;

		if(widthScale > heightScale) {
			screenScale = widthScale;
		} else {
			screenScale = heightScale;
		}
	}

	public static float ScreenScale {
		get {
			return screenScale;
		}
	}
}