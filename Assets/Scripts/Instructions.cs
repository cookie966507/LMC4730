using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {
	
	public int numPages;
	public int currPage;
	public GameObject[] pages;
	
	public GameObject next;
	public GameObject prev;
	public GameObject complete;
	
	void Start () {
		numPages = pages.Length-1;
		Init();
	}
	
	public void Init(){
		currPage = 0;
		pages[currPage].SetActive(true);
		prev.SetActive(false);
		complete.SetActive(false);
		
	}
	
	void OnEnable(){
		Init();
	}
	
	public void UpdatePage(int dir){
		if(currPage + dir > 0 || currPage + dir < numPages){
			pages[currPage].SetActive(false);
			currPage += dir;
			pages[currPage].SetActive(true);
			if(currPage == 0){
				prev.SetActive(false);
			}
			else{
				prev.SetActive(true);
			}
			if(currPage == numPages){
				next.SetActive(false);
				complete.SetActive(true);
			}
			else{
				next.SetActive(true);
				complete.SetActive(false);
			}
		}
	}
}
