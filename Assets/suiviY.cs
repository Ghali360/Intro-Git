using UnityEngine;

public class suiviY : MonoBehaviour
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
        Debug.DrawLine(origine.transform.position, transform.position, Color.green);

        Vector3 pos1 = new Vector3(0f, target.transform.position.y, 0f);
        transform.position = pos1;
    }
}
