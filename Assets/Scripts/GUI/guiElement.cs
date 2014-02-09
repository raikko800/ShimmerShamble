using UnityEngine;
using System.Collections;

public class guiElement : MonoBehaviour {
	public bool top;
	public bool left;
	public bool centerX;
	public bool centerY;

	public Vector2 screenOffset = Vector2.zero;

	public bool Top {
		get { return top; }
		set { top = value; }
	}

	public bool Left {
		get { return left; }
		set { left = value; }
	}

	public bool CenterX {
		get { return centerX; }
		set { centerX = value; }
	}

	public bool CenterY {
		get { return centerY; }
		set { centerY = value; }
	}

	public Vector2 ScreenOffset {
		get { return screenOffset; }
		set { screenOffset = value; }
	}
}
