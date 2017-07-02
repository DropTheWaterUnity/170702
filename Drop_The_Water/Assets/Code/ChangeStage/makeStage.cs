using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Instruction;
using ObjectHierachy;
using System.IO;

public class makeStage : MonoBehaviour {
	public delegate void Clear ();
	public GameObject[] cup;
	public GameObject[] answerCup;

	public static Clear clearEvent;


	public Vector3[] waterPosition; // water drop

	// Use this for initialization
	void Start () {
		loadStage (Resource.stage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void loadStage(int stage) {
		Debug.Log (Resource.stage);
		TextAsset data = Resources.Load ("StageText/text" + stage, typeof(TextAsset)) as TextAsset;
		StringReader str = new StringReader (data.text);


		string line;

		while((line = str.ReadLine()) != null) {
			if(line.Equals("cup")){
				line = str.ReadLine();
				string[] o = line.Split (new char[]{ ' ' });
				Debug.Log (o [0]);
				createCupOne (int.Parse (o [0]), int.Parse (o [1]), int.Parse (o [2]), int.Parse (o [3]), int.Parse (o [4]), int.Parse (o [5]), int.Parse (o [6]));
			
			}
			else if(line.Equals("answer")) {
				int answerOneNum = int.Parse ((line = str.ReadLine ()));
				line = str.ReadLine();
				string[] o = line.Split (new char[]{ ' ' });
				answerOne (int.Parse (o [0]), int.Parse (o [1]), int.Parse (o [2]), int.Parse (o [3]));

				int answerTwoNum = int.Parse ((line = str.ReadLine ()));
				line = str.ReadLine();
				string[] t = line.Split (new char[]{ ' ' });
				answerTwo (int.Parse (t [0]), int.Parse (t [1]), int.Parse (t [2]));
			}
		}
	}


	public void createCupOne(int a, int b, int c, int d, int e, int f, int g){
		cup [0].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + a);
		cup [1].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + b);
		cup [2].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + c);
		cup [3].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + d);
		cup [4].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + e);
		cup [5].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + f);
		cup [6].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_" + g);
	}

		
	public void answerOne(int x, int y, int z, int r){
		answerCup[0].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + x);
		answerCup[1].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + y);
		answerCup[2].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + z);
		answerCup[3].GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/colorCup_" + r);
	}

	public void answerTwo(int x, int y, int z){
	}
	
}