using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{

    public bool isTure = false;//控制报警信息是否弹窗
    // Use this for initialization
    void Start()
    {
    }
    void OnMouseDown()
    {
        isTure = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTure)
        {
            Destroy(this.gameObject);
        }
    }
}
