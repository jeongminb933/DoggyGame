using Unity.VisualScripting;
using UnityEngine;

public class Mober : MonoBehaviour
{
    [SerializeField] int frame = 60;
    [SerializeField] float moveSpeed = 20;


    Rigidbody rb;
    Vector3 Vector3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
        Application.targetFrameRate = frame;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue); //transform <- 게임 오브젝트의 트랜스폼이라는 컴포넌트를 조작


    }
    void PrintInstruction()
    {
        Debug.Log("hi");
        Debug.Log("hi");
        Debug.Log("hi");
        Debug.Log("hi");
        Debug.Log("hi");

    }

}
