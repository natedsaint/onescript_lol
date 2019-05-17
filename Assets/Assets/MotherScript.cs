using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherScript : MonoBehaviour {
  public GameObject baby1;
  public GameObject baby2;

  // Start is called before the first frame update
  void Start() {
    if (baby1 != null) {
      baby1.AddComponent<BabyScript>();
      baby1.GetComponent<BabyScript>().babyName = "Bingo";
    }
    if (baby2 != null) {
      baby2.AddComponent<BabyScript>();
      baby2.GetComponent<BabyScript>().babyName = "Bongo";
    }
  }

  // Update is called once per frame
  void Update() {
      
  }
}

public class BabyScript : MonoBehaviour {
  public string babyName;
  private void Start() {
    Debug.Log(babyName + " Says: Waaaaahhh!");
  }
}
