using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{

    private Text text;
    private int number;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        SetNumber();
    }

    public void SetNumber()
    {
        number = Random.Range(0,10);

        text.text = number.ToString();
    }
}
