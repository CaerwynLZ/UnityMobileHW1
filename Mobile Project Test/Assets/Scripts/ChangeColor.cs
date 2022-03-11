using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject sphere;
    public Renderer objectRenderer;
    public Color newObjectColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        ChangeObjectColor();
    }

    private void ChangeObjectColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newObjectColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree);

        objectRenderer.material.SetColor("_Color", newObjectColor);
    }
}
