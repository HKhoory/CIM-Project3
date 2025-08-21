using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    [SerializeField] private GameObject t1, t2;

    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportTo2()
    {
        player.transform.position = t2.transform.position;
    }
    public void TeleportTo1()
    {
        player.transform.position = t1.transform.position;
    }


}
