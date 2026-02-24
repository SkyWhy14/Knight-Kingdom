using UnityEngine;
using TMPro; // ja lieto TextMeshPro

public class CharacterDescriptionUI : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI descriptionText;

    [TextArea(3, 10)] public string lightKnightDesc;
    [TextArea(3, 10)] public string darkKnightDesc;
  

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnChanged);
        OnChanged(dropdown.value); // uzreiz uzliek pareizo tekstu startā
    }

    void OnChanged(int index)
    {
        switch (index)
        {
            case 0: descriptionText.text = lightKnightDesc; break;
            case 1: descriptionText.text = darkKnightDesc; break;
          
        }
    }
}