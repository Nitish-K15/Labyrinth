using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovements : MonoBehaviour
{
    InputModule currentModule;
    Vector2 input;
    private Vector3 acce;
    //public Text text;
    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    #if UNITY_STANDALONE //|| UNITY_EDITOR
        currentModule = new KeyboardInput();
    #elif UNITY_ANDROID || UNITY_IOS
        currentModule = new MobileInput();
    #else
        currentModule = new KeyboardInput();
    #endif
    }
    void FixedUpdate()
    {
        input = currentModule.GetInput();
        acce.x = input.x;
        acce.y = 0;
        acce.z = input.y;
        rb.velocity = new Vector3(acce.x, acce.y, acce.z) * 3f;
        //text.text = " " + rb.velocity;
    }
}