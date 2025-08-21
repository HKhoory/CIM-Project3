using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehaviour : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    //or just use rigidbody

    [SerializeField] private float speed;

    [SerializeField] private GameObject location1, location2;

    [SerializeField] private bool isTalking;

    [SerializeField] private float timer;
    private float timerStore; //this is to 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveToLocation()
    {
        //make npc move there based on speed
    }

    public void ToggleTalking()
    {
        if (isTalking)
        {
            isTalking = !isTalking;
        }
        else
        {
            isTalking = !isTalking;
        }

    }



}
