using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTwins : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI agent;
    [SerializeField] private TextMeshProUGUI NPC;

    [SerializeField] private string[] dialogue;

    [SerializeField] private GameObject interact, UI;

    [SerializeField] private int textI;


    // Start is called before the first frame update
    void Start()
    {
        textI = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (textI > dialogue.Length)
        {
            interact.SetActive(false);
            UI.SetActive(false);
        }

       if (textI %2 == 0)
        {
            agent.text = dialogue[textI];
        }
       else
        {
            NPC.text = dialogue[textI];
        }


    }

    public void Increment()
    {
        textI++;
    }



}
