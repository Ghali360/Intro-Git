using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject followPrefab;
    Vector3 Follow = new Vector3 (0f, 3f, -3f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = followPrefab.transform.position + Follow;
    }
}