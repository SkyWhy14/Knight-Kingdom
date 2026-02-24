using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    public Transform character;

    [Header("All equipped visuals to scale together")]
    public Transform[] equippedParts; // helmet, armor, boots utt.

    public Slider widthSlider;
    public Slider heightSlider;

    void Start()
    {
        widthSlider.onValueChanged.AddListener(SetWidth);
        heightSlider.onValueChanged.AddListener(SetHeight);

        widthSlider.value = character.localScale.x;
        heightSlider.value = character.localScale.y;
    }

    public void SetWidth(float value)
    {
        ApplyScale(value, character.localScale.y);
    }

    public void SetHeight(float value)
    {
        ApplyScale(character.localScale.x, value);
    }

    void ApplyScale(float x, float y)
    {
        Vector3 s = new Vector3(x, y, 1f);

        character.localScale = s;

        // skalo arī drēbes
        foreach (var part in equippedParts)
        {
            if (part != null) part.localScale = s;
        }
    }
}