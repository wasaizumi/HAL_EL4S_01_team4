using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject instruct = null;

    private bool isMove;

    private int isRight;

    private bool a;

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

            isRight = (int)Random.value;
            isRight %= 1;

            //たにさんが間に合わなかったよう
            if(isRight == 0)
            {
                a = true;
            }
            else
            {
                a = false;
            }

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
