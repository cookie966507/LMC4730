﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveManager : MonoBehaviour {

	//only instance available in the game
	public static SaveManager instance;

	//path to the save file
	private string pathExtention = ("/PenPals/SaveFiles/");

	void Awake(){
		if(instance == null){
			DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else if(instance != this){
			Debug.Log("Too many Save Managers");
			Destroy (gameObject);
		}
	}

	public void SaveManagers<T>(T manager) where T : MonoBehaviour{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + pathExtention + manager.gameObject.name + ".dat");

		bf.Serialize(file, manager);
		file.Close();
	}
}
