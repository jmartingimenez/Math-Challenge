# Math Challenge

Math Challenge es un simple juego matemático en el que tenes tan solo 30 segundos para resolver el mayor número de operaciones posibles.

Esta pequeña aplicación fue hecha en C# en un fin de semana aprovechado para conocer un poco del lenguaje. El menú principal ofrece el tipo de operación a resolver entre los disponibles y la posiblidad de ingresar tu nombre que sera usado para guardar los puntajes. Entre las operaciones pueden encontrarse...

  - Sumas
  - Restas
  - Multiplicaciones
  - Modo Mixto (Operaciones mezcladas)

# Records persistentes!
  - Si, los records se guardan aun cerrando la aplicación y estan asociados a el nombre que uses al momento de jugar. Ideal para presumir (?).
  - Cuando finalizas los 30 segundos se genera un archivo en '%APPDATA%\Math Challenge\Records' con los datos de la partida siempre y cuando superes el record anterior.

# Sobre las operaciones

Las clases que generan al azar las operaciones tienen ciertas condiciones para que el resultado SIEMPRE tenga dos dígitos. La dificultad no es excesiva, ya que el objetivo no es medir la capacidad para resolver una operación, si no el de ser lo mas veloz posible. Limitando los resultados a dos dígitos se asegura que no existan ventajas o desventajas al momento de tipear y que los records puedan ser comparables de mejor manera.
