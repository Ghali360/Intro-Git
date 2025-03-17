using UnityEngine;
using UnityEngine.UI;

public class detecteur : MonoBehaviour
{
    public GameObject Boule;
    public Material off;
    public Material on;
    float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = new Vector3(Boule.transform.position.x, 0f, Boule.transform.position.z);
        Vector3 pos2 = new Vector3(transform.position.x, 0f, transform.position.z);

        float distance = Vector3.Distance(pos1, pos2);

        if (distance < 0.5f)
        {
            GetComponent<Renderer>().material = on;
        }

        else
        {
            GetComponent<Renderer>().material = off;
        }
    }
}
