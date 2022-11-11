using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    private Vector3 playerStart;
    private Vector3 groundGenerationStartPoint;

    public GroundGenerator groundGenerator;
    public GameObject ground;
    public GameObject gameOverScreen;


    // Start is called before the first frame update
    void Start()
    {

        playerStart = player.transform.position;
        groundGenerationStartPoint = groundGenerator.transform.position;
        gameOverScreen.SetActive(false);


    }

    public void Restart(){
        GroundDestroyer[] destroyer = FindObjectsOfType<GroundDestroyer>();
        for(int i=0; i<destroyer.Length; i++){
            destroyer[i].gameObject.SetActive(false);
        }

        ground.SetActive(true);
        player.transform.position = playerStart;
        groundGenerator.transform.position = groundGenerationStartPoint;
        gameOverScreen.SetActive(false);
        player.gameObject.SetActive(true);
        
    }

    public void GameOver(){
        gameOverScreen.SetActive(true);
        player.gameObject.SetActive(false);

    }

}
