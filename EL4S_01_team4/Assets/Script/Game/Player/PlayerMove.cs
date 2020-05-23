using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject instruct = null;

    private bool isMove;

    // Start is called before the first frame update
    void Start()
    {
        isMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (instruct.GetComponent<Instruction>().IsPush)
        {
            isMove = true;
        }

        Vector3 speed = new Vector3(0.1f, 0.0f, 0.0f);
        if (isMove)
        {
            if (instruct.GetComponent<Instruction>().PushLeftIsEnable)
            {
                transform.position -= speed;
            }

            else
            {
                transform.position += speed;
            }
        }
    }
}
