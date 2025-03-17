using UnityEngine;

public class suiviX : MonoBehaviour
{
    public GameObject origine;
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(origine.transform.position, transform.position, Color.blue);

        Vector3 pos1 = new Vector3(target.transform.position.x, 0f, 0f);
        transform.position = pos1;
    }
}
