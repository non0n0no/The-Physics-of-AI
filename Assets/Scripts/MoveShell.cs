using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEditor.UIElements;
using UnityEngine;

public class MoveShell : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, Time.deltaTime * (speed / 2), Time.deltaTime * speed);
    }
}
