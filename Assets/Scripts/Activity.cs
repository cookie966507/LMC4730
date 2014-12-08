using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Activity : MonoBehaviour {

	public int index;
	
	public GameObject instructions;
	
	public void updateLevel(){
		Location loc;
		if(index == 0){
			loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Africa")).GetComponent<Location>();
			if(!GlobeManager.instance.isComplete(loc)){
				GlobeManager.instance.unlockLevel(loc);
				loc.renderer.material.color = Color.yellow;
				loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Brazil")).GetComponent<Location>();
				GlobeManager.instance.unlockLevel(loc);
				loc.renderer.material.color = Color.yellow;
				
				loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Japan")).GetComponent<Location>();
				GlobeManager.instance.levelComplete(loc);
				loc.renderer.material.color = Color.green;
			}
		}
		else if(index == 1){
			loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Africa")).GetComponent<Location>();
			if(!GlobeManager.instance.isComplete(loc)){
				GlobeManager.instance.levelComplete(loc);
				loc.renderer.material.color = Color.green;
			}
		}
		else if (index == 2){
			loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Brazil")).GetComponent<Location>();
			if(!GlobeManager.instance.isComplete(loc)){
				GlobeManager.instance.levelComplete(loc);
				loc.renderer.material.color = Color.green;
			}
		}
		GameObject.Find("Sphere").GetComponent<SpinGlobe>().enabled = true;
	}
}
