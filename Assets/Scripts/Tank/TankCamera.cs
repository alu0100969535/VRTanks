using UnityEngine;

public class TankCamera : MonoBehaviour {

	[SerializeField] private Transform cameraPivot;

	public void SetCamera(Transform camera) {
		camera.parent = this.cameraPivot;
		camera.localEulerAngles = Vector3.zero;
		camera.localPosition = Vector3.zero;
	}

}