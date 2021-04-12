using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
   
    public GameManager gameManager;


    private void Start()
    {
        //if we dont have the game manager
        if (gameManager == null)
            //put a reference in by finding the GameObject with tab gamemanager, and then get its script GameManager
            gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    // if something enters this trigger, reset it's position


    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("collision with " + collision.gameObject.name);


        if (collision.gameObject.tag == "Bin")
        {
            Debug.Log("has hit collider the Bin");
            gameManager.ballCount++; //add to the gameManager ballCount 1
            gameManager.Score++; //add 1 to score
            gameManager.RespawnBall(); //call the ball respawn. (but only if its the 3rd ball)
            Destroy(gameObject, 2.0f); //destory THIS game object. in 2 seconds
        }
        else if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("has hit a collider the Floor");
            gameManager.ballCount++; //add to the gameManager ballCount 1
            gameManager.RespawnBall(); //call the ball respawn. (but only if its the 3rd ball)
            Destroy(gameObject, 2.0f); //destory THIS game object. in 2 seconds
        }


    }

    

}
