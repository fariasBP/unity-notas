// FORMA GENERAL

	// Moviendo el gameObject a un lugar en especifico
	gameObject.GetComponent<Transform>().position = new Vector3(20, 0, 0); // Vector3(<float x>, <float y>, <float x>)

	// Moviendo el gameObject 20 unidades a la derecha con respecto a su posicion
	gameObject.GetComponent<Transform>().position = new Vector3(gameObject.GetComponent<Transform>().position.x + 20, gameObject.GetComponent<Transform>().position.y + 0, gameObject.GetComponent<Transform>().position.z + 0);

// FORMA SIMPLIFICADA

	// Moviendo el gameObject a un lugar en especifico
	gameObject.transform.position = new Vector3(20, 0, 0);

	// Moviendo el gameObject 20 unidades a la derecha con respecto a su posicion
	gameObject.transform.position = new Vector3(gameObject.transform.position.x + 20, gameObject.transform.position.y + 0, gameObject.transform.position.z + 0);


/* NOTA: gameObject hace referencia al objeto que se le añadio el script, y por lo tanto
		tambien se le puede remplazar con un < this >*/

	this.transform.position = new Vector3(20, 0, 0);

