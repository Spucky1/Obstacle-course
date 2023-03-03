using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float movespeed = 10f;
 
 

    // Start is called before the first frame update
    void Start()
    {
      PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }



    void PrintInstructions()
    {
     Debug.Log("Welcom to the game");
     Debug.Log("Move player with wasd");
     Debug.Log(" Don't touch the wall ");
    }
    void MovePlayer()
{
         float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        
         float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;

         transform.Translate(xValue,0,zValue);
}
} 

