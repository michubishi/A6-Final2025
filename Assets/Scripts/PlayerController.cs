using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    /**
    * Author: Michelle Vuong
    * Description: Player functionaily. The player is able to eat food. This also checks the win/lose state of the player.
    */

    public int foodProgress;
    public float timePassed;
    public TextMeshProUGUI progressText;
    public NavMeshAgent navAgent;
    
    void Start()
    {
        foodProgress = 0; //reset food progress to 0
    }

    void Update()
    {
        progressText.text = foodProgress.ToString() + "%"; //display food progress on screen

        timePassed += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E) && timePassed >= 3) //if the player attempts to eat and it has been 3 seconds passed (Cooldown)
        {
            timePassed = 0; //reset the cooldown
            foodProgress += 10; //add to the percentage
        }

        if(foodProgress >= 100) //if the player reaches 100% progress, they win!
        {
            SceneManager.LoadScene("WinScreen");
        }

    }

}
