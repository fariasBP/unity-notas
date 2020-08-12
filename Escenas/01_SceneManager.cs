/*
SceneManager
clase en UnityEngine.SceneManagement/Implementado en:UnityEngine.CoreModuleDejar comentarios
Descripción
Administración de escenas en tiempo de ejecución.

Propiedades estáticas
	- sceneCount >>>	El número total de escenas cargadas actualmente.
	- sceneCountInBuildSettings >>>	Número de escenas en Configuración de compilación.
Métodos estáticos
	- CreateScene >>>	Cree una nueva escena vacía en tiempo de ejecución con el nombre especificado.
	- GetActiveScene >>>	Obtiene la escena activa actualmente.
	- GetSceneAt >>>	Obtenga la escena en el índice en la lista de escenas cargadas del SceneManager.
	- GetSceneByBuildIndex >>>	Obtener una estructura de escena de un índice de compilación.
	- GetSceneByName >>>	Busca en escenas cargadas para una escena con el nombre especificado.
	- GetSceneByPath >>>	Busca en todas las escenas cargadas una escena que tenga la ruta de acceso de activos determinada.
	- LoadScene >>>	Carga la escena por su nombre o índice en Configuración de compilación.
	- LoadSceneAsync >>>	Carga la escena de forma asincrónica en segundo plano.
	- MergeScenes >>>	Esto combinará la escena de origen en la destinationScene.
	- MoveGameObjectToScene >>>	Mueve un GameObject de su escena actual a una nueva escena.
	- SetActiveScene >>>	Establezca la escena para que esté activa.
	- UnloadSceneAsync >>>	Destruye todos los GameObjects asociados con la escena dada y elimina la escena del SceneManager.
Eventos
	- activeSceneChanged >>>	Suscríbete a este evento para recibir una notificación cuando la escena activa haya cambiado.
	- sceneLoaded >>>	Agregue un delegado a esto para recibir notificaciones cuando se haya cargado una escena.
	- sceneUnloaded >>>	Agregue un delegado a esto para obtener notificaciones cuando se haya descargado una escena.