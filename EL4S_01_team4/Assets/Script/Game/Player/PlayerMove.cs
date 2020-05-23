using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject instruct = null;

    [SerializeField] GameObject Character = null;

    private bool isMove;

    private int isRight;

    private bool isF;

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
            isF = Character.GetComponent<Character>().IsFollow();
        }

        Vector3 speed = new Vector3(0.1f, 0.0f, 0.0f);
        if (isMove)
        {
            if (instruct.GetComponent<Instruction>().PushLeftIsEnable)
            {
                if (isF)
                {
                    transform.position -= speed;
                    return;
                }

                else
                {
                    transform.position += speed;
                    return;
                }
            }
            else
            {

                if (isF)
                {
                    transform.position += speed;
                    return;
                }
                else
                {
                    transform.position -= speed;
                    return;
                }
            }
        }
    }
}
