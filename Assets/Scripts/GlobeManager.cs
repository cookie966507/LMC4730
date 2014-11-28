using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[Serializable]
public class GlobeManager : MonoBehaviour {
	
	//only instance available in the game
	public static GlobeManager instance;
	
	//[HideInInspector]
	//public bool japanUnlocked;
	//[HideInInspector]
	//public bool africaUnlocked;
	//[HideInInspector]
	//public bool brazilUnlocked;
	
	public List<GameObject> locations;
	
	void Awake(){
		if(instance == null){
			DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else if(instance != this){
			Debug.Log("Too many Globe Managers");
			Destroy (gameObject);
		}
	}
	
	void OnLevelWasLoaded(int index){
		if(Application.loadedLevelName.Equals("Globe_Spin")){
			if(locations.Count == 0){
				GameObject[] temp = GameObject.FindGameObjectsWithTag("Location");
				locations = new List<GameObject>();
				for(int i = 0; i < temp.Length; i ++){
					locations.Add(temp[i]);
				}
				Location japan = locations.Find(i => i.transform.name.Equals("Japan")).GetComponent<Location>();
				unlockLevel(japan);
			}
		}
	}
	
	public void unlockLevel(Location loc){
		loc.unlocked = true;
	}
	
	public void levelComplete(Location loc){
		loc.complete = true;
	}
	
	public bool isUnlocked(Location loc){
		return loc.unlocked;
	}
	
	public bool isComplete(Location loc){
		return loc.complete;
	}
}
