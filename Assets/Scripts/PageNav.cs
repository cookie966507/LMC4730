using UnityEngine;
using System.Collections;

public class PageNav : MonoBehaviour {
	
	public int dir;
	public Instructions instr;
	
	public void ChangePage(){
		instr.UpdatePage(dir);
	}
}
