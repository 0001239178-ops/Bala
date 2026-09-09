using UnityEngine;

public class SobeDesce : MonoBehaviour
{
    public float velocidade = 2f;
    public float altura = 3f;

    Vector3 inicio;
    bool subindo = true;

    void Start()
    {
        inicio = transform.position;
    }

    void Update()
    {
        float direcao = subindo ? 1 : -1;
        transform.Translate(Vector3.up * direcao * velocidade * Time.deltaTime);

        if (transform.position.y >= inicio.y + altura)
            subindo = false;

        if (transform.position.y <= inicio.y)
            subindo = true;
    }
}