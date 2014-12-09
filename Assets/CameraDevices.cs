using UnityEngine;
using System.Collections;

public class CameraDevices : MonoBehaviour {
	
	WebCamTexture frontTex;
	WebCamTexture backTex;
	
	void Start(){
		WebCamDevice[] devices = WebCamTexture.devices;
		
		for(int i = 0 ; i < devices.Length ; i++ ) {
			if (devices[i].isFrontFacing) {
				Debug.Log (devices[i].name + " : Front");
			} else {
				Debug.Log (devices[i].name + " : Back");
			}
		}
		//frontTex = new WebCamTexture(frontCamName, width, height, framesPerSec);
		//backTex = new WebCamTexture(backCamName, width, height, framesPerSec);
	}
}
