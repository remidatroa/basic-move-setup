using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
  // these variables change our move speed
 
  
  [SerializeField]float moveSpeed = 10f;

  void Start() {
    
  }
  void Update() {
    
   float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
   float zValue = Input.GetAxis("Vertical")*Time.deltaTime * moveSpeed;
   
   transform.Translate(xValue,0,zValue);  
  }
  
}