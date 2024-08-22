using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
   {  
     if(other.gameObject.tag != "Hit");
     {

     
     hits++;
     Debug.Log("Bumped into shit this many times:" + hits);
   }} 
     
 }
    

