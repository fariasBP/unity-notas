/* CARGAR UNA ESCENA - LoadScene
	Carga la escena por su nombre o indice, en la configuracion de compilacion. Sin embargo no es
	recomendable utilizarla ya que si la escena es muy grande provocara pusas o problemas de 
	rendimiento durante la carga, en su lugar se recomienda usar LoadSceneAsync.
	TEMAS:
		- LoadScene(sceneName, ?mode)
			- sceneName >>> Nombre o ruta de acceso de la escena que se va a cargar.
			- ?mode >>> Le permite especificar si desea cargar la escena de forma simple 
			(LoadSceneMode.Single) o de forma aditiva (LoadSceneMode.Additive)
				- LoadSceneMode.Single >>> Cierra todas las escenas cargadas actualmente y carga la
				escena especificada en sceneName.
				- LoadSceneMode.Additive >>> Agrega la escena especificada en sceneName a las 
				escenas cargadas actuales.
			Si no se establece este paramatro el valor por defecto sera LoadSceneMode.Single
		- LoadScene(sceneBuildIndex, ?mode)
			- sceneBuildIndex >>> Index de la escena en la configuracion de compilacion que va
			a cargar.
			- ?mode >>> ya se menciona sobre este parametro.
*/

/* EJMPLO 1 - cargar la siguiente escena
	En este ejemplo (de dos escenas) verifica que escena esta cargada y apartir de ello carga
	la siguiente escena
*/
if (SceneManager.GetActiveScene().name == "mi_escena_1") {
	SceneManager.LoadScene("mi_escena_2");
} else if (SceneManager.GetActiveScene().name == "mi_escena_2") {
	SceneManager.LoadScene("mi_escena_1");
}