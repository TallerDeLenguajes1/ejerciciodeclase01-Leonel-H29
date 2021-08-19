# ejerciciodeclase01-Leonel-H29
ejerciciodeclase01-Leonel-H29 created by GitHub Classroom


- Ejercicio AdivinarNumero:
  Visto en clase
  
- Problema 1:

      * System.IndexOutOfRangeException: 'Index was outside the bounds of the array'. El indice estaba fuera del rango del array, esto se debe a que en el for se intenta acceder a mas posiciones del arreglo de las permitidas.
      Solucion: Una valida seria poner el Try catch antes del for para controlar si se pueden acceder a todos los elemetos correspondientes sin sobrepasarse del tamaño del arreglo.
      
- Problema 2:      

      * System.OverflowException: 'Value was either too large or too small for an unsigned byte'. El valor era demasiado grande o demasiado pequeño para un byte
      Solucion: Una valida seria poner el Try catch antes de asignarle los valores a las variables que se utilizan para la operacion. 

- Problema 3:

      * System.NullReferenceException: 'Object reference not set to an instance of an object'. Referencia a objeto no establecida como instancia de un objeto, esto es debido a que le estoy mandando un valor nulo o vacio como paramentro de la funcion 
      Solucion: Una valida seria poner el Try catch ... .
      Este es un problema que se podria resolver sin nesecidad del Try Catch.

- Problema 4:

      * System.FormatException: 'Index (zero based) must be greater than or equal to zero and less than the size of the argument list'. El índice (basado en cero) debe ser mayor o igual a cero y menor que el tamaño de la lista de argumentos; esto se debe a que se quiere mostrar el valor de una variable que no existe.
      Solucion: Una valida seria poner el Try catch antes de declarar las variables con sus valores; en el catch poner FormatException y delvolver un mensaje correspondiente a este error, y otro catch para otro tipo de errores.
  