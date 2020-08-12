/*  Time.deltaTime
	se usa para el los que la rapidez de frames del juego sea el mismo para todas los dispositivos
	Por ejemplo un juego de 60 frames redira bien en una computadora moderna, pero en una computadora
	antigua que solo resiste 30 frames no sera asi (se vera muy lento) y Time.deltaTime lo repara.
*/

Rigidbody rb = gameObject.GetComponent<Rigidbody>();
float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");

// Algunos ejemplo del uso de Time.deltaTime

rb.AddForce(new Vector2(-1000f * Time.deltaTime, 0));

rb.AddForce(new Vector3(h, 0.5f, v) * Time.deltaTime);