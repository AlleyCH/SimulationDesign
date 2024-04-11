using UnityEngine;
using System.Collections;

public class ActiveStateToggler : MonoBehaviour {
	public RocketshipController controls;
	public void ToggleActive () {
		controls.enabled = !gameObject.activeSelf;
		gameObject.SetActive (!gameObject.activeSelf);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
}
