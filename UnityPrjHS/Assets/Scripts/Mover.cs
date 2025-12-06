using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float xValue = 0.001f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0.001f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
