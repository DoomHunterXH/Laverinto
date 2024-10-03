using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
   public void play(){
    SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //cargar la escena
   }
   public void GameQuit(/*aqui mete la escena y sus movidas*/){
    Application.Quit(); //cerrar juego
    Debug.Log("se apago we");
   }


}
