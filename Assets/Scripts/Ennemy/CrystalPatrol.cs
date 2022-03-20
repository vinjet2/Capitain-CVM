using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CrystalPatrol : MonoBehaviour
{
    /// <summary>
    /// Vitesse de l'objet en patrouille
    /// </summary>
    [SerializeField]
    private float x = 3f;

    /// <summary>
    /// Vitesse de l'objet en patrouille
    /// </summary>
    [SerializeField]
    private float y = 3f;

    private bool switchSprite = true;
    //private Sprite sprite = "Crystal-0002";


    /// <summary>
    /// Référence vers le sprite Renderer
    /// </summary>
    private SpriteRenderer _sr;


    // Start is called before the first frame update
    void Start()
    {

        _sr = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _sr.size = new Vector2(x,y);
        //_sr.sprite = sprite;
    }
}
