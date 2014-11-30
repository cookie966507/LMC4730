using UnityEngine;
using System.Collections;

public class Complete : MonoBehaviour {

	public GameObject instructions;
	public Activity activity;
	
	public void CompleteActivity(){
		activity.updateLevel();
		int currPage = instructions.GetComponent<Instructions>().currPage;
		instructions.GetComponent<Instructions>().pages[currPage].SetActive(false);
		instructions.GetComponent<Instructions>().pages[0].SetActive(true);
		instructions.GetComponent<Instructions>().next.SetActive(true);
		instructions.SetActive(false);
	}
}
