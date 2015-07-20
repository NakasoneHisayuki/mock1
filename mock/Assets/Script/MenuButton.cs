using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	public StargeSelectController stargeSelectController;
	public GameObject stargeSelectObj;
	private onButton Button;
	public enum onButton{
		StargeSelect,
		Status,
		Option,
		AppliInformation
	}

	void Awake(){

	}
	
	public void OnStargeSelectButtonClick(){
		this.Button = onButton.StargeSelect;
		ChengeButton();
	}
	
	public void OnStatusButtonClick(){
		this.Button = onButton.Status;
		ChengeButton();
	}
	
	public void OnOptionButtonClick(){
		this.Button = onButton.Option;
		ChengeButton();
	}
	
	public void OnAppliInformationButtonClick(){
		this.Button = onButton.AppliInformation;
		ChengeButton();
	}

	public void CretaStargeSelect(){
		GameObject stargeObj = Instantiate(stargeSelectObj) as GameObject;
	}
	private void ChengeButton(){
		
		this.GetComponent<Animator>().SetBool("OnUIButton" , true);
		switch(Button){
		case onButton.StargeSelect:
			CretaStargeSelect();
			break;
		case onButton.Status:
			Debug.Log("cccc");
			break;
		case onButton.Option:
			break;
		case onButton.AppliInformation:
			break;
		default:
			break;
			
		}
	}
}
