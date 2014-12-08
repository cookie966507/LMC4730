using UnityEngine;
using System.Collections;

public class Cancel : MonoBehaviour {

	public GameObject instructions;
	
	public void CancelInstr(){
		//instructions.GetComponent<Instructions>().Init();
		int currPage = instructions.GetComponent<Instructions>().currPage;
		instructions.GetComponent<Instructions>().pages[currPage].SetActive(false);
		instructions.SetActive(false);
		GameObject.Find("Sphere").GetComponent<SpinGlobe>().enabled = true;
	}
}
