 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupChange : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		Vector3 direction = this.transform.position;
		Debug.Log (direction);
		Vector3 direction_water = new Vector3(0, 8, 0);


		if(other.gameObject.tag.Equals("waterdrop"))
		{
			Debug.Log ("other gameobject is waterdrop");

			if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_0")) {
				Debug.Log ("image is cup_0");
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_1");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_1")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_2");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_2")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_3");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_3")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_4");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_4")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_5");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_5")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_6");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_6")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_7");
			}else if (this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals ("cup_7")) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("cup/cup_8");
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite.name.Equals ("cup_8")) {
				Destroy(other.gameObject);
			} else {
				other.transform.position = direction_water;
			}
			
		}
	}
}