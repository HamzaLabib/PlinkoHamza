using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MyEnum { Hi, Hola, Hey };
[RequireComponent(typeof(MeshRenderer))]
public class MyTest : MonoBehaviour
{ 
    [HideInInspector] public int myInt; // hide only from editor not from other classes
    [HeaderAttribute("My Variables")]
    [Range(0, 5)] public float myFloat;
    [SerializeField] string aString; // make it private/ protected visible in editor and i can not see it in other classes
    [Space(20)]
    public MyEnum myEnum;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
