# Reto_3.1
# Videogame Design Document
## Sección 1 - Generalidades
1. <b>Título:</b>
"Pacman 3D"

2. <b>Género del juego:</b>
 Acción y estrategia 

3. <b> Perspectiva:</b>
tridimensional en la que el laberinto y los personajes se representan en un entorno 3D con profundidad.

4. <b> Modo(s) de juego:</b>
Un jugador

5. <b>Audiencia objetivo:</b>
-Toda las edades

6. <b>Idea central:</b>
 "Pac-Man: Laberinto 3D" es una emocionante reinvención en tres dimensiones del legendario juego de arcade Pac-Man. Los jugadores se sumergirán en un mundo tridimensional lleno de laberintos en constante cambio, mientras guían a Pac-Man a través de la recolección de puntos, la obtención de power-ups y la evasión de fantasmas para alcanzar puntuaciones récord.

7. <b>Objetivo del juego:</b>
 comer todos los puntos y objetos especiales mientras evitas a los fantasmas. El juego se vuelve progresivamente más difícil a medida que avanzas de nivel, ya que los fantasmas se vuelven más rápidos y astutos. La puntuación más alta es un objetivo común en Pac-Man, ya que los jugadores intentan superar sus propios récords y competir con otros.

8. <b>Tópico del juego:</b>
Juego 3D Acción y estrategia

9. <b>Plataformas disponibles:</b><br>
-Android<br>
-PC (Linux, Win11)

## Sección 2 - Background & Flujo del juego
1. <b>Contexto: </b>
Pac-Man fue lanzado por Namco en 1980 y se convirtió en uno de los juegos de arcade más influyentes y populares de la década. La década de 1980 fue una época dorada para los videojuegos arcade, con una creciente industria de entretenimiento electrónico que se estaba desarrollando.
En esa época, los salones recreativos o arcades eran lugares populares de entretenimiento, donde los jugadores iban a disfrutar de los últimos juegos. Pac-Man se convirtió en un éxito instantáneo en los arcades de todo el mundo, atrayendo tanto a jugadores casuales como a fanáticos de los videojuegos.
Pac-Man se destacó por su enfoque innovador en cuanto a jugabilidad. Fue uno de los primeros juegos en presentar un personaje central con una mecánica simple pero adictiva: comer puntos en un laberinto mientras evitas a los fantasmas.
Pac-Man en 3D se beneficiaría de la tecnología y los avances actuales en la industria de los videojuegos. Aunque mantendría la esencia clásica de Pac-Man, aprovecharía las oportunidades que ofrece la perspectiva tridimensional para ofrecer una experiencia fresca y emocionante a los jugadores.
2. <b>Historia del personaje:</b>
Pac-Man fue creado por el diseñador de videojuegos japonés Toru Iwatani, quien trabajaba para Namco. Iwatani se inspiró en una pizza con una porción faltante y diseñó un personaje que consistía en un círculo con una boca que parecía abrir y cerrarse mientras se movía.
Toru Iwatani diseñó a Pac-Man con la intención de que fuera un personaje amigable y atractivo, destinado a atraer a un público más amplio, incluyendo a mujeres y niños. El diseño de Pac-Man es simple pero efectivo, y su personalidad se refleja en su insaciable apetito por los puntos.
: A pesar de los cambios en la industria de los videojuegos, Pac-Man ha mantenido su relevancia y sigue siendo un ícono de los videojuegos. El juego original y sus personajes continúan siendo reconocidos y amados por jugadores de todas las edades.

4. <b>Historia de los enemigos:</b>
-Blinky (También conocido como Shadow): Color: Rojo. Blinky es el más agresivo de los cuatro fantasmas. Siempre persigue a Pac-Man directamente y trata de reducir la distancia entre ellos. Blinky se considera el líder de los fantasmas y es el más rápido en perseguir a Pac-Man.
-Pinky (También conocido como Ambush): Color: Rosa. Pinky intenta emboscar a Pac-Man. En lugar de perseguirlo directamente, Pinky trata de posicionarse donde cree que estará Pac-Man después de varios movimientos. Pinky es astuto y puede ser impredecible en su estrategia de emboscada.
-Inky (También conocido como Bashful): Color: Azul claro. Inky es un poco tímido y suele moverse de manera errática. Su comportamiento se basa en la posición de Blinky y Pinky en relación con Pac-Man. A menudo, intenta moverse en una dirección opuesta a la de los otros dos fantasmas. Inky puede ser impredecible y, a veces, muestra un comportamiento errático debido a su timidez.
-Clyde (También conocido como Pokey): Color: Naranja. Clyde es el más impredecible de los cuatro. A veces, persigue a Pac-Man, pero a menudo se aleja de él. Su comportamiento es menos consistente que el de los otros tres fantasmas. Clyde a menudo se comporta de manera temerosa o confusa, lo que lo hace menos agresivo que Blinky.

5. <b>Desarrollo de la historia:</b><br>
-Pac-Man es un personaje amigable que vive en el mundo de los laberintos. Su forma circular y su boca grande están diseñados para reflejar su insaciable apetito. Originalmente, no había una historia de fondo completa para el personaje, ya que el juego se centraba en la acción de comer puntos y evadir a los fantasmas.<br>
-Los cuatro fantasmas, Blinky, Pinky, Inky y Clyde, son los habitantes inquietantes del laberinto. Cada uno tiene una personalidad y un comportamiento distintivo en el juego. Su objetivo principal es atrapar a Pac-Man y evitar que coma todos los puntos.<br>
-El objetivo de Pac-Man es simple: comer todos los puntos en el laberinto mientras evita ser atrapado por los fantasmas. A lo largo de los niveles, Pac-Man también puede comer objetos especiales que temporalmente hacen que los fantasmas sean vulnerables y comestibles.<br>


## Seccción 3 - Juego
1. <b>Objectivos:</b><br>
Objetivo principal: comer todos los puntos (generalmente de color blanco) distribuidos por el laberinto. Los puntos están en pasillos y deben ser consumidos para avanzar en el juego.<br>
Otros objetivos: Además de los puntos, Pac-Man puede comer frutas y objetos especiales que otorgan puntos adicionales y, a menudo, temporariamente vuelven a los fantasmas vulnerables. Cuatro fantasmas (Blinky, Pinky, Inky y Clyde) persiguen constantemente a Pac-Man en el laberinto. El jugador debe evitar ser atrapado por los fantasmas, ya que ser atrapado resulta en la pérdida de una vida.
Una vez que Pac-Man ha comido todos los puntos en el laberinto, el jugador avanza al siguiente nivel, que generalmente es un laberinto más complejo y rápido. El ciclo se repite mientras el jugador intenta alcanzar la puntuación más alta posible. 

3. <b>Reglas del juego:</b><br>
-Regla 1: El objetivo principal del juego es comer todos los puntos (bolitas de color blanco) en el laberinto.<br>
-Regla 2: El jugador controla a Pac-Man, el personaje principal, utilizando teclas direccionales. Pac-Man puede moverse en cuatro direcciones: arriba, abajo, izquierda y derecha.<br>
-Regla 3: Cuatro fantasmas, conocidos como Blinky (Rojo), Pinky (Rosa), Inky (Azul) y Clyde (Naranja), persiguen a Pac-Man a lo largo del laberinto.
Los fantasmas tienen comportamientos y estrategias distintivas: Blinky siempre persigue a Pac-Man, Pinky intenta emboscarlo, Inky actúa de manera impredecible y Clyde a menudo se mueve de manera errática.
Si un fantasma toca a Pac-Man, este pierde una vida.<br>
-Regla 4: Además de los puntos normales, hay objetos especiales, como frutas y pastillas de energía, en el laberinto. Comer una pastilla de energía temporariamente hace que los fantasmas sean vulnerables, lo que permite a Pac-Man comerlos para ganar puntos adicionales.<br>
-Regla 5: Una vez que Pac-Man ha comido todos los puntos en el laberinto, el jugador avanza al siguiente nivel, que generalmente es un laberinto más complejo y rápido.<br>
-Regla 6: El jugador comienza con un número limitado de vidas (generalmente 3 vidas). Cada vez que un fantasma atrapa a Pac-Man, se pierde una vida. Si se quedan sin vidas, el juego termina.<br>
-Regla 7: El juego continúa hasta que el jugador decide abandonarlo o hasta que se quedan sin vidas. El objetivo es obtener la puntuación más alta posible en ese tiempo.


5. <b>Mecánica del juego:</b><br>
  -El jugador controla a Pac-Man, un personaje redondo con una boca grande. Pac-Man puede moverse en cuatro direcciones: arriba, abajo, izquierda y derecha. El movimiento es utilizado para navegar por el laberinto y comer puntos.<br>
  -El objetivo principal del juego es comer todos los puntos (generalmente de color blanco) en el laberinto. Al hacerlo, el jugador avanza al siguiente nivel. <br>
  -Cuatro fantasmas (Blinky, Pinky, Inky y Clyde) persiguen constantemente a Pac-Man en el laberinto. Cada uno de ellos tiene un comportamiento distinto. Por ejemplo, Blinky siempre persigue a Pac-Man, mientras que Pinky trata de emboscarlo.<br>
  -Además de los puntos normales, hay frutas y pastillas de energía en el laberinto. Comer puntos y frutas otorga puntos al jugador, mientras que comer una pastilla de energía temporalmente hace que los fantasmas sean vulnerables, permitiendo a Pac-Man comerlos.<br>
  -El jugador comienza con un número limitado de vidas (generalmente 3 vidas). Cada vez que un fantasma atrapa a Pac-Man, el jugador pierde una vida. El objetivo es obtener la puntuación más alta posible antes de quedarse sin vidas.<br>
  -El juego continúa hasta que el jugador decide abandonarlo o hasta que se quedan sin vidas. El objetivo es obtener la puntuación más alta posible en ese tiempo.
6. <b>Necesidades: </b>
• Opciones de Juego:Botón Jugar, Botón instrucciones, seleccionar niveles, opción salir.<br>
• Modos: 1 jugador <br>
• Niveles del Juego: 3 niveles donde se diferencia el nivel de dificultad.<br>
• Elementos de gamificación: <br>
-Logros y Desafíos: Agregar un sistema de logros y desafíos que recompense a los jugadores por cumplir objetivos específicos, como comer un cierto número de fantasmas en una fila o alcanzar ciertas puntuaciones. <br>
-Clasificaciones y Competencias: Permitir a los jugadores competir en clasificaciones en línea para ver cómo se comparan con otros jugadores en términos de puntuación, nivel alcanzado y otros logros.<br>
-Sistema de Retroalimentación: Proporcionar retroalimentación positiva al jugador cuando logra algo significativo, como un mensaje de "¡Excelente!" o animaciones llamativas.<br>


## Sección 4 – Game Play I/O Controls & UI Interfaces
1. <b>Game Play I/O Controls:</b><br>
-Movimiento del personaje: <br>
• flecha derecha <br>
• flecha izquierda <br>
• flecha aariba <br>
• flecha abajo<br>
   
2. <b>GUI Interfaces:</b>

![alt text][wireframe]  
![alt text][Level1]  
![alt text][Menu]
![alt text][Niveles]
![alt text][Opciones]
![alt text][Pausa]
<!-- Referencias para las imagenes -->
[wireframe]: /Wireframe.png "Wireframe de las UI"
[Level1]: /Interfaces/Pantalla_Level1.png "Esquema para el nivel 1"
[Menu]: /Interfaces/Pantalla_Menú.png "Esquema para el menú inicial"
[Niveles]: /Interfaces/Pantalla_Niveles.png "Esquema para la pantalla niveles"
[Opciones]: /Interfaces/Pantalla_Opciones.png "Esquema para la pantalla opciones"
[Pausa]: /Interfaces/Pantalla_Pausa.png "Esquema para pantalla pausa"
   2.1 Menú inicio:<br>
      -En el despliegue menú estan las opciones de Jugar, Opciones, Niveles y salir <br>
   2.2 Menú niveles:<br>
      -En el menú niveles puede verse la opción para escoge los tres niveles que tiene el juego
