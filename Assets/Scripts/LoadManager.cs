using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class LoadManager : MonoBehaviour {
	//only instance available in the game
	public static LoadManager instance;

	//path to the save file
	private string pathExtention = ("/PenPals/SaveFiles/");

	void Awake(){
		if(instance == null){
			DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else if(instance != this){
			Debug.Log("Too many Load Managers");
			Destroy (gameObject);
		}
	}
		
	public T LoadManagers<T>(T manager) where T : MonoBehaviour{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Open(Application.persistentDataPath + pathExtention + manager.gameObject.name + ".dat", FileMode.Open);

		manager = (T) bf.Deserialize(file);

		file.Close();

		return manager;
	}
}
