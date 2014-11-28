using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Activity : MonoBehaviour {

	public int index;
	
	public void updateLevel(){
		Location loc;
		if(index == 0){
			loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Africa")).GetComponent<Location>();
			if(!GlobeManager.instance.isComplete(loc)){
				GlobeManager.instance.unlockLevel(loc);
				loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Brazil")).GetComponent<Location>();
				GlobeManager.instance.unlockLevel(loc);
				
				loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Japan")).GetComponent<Location>();
				GlobeManager.instance.levelComplete(loc);
			}
		}
		else if(index == 1){
			loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Africa")).GetComponent<Location>();
			if(!GlobeManager.instance.isComplete(loc)){
				GlobeManager.instance.levelComplete(loc);
			}
		}
		else if (index == 2){
			loc = GlobeManager.instance.locations.Find(i => i.transform.name.Equals("Brazil")).GetComponent<Location>();
			if(!GlobeManager.instance.isComplete(loc)){
				GlobeManager.instance.levelComplete(loc);
			}
		}
	}
}
