/* Input.GetAxis
	Devuelve el valor de eje virtual indentificado por .axisName
	El valor estará en el rango -1...1 para la entrada de teclado y joystick. Si el eje está
	configurado para ser movimiento delta del ratón, el delta del ratón se multiplica por la
	sensibilidad del eje y el rango no es -1...1.
	Esto es independiente de la velocidad de fotogramas;
	no es necesario preocuparse por las diferentes velocidades de fotogramas al utilizar este valor.
	Para configurar la entrada o ver las opciones de , vaya a Edición > Configuración del proyecto >
	Entrada .
	Esto abre el Administrador de entrada. Expanda Eje para ver la lista de las entradas actuales.
	Puede utilizar uno de estos como el archivo . Para cambiar el nombre de la entrada o cambiar el
	botón positivo, etc., expanda una de las opciones y cambie el nombre en el campo Nombre o en el
	campo Botón positivo. Además, cambie el Tipo a Eje joystick. Para agregar una nueva entrada,
	agregue 1 al número en el campo Tamaño.axisNameaxisName
*/

Input.GetAxis("Vertical") // da un valor entre -1 a 1 para jostick o teclado vertical (arriba o abajo)
Input.GetAxis("Horizontal") // da un valor entre -1 a 1 para jostick o teclado horizontal (derecha o izquierda)

/* Input.GetAxisRaw
	A diferencia del anterior que dava valores de "-1 al 0" o del "0 al 1", este solo devuelve
	-1 ó 0 ó 1.
		-1 	=> eje negativo (ej. a o left del teclado)
		0 	=> no se presiona nada
		1	=> eje positivo (ej. d o rigth)

*/
	Input.GetAxisRaw("Vertical")
	Input.GetAxisRaw("Horizontal")