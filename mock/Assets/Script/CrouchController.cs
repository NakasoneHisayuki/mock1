using UnityEngine;
using System.Collections;

public class CrouchController : MonoBehaviour {

	public float crouchSpeedMultiplier = 0.5f;
	public float crouchTogglingTime = 0.1f;
	public float globalCrouchBlend;
	
	private float globalCrouchBlendTarget;
	private float globalCrouchBlendVelocity;
	private bool disable;

	void Update () {
		if (Input.GetKeyDown(KeyCode.C)){
			if(!this.disable){
				if (this.globalCrouchBlend < 0.5f){
					this.globalCrouchBlendTarget = 1.0f;
				}
				else{
					this.globalCrouchBlendTarget = 0.0f;
				}
			}
			this.disable = true;
		}
		else{
			this.disable = false;
		}
//		globalCrouchBlend = Mathf.SmoothDamp(globalCrouchBlend, globalCrouchBlendTarget, globalCrouchBlendVelocity, crouchTogglingTime);
	}
}
