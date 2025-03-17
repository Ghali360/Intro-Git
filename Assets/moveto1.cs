using UnityEngine;
using static UnityEngine.UI.Image;

public class moveto1 : MonoBehaviour
{
    public GameObject moveto;
    float speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(moveto.transform.position, transform.position, Color.red);

        Vector3 pos1 = moveto.transform.position;
        Vector3 pos2 = transform.position;

        float distance = Vector3.Distance(pos1, pos2);

        if (distance > 1.5f)
        {
            speed = 2f;
            Vector3 position = transform.position;
            Vector3 target = moveto.transform.position;
            Vector3 toTarget = target - position;

            transform.Translate(toTarget * speed * Time.deltaTime);
        }
        else
        {
            speed = 0f;
        }
    }
}
