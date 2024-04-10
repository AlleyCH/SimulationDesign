using UnityEngine;
using System.Collections;

public class ActiveStateToggler : MonoBehaviour {

	public void ToggleActive () {
		gameObject.SetActive (!gameObject.activeSelf);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
}
