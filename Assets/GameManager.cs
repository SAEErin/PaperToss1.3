using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform throwingArea; //Reference to throwing area
    public Transform trashRespawnArea; //Area that the trash can spawn in
    public Transform fanRespawnArea; //Area that the Fan can spawn in
    public Transform ballRespawnArea; //Area that the Ball can respawn to

    public Vector3 ballMoveArea; //Size of ball move area

    public GameObject trashPrefab;
    public GameObject ballPrefab;
    public GameObject fanPrefab;

    public int Score;
    
    public BallHandler ballHandler; //Ref to ball handler
   
    public int ballCount;

    // Start is called before the first frame update
    void Start()
    {
        RespawnBall();
        TrashRespawn();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Returns a random position within our move area/
    /// </summary>
    /// <returns></returns>

    public void RespawnBall()
    {
        

        Debug.Log("Respawn Ball");
        if(ballCount >3)
        {
            ballCount = 0;
            Vector3 tempPlace = new Vector3(ballRespawnArea.transform.position.x, ballRespawnArea.transform.position.y + 2, ballRespawnArea.transform.position.z);
            Instantiate(ballPrefab, tempPlace, Quaternion.identity);

            tempPlace = new Vector3(ballRespawnArea.transform.position.x, ballRespawnArea.transform.position.y + 2.1f, ballRespawnArea.transform.position.z);
            Instantiate(ballPrefab, tempPlace, Quaternion.identity);

            tempPlace = new Vector3(ballRespawnArea.transform.position.x, ballRespawnArea.transform.position.y + 2.2f, ballRespawnArea.transform.position.z);
            Instantiate(ballPrefab, tempPlace, Quaternion.identity);


        }
    }

    public void TrashRespawn()
    {

        Vector3 tempPlace = new Vector3(trashRespawnArea.transform.position.x, trashRespawnArea.transform.position.y, trashRespawnArea.transform.position.z + Random.Range(-1, 6));
        Instantiate(trashPrefab, tempPlace, Quaternion.identity);

        

    }
}
