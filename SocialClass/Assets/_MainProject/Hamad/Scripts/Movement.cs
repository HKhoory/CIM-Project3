using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private GameObject theModel;

    [SerializeField] public static bool canMove;

    [SerializeField] private GameObject walkAudio;

    void Start()
    {
        walkAudio.SetActive(false);
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {

        float hMovement = Input.GetAxis("Horizontal");

        if (canMove)
        {

            Vector2 pos;
            pos = transform.position;
            pos = new Vector2(transform.position.x + hMovement * Time.deltaTime * speed, transform.position.y);
            transform.position = pos;

        }

        if (hMovement > 0.0f && canMove)
        {
            _animator.SetBool("isMoving", true);
            walkAudio.SetActive(true);
        }
        else if (hMovement < 0.0f && canMove)
        {
            _animator.SetBool("isMoving", true);
            walkAudio.SetActive(true);
        }
        else
        {
            _animator.SetBool("isMoving", false);
            walkAudio.SetActive(false);
        }

        if (hMovement < 0)
        {
            //theModel.transform.Rotate(new Vector3(0, 255, 0));
            theModel.transform.rotation = Quaternion.Euler(0, 255, 0);
        }
        else
        {
            //theModel.transform.Rotate(new Vector3(0, 112, 0));
            theModel.transform.rotation = Quaternion.Euler(0, 112, 0);
        }

    }
}
