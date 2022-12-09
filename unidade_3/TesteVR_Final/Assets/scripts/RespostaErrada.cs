using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class RespostaErrada : MonoBehaviour {
     [SerializeField]
     private TextMeshPro textMeshPro;
    
    void Start()
    {
        textMeshPro.text = "Qual das frações é equivalente ao gráfico?";
     }
     void OnPointerClick() {
        textMeshPro.text = "Resposta incorreta: Para encontrar a fração equivalente, você precisa dividir ou multiplicar o numerador e o denominador da fração por um mesmo número diferente de zero.";
     }
}

