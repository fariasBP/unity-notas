/*	INSTANCIAR PREFABS - INSTANTIATE
	Esta función realiza una copia de un objeto de forma similar al comando Duplicar del 
	editor. Si está clonando un GameObject, puede especificar su posición y rotación 
	(estos predeterminados a la posición y rotación del GameObject original en caso 
	contrario). Si va a clonar un componente, el GameObject al que está conectado también 
	se clona, de nuevo con una posición opcional y rotación. Al clonar un GameObject o un 
	componente , todos los objetos y componentes secundarios también se clonan con sus 
	propiedades establecidas como las del objeto original.
	TEMAS:
		- Instantiate(original)
			- original >>> gameobject existe del que se desee realizar una copia (puede ser prefab).
		- Instantiate(original, parent)
			- parent >>> padre que se desee asignara al nuevo gameobject copiado.
		- Instantiate(original, parent, instantiateInWorldSpace)
			- instantiateInWorldSpace >>> Al asignar un objeto primario, pase true para colocar 
			el nuevo objeto directamente en el WorldSapce. Pase false para establecer la 
			posición del objeto en relación con su nuevo elemento primario.
		- Instantiate(original, position, rotation)
			- position >>> objeto Vector3 que indique la posicion del nuevo gameobject copiado.
			- rotation >>> objeto Quaternion que indique la orientacion del nuevo gameobject copiado.
		- Instantiate(original, position, rotation, parent)
	SINTAXIS:
		- gameObject.Instantiate(<Object original>)
		- gameObject.Instantiate(<Object original>, <Transform parent>)
		- gameObject.Instantiate(<Object original>, <Transform parent>, <bool instantiateInWorldSpace>)
		- gameObject.Instantiate(<Object original>, <Vector3 position>)
		- gameObject.Instantiate(<Object original>, <Vector3 position>, <Quaternion rotation>)
		- gameObject.Instantiate(<Object original>, <Vector3 position>, <Quaternion rotation>, <Transform parent>)
*/

/* EJMPLO 1 - En el siguiente ejemplo se instancia un prefab 10 veces apartir de su 
transform y en donde ya se da una posicion y orientacion a la copias.
*/
	using UnityEngine;
	using System.Collections;

	public class ExampleClass : MonoBehaviour
	{
	    public Transform prefab;
	    void Start()
	    {
	        for (int i = 0; i < 10; i++)
	        {
	            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
	        }
	    }
	}

/* EJEMPLO 2 - En el siguiente ejemplo se instancia el prefab llamado proyectil 
(apartir de su rigidbody) cada ves que se aprete la tecla (fire1), y se da una velocidad 
a dichas copias(proyectiles).
*/

	using UnityEngine;

	// Instantiate a rigidbody then set the velocity

	public class Example : MonoBehaviour {
	    // Assign a Rigidbody component in the inspector to instantiate

	    public Rigidbody projectile;

	    void Update() {
	        // Ctrl was pressed, launch a projectile
	        if (Input.GetButtonDown("Fire1")) {
	            // Instantiate the projectile at the position and rotation of this transform
	            Rigidbody clone;
	            clone = Instantiate(projectile, transform.position, transform.rotation);

	            // Give the cloned object an initial velocity along the current
	            // object's Z axis
	            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
	        }
	    }
	}

/* EJMPLO 3 - En el siguiente ejmplo se instancia el prefab txt_prefab cada vez que se
presione un boton (este codigo es un comienzo para una calculadora o parecidos).
*/
using UnityEngine;
using UnityEngine.UI;

public class InstanciarTxt : MonoBehaviour {
    [SerializeField]
    public GameObject txt_prefab;

    public string DATA;

    private float espacio_controller;
    private float sup_controller;

    void Start() {
    	espacio_controller = 1f;
        DATA = "";
    }
    void Update() {}

    public void btnUno() {
        GameObject txt_obj = Instantiate(txt_prefab);
        DATA += "1";
        crearTxt(txt_obj, "1");
    }
    public void btnDos() {
        GameObject txt_obj = Instantiate(txt_prefab);
        DATA += "2";
        crearTxt(txt_obj, "2");
    }
    public void btnTres() {
        GameObject txt_obj = Instantiate(txt_prefab);
        DATA += "3";
        crearTxt(txt_obj, "3");
    }
    private void crearTxt(GameObject obj, string typ) {
        obj.transform.SetParent(gameObject.transform);
        obj.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(((espacio_controller * 20f)), 0, 0);
        obj.GetComponent<Text>().text = typ;
        espacio_controller++;
    }

    public void mostrar() {
        print(DATA);
    }
}