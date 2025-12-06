using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float MoveSpeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        float yValue = 0f;
        transform.Translate(xValue, yValue, zValue);
    }
}
