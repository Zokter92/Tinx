using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Declaracion de variables para BackGround.
    public Renderer Background;
    public Renderer BG_Trees;
    public Renderer BG_Ground;
    //Llamda al iniciar el Juego.
    void Start()
    {
        
    }

    // Actualizacion de comandos cada segundo * Frame.
    void Update()
    {
        Background.material.mainTextureOffset = Background.material.mainTextureOffset + new Vector2(0.050f, 0) * Time.deltaTime;
        BG_Ground.material.mainTextureOffset = BG_Ground.material.mainTextureOffset + new Vector2(0.090f, 0) * Time.deltaTime;
        BG_Trees.material.mainTextureOffset = BG_Trees.material.mainTextureOffset + new Vector2(0.015f, 0) * Time.deltaTime;
    }
}
