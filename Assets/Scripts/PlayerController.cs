using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int foodProgress;
    public float timePassed;
    public TextMeshProUGUI progressText;
    public NavMeshAgent navAgent;
    // Start is called before the first frame update
    void Start()
    {
        foodProgress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        progressText.text = foodProgress.ToString() + "%";
        timePassed += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E) && timePassed >= 3)
        {
            timePassed = 0;
            foodProgress += 10;
        }

        if(foodProgress >= 100)
        {
            SceneManager.LoadScene("WinScreen");
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(navAgent.transform.position, 5);
    }
}
