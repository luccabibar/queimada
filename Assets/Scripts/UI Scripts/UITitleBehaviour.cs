using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITitleBehaviour : UIGenericBehaviour
{
    // delegates
    public delegate void OnJogarClick();
    public static event OnJogarClick onJogarClick;
    public delegate void OnInstrucoesClick();
    public static event OnInstrucoesClick onInstrucoesClick;
    public delegate void OnSairClick();
    public static event OnSairClick onSairClick;
    
    public void jogarClick()
    {
        Debug.Log("Jogar");
        SFXManager.instance.playButtonClick();
        onJogarClick?.Invoke();
    }
    
    public void instrucoesClick()
    {
        Debug.Log("Instrucoes");
        SFXManager.instance.playButtonClick();
        onInstrucoesClick?.Invoke();
    }
    
    public void sairClick()
    {
        Debug.Log("Eh o quitas");
        SFXManager.instance.playButtonClick();
        onSairClick?.Invoke();
    }
}
