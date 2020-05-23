using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    /// <summary>
    /// 左を押されたらtrue違ったらfalse
    /// </summary>
    private bool _pushLeftIsEnble;

    /// <summary>
    /// 左を押されたらtrue違ったらfalseを返す
    /// </summary>
    public bool PushLeftIsEnable { get { return _pushLeftIsEnble; } }

    private bool isPush = false;

    /// <summary>
    /// 押された瞬間にtrueを返す
    /// </summary>
    public bool IsPush { get{ return isPush; } }

    // Start is called before the first frame update
    void Start()
    {
        isPush = false;
    }

    // Update is called once per frame
    void Update()
    {
        isPush = false;
    }

    public void PushLeft()
    {
        Debug.Log("スタンリーそこを左に曲がるんだ");
        _pushLeftIsEnble = true;
        isPush = true;
    }

    public void PushRight()
    {
        Debug.Log("スタンリーそこを右にに曲がるんだ");
        _pushLeftIsEnble = false;
        isPush = true;
    }
}
