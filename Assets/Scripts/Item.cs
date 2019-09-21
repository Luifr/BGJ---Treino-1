using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    //public string name;
    //public Sprite sprite;
    //public GameObject machine;
    //private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start() {
        //collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);
    }
}
