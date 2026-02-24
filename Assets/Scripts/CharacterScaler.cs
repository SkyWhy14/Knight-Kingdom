using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    [Header("References")]
    public Transform character;
    public Slider widthSlider;
    public Slider heightSlider;

    void Start()
    {
      

        // Piesaistām slider eventus
        widthSlider.onValueChanged.AddListener(SetWidth);
        heightSlider.onValueChanged.AddListener(SetHeight);

        // Uzliekam sākuma vērtības no character scale
        widthSlider.value = character.localScale.x;
        heightSlider.value = character.localScale.y;
    }

    public void SetWidth(float value)
    {
        var s = character.localScale;
        s.x = value;
        character.localScale = s;
    }

    public void SetHeight(float value)
    {
        var s = character.localScale;
        s.y = value;
        character.localScale = s;
    }
}