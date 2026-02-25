using UnityEngine;
using UnityEngine.UI;

public class DrebesScalleSlider : MonoBehaviour
{
    [Header("References")]
    public Transform[] drebes; // MASĪVS ar drēbēm
    public Slider widthSlider;
    public Slider heightSlider;

    void Start()
    {
        widthSlider.onValueChanged.AddListener(SetWidth);
        heightSlider.onValueChanged.AddListener(SetHeight);

        // Ja ir vismaz viena drēbe, paņem scale kā sākuma vērtību
        if (drebes.Length > 0 && drebes[0] != null)
        {
            widthSlider.value = drebes[0].localScale.x;
            heightSlider.value = drebes[0].localScale.y;
        }
    }

    public void SetWidth(float value)
    {
        for (int i = 0; i < drebes.Length; i++)
        {
            if (drebes[i] != null && drebes[i].gameObject.activeInHierarchy)
            {
                Vector3 s = drebes[i].localScale;
                s.x = value;
                drebes[i].localScale = s;
            }
        }
    }

    public void SetHeight(float value)
    {
        for (int i = 0; i < drebes.Length; i++)
        {
            if (drebes[i] != null && drebes[i].gameObject.activeInHierarchy)
            {
                Vector3 s = drebes[i].localScale;
                s.y = value;
                drebes[i].localScale = s;
            }
        }
    }
}