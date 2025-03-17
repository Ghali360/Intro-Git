using UnityEngine;

public class colorEVO : MonoBehaviour
{
    float rouge;
    float bleu;
    float vert;
    public Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Color color = GetComponent<Color>();
        
        mat.color = new Color(0f, 0f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
        rouge = transform.position.x*10;
        bleu = transform.position.y*10;   
        vert = transform.position.z * 10;

      mat.color = new Color (rouge, vert, bleu); //il faut bien éloigner la balle pour qu'elle change de couleur


    }
}
