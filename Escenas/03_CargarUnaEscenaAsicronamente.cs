

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangesScenes : MonoBehaviour {

    private bool siguiente;

    void Start() { }

    void Update() {
        if (siguiente == true) {
            StartCoroutine(CargarEscena());
        }
    }

    public void siguienteNivel() { // un boton activara este evento
        siguiente = true;
    }

    IEnumerator CargarEscena() {
        AsyncOperation operacion_de_carga = SceneManager.LoadSceneAsync("Escena_2");
        while (!operacion_de_carga.isDone) {
            siguiente = false;
            yield return null;
        }
    }
}