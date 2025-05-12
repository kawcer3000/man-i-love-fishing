using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public string mainWord = "default";
    public int livesCount = 10;
    public TextMeshProUGUI mainWordText;
    public TextMeshProUGUI livesCountText;
    public TextMeshProUGUI messageText;
    public TMP_InputField inputField;


    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
        livesCountText.text = $"Zostalo {livesCount} prób" ;
    }

    public void OnClick()
    {
        Debug.Log($"Guzik zostal klikniety");
        livesCount = livesCount - 1;
        livesCountText.text = $"Zostalo {livesCount} prób";

        if(mainWord == inputField.text)
        {
            messageText.text = $"Poprawne słowo zostało wpisane";
            return; 
        }
        if (mainWord.Length != inputField.text.Length) ;
        {
            messageText.text = $"Liczba liter się nie zgadza";
            return;
        }
        int bullsCount = CountBulls();
        int cowsCount = CountCows();
        messageText.text = $"Bulls: {bullsCount} and Cows: {cowsCount}";
        
    }
    public int CountBulls()
{

        int result = 0;

        for (int i = 0; i < mainWord.Length; i++)

        {
            if (mainWord[i] == inputField.text[i])
            {
                result++;
            }
        }

        return result;

}

public int CountCows()
{
    int result = 0;

        for (int i = 0; i < mainWord.Length; i++)

        {
            if (mainWord[i] != inputField.text[i] && mainWord.Contains(inputField.text[i]) )
            {
                result++;
            }
        }

        return result;

}
}

