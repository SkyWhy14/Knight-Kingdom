using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    public RectTransform knightImage;
    public Slider widthSlider;
    public Slider heightSlider;

    private Vector3 baseScale;

    void Start()
    {
        // Saglabā sākotnējo lielumu (piemēram 5,5,1)
        baseScale = knightImage.localScale;

        widthSlider.onValueChanged.AddListener(OnSliderChange);
        heightSlider.onValueChanged.AddListener(OnSliderChange);

        UpdateScale();
    }

    void OnSliderChange(float value)
    {
        UpdateScale();
    }

    void UpdateScale()
    {
        float width = widthSlider.value;
        float height = heightSlider.value;

        // Reizinām ar sākuma scale, nevis pārrakstām to
        knightImage.localScale = new Vector3(
            baseScale.x * width,
            baseScale.y * height,
            1f
        );
    }
}