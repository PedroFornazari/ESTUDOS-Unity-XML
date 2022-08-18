using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    public static float tempoJogo;
    public Text contador;
    
    // Start is called before the first frame update
    void Start()
    {
        tempoJogo = 0;

    }

    // Update is called once per frame
    void Update()
    {
        tempoJogo += Time.deltaTime;
        Contar((int)Mathf.Ceil(tempoJogo));
    }

    public void Contar(int segundos)
    {
        contador.text = segundos.ToString();
    }
}
