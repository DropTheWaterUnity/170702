using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Instruction;
using UnityEngine.SceneManagement;


public class toSongPlay : MonoBehaviour {

	int i;

	// Use this for initialization
	void Start () {
		i = 1;
		Debug.Log (i);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{

	}


	void OnMouseUp() {
		//i를 받아옴


		//stage에 노래 선택
		Resource.stage = (SelectStage.stageNum+1)*100;

		SceneManager.LoadScene (5);
		Debug.Log ("stage" + Resource.stage);
}
}