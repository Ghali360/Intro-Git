using UnityEngine;

public class grossir : MonoBehaviour
{
    public Vector3 scaleChange;
    float speed = 1f;
    float tailleBase; //stocker la taille d'origine
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scaleChange = new Vector3(1.2f, 1.2f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange * speed * Time.deltaTime;
        if //si la boule est cliquée, revenir à taillebase
    }
}
