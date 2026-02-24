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
        // Drošības pārbaudes (lai vairs nekrīt spēle)
        if (character == null) { Debug.LogError("CharacterScaler: character nav pievienots Inspectorā!"); enabled = false; return; }
        if (widthSlider == null) { Debug.LogError("CharacterScaler: widthSlider nav pievienots Inspectorā!"); enabled = false; return; }
        if (heightSlider == null) { Debug.LogError("CharacterScaler: heightSlider nav pievienots Inspectorā!"); enabled = false; return; }

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