using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	const int CAMERA_RESOLUTION = 256;
	public string deviceName;
	public WebCamTexture wct;
	// Use this for initialization
	void Start ()
	{
		
		WebCamDevice[] devices = WebCamTexture.devices;
		deviceName = devices[0].name;
		wct = new WebCamTexture(deviceName, CAMERA_RESOLUTION, CAMERA_RESOLUTION, 12);
		renderer.material.mainTexture = wct;
		wct.Play();
	}

}
