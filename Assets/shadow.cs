using UnityEngine;

public class shadow : MonoBehaviour
{
    public GameObject follow;
    //float sol = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = follow.transform.position;
        pos.y = 0f;
        transform.position = pos;
    }
}
