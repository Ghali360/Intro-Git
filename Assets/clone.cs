using UnityEngine;

public class clone : MonoBehaviour
{
    public GameObject original;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Clonage = new Vector3(original.transform.position.x, original.transform.position.y, original.transform.position.z);
        transform.localPosition += Clonage;
    }   
}
