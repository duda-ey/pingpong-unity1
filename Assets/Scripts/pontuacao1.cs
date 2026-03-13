using TMPro;
using UnityEngine;

public class pontuacao1 : MonoBehaviour
{ 
    [SerializeField] private GameObject bolaObjeto;

    public TMP_Text pontoP1;
    public TMP_Text pontoP2;

    // O tipo deve ser EXATAMENTE igual ao nome da classe/arquivo do script da bola
    private Bola scriptBola;

    void Start()
    {
            scriptBola = bolaObjeto.GetComponent<Bola>();

    }

    void Update()
    {
        pontoP1.text = scriptBola.ponto1.ToString();
        pontoP2.text = scriptBola.ponto2.ToString();

    }
}
