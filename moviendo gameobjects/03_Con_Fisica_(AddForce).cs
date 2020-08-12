/* MOVER UN GAMEOBJECT CON FISICAS (AddForce)
	AddForce es un metodo de unity que añade una fuerza a un cuerpo rigido (Rigidbody). La
	fuerza se aplica continuamente a lo largo del vector(<Vector3 force>).
	TEMAS:
		-AddForce(force, ?mode)
			- force >>> Forzar vector en coordenadas mundiales. Que es lo que indica por donde se la
						direccion y magnitud de la fuerza a aplicar.
			- ?mode >>> Tipo de fuerza a aplicar. Que son opcion extras como aceleracion, impulso, 
						cambio de velocida (este parametro no es indispensable).
	SINTAXIS
	[Rigidbody].AddForce(<Vector3 force>, <[?ForceMode mode]>)

*/

/* EJEMPLO 1, en el siguiente ejemplo se añade una fuerza 1000 hacia la derecha al gameobject que
	tiene esta script*/

	gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1000f, 0, 0));

/* EJEMPLO 2, en el siguiente ejemplo se añade una fuerza dependiendo el jostick (derecha o izquierda)
	al gameobject que tiene esta script y ademas se le añade fluides con DeltaTime*/

	rb = gameobject.GetComponent<Rigidbody>();
	float h = Input.GetAxis("Horizontal");
	float v = Input.GetAxis("Vertical");

	rb.AddForce(new Vector3(h, 0.5f, v) * fuerza * Time.deltaTime);

/* EJEMPLO 3, en el siguiente ejemplo se añade una fuerza en el eje z y con un impulso (este impulso
	depende depende de la masa del rigidbody)*/
	public float thrust = 1.0f;
    public Rigidbody rb;

    rb = GetComponent<Rigidbody>();
    rb.AddForce(0, 0, thrust, ForceMode.Impulse);