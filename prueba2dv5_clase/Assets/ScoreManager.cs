using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text fruitsText; // Texto de UI para las frutas
    public TMP_Text coinsText; // Texto de UI para las monedas
    public int totalFruits = 0; // Puntuaci�n total de frutas
    public int totalCoins = 0; // Puntuaci�n total de monedas

    private void Update()
    {
        // Actualiza los textos de UI para frutas y monedas
        fruitsText.text = "= " + totalFruits;
        coinsText.text = "= " + totalCoins;
    }

    // M�todo para a�adir frutas a la puntuaci�n total
    public void AddFruits(int fruits)
    {
        totalFruits += fruits;
        fruitsText.text = "Frutas: " + totalFruits; // Actualiza el texto de UI inmediatamente
    }

    // M�todo para a�adir monedas a la puntuaci�n total
    public void AddCoins(int coins)
    {
        totalCoins += coins;
        coinsText.text = "Monedas: " + totalCoins; // Actualiza el texto de UI inmediatamente
    }
}