using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballNav : MonoBehaviour
{
  public float movement = 5.0f;
  public float rotationSpeed = 200.0f;
  public float jumpSpeed = 8.0f;
    // Start is called before the first frame update
    void Start(){

      Debug.Log("Beginning Start Function");

    }

    // Update is called once per frame
    void Update(){

      if(Input.GetKeyDown(KeyCode.Space)){
        GetComponent<Rigidbody> ().AddForce(Vector3.up * 500);
      }

      transform.Rotate(0,Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
      transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movement);

    }
}
