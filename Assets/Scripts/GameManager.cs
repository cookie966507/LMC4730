using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Manager for all the game data
 * Made up of tiny other managers
 */

[Serializable]
public class GameManager : MonoBehaviour {

	//only instance available in the game
	public static GameManager instance;

	//List of managers;
	[HideInInspector]
	public List<MonoBehaviour> managers;
	
	void Awake(){
		if(instance == null){
			DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else if(instance != this){
			Debug.Log("Too many Game Controllers");
			Destroy (gameObject);
		}

		managers = new List<MonoBehaviour>();
	}

	void Start(){
		GameObject[] findManagers = GameObject.FindGameObjectsWithTag("Manager");
		for(int i  = 0; i < findManagers.Length; i++){
			managers.Add(findManagers[i].GetComponent<MonoBehaviour>());
		}
	}

	public List<MonoBehaviour> GetManagers(){
		return managers;
	}

	public MonoBehaviour GetManager(int index){
		return GetManagers()[index];
	}

	public void Save(){
		for(int i = 0; i < managers.Count; i++){
			SaveManager.instance.SaveManagers(managers[i]);
		}
	}

	public void Load(){
		for(int i = 0; i < managers.Count; i++){
			managers[i] = LoadManager.instance.LoadManagers(managers[i]);
		}
	}

	public void Quit(){
		Application.Quit();
	}
}