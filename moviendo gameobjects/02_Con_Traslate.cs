/* MOVER UN GAMEOBJECT CON TRASLATE
	Mueve o trasalada un elemento a una distancia con relacion a la posicion de dicho objeto o con
	relacion al sistema de cordenadas universal.
	TEMAS:
		- Traslate(traslation, ?relativeTo)
			- traslation >>> Vector de cordenadas, que indica la direccion y magnitud en la que se
			movera la transformacion.
			- relativeTo >>> Objeto Space que indica, con respecto a que se movera la transformacion:
				- Space.World >>> el movimiento se aplica en relacion al eje de cordenadas universal
				en otras palabras se mueve en relacion a la pantalla
				- Space.Self >>> el movimiento se aplica en relacion con los ejes locales de la 
				trasformacion en otras palabras se mueve en relacion a su posicion actual.
			Si no se establece este parametro el valor por defecta sera Space.Self.
	SINTAXIS:
		- gameObject.transform.Traslate(<Vector3 traslation>, <?Space relativeTo>);
		- gameObject.transform.Traslate(<float x>, <float y>, <float, z>, <?Space relativeTo);
*/

// CON TRASLATE
	/*En este ejemplo el gameobject se mueve 20 unidades a la derecha con recpecto a su posicion*/
	gameObject.transform.Traslate(20f, 0, 0);
	/*O tambien:*/
	gameObject.transform.Traslate(20f, 0, 0, Space.Self);