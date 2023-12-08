using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] GameObject parent;
    [SerializeField] Text stageText;



    public void Init(StageData stageData)
    {
        stageText.text = $"�������� {stageData.level}";
    }

    public void Show() 
    {
        parent.SetActive(true);
    }

    public void Hide()
    {
        parent.SetActive(false);
    }
}
