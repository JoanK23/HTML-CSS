/* Paleta de colores:
  c1: #d3d0cb
  c2: #1e2019
  c3: #E2C044
  c4: #587b7f
*/

:root {
  --c1 : #d3d0cb;
  --c2 : #1e2019;
  --c3 : #E2C044;
  --c4 : #587b7f;
}

/*Eliminar márgenes exteriores e interiores de todos los elementos del documento y aplicar el tipo de letra Verdana*/

* {
  margin : 0
  padding : 0
  font-family : Verdana;
}

/*Aplicar el color de fondo c1 y centrar su contenido en 
la cabecera y pie de página*/

header, footer {
  background-color : c1;
  text-align : center;
}

/*Aplicar una altura de 10 em a la imagen que está contenida en el header y un margen superior e inferior de 0.2em (usa dos propiedades para los márgenes)*/

header img {
  height : 10em;
  margin-top : 0.2em;
  margin-bottom : 0.2em;
}


/*Aplicar un tamaño mínimo de altura de 5em al pie de página*/

footer {
  min-height : 5em;
}



/*Cambiar el color de texto a c2 a todos los enlaces de la página*/

nav a {
  color : c2;
}


/*Eliminar subrayado a todos los elementos que no tengan la clase .selected-link y que están dentro de un nav*/

nav a:not(.selected-link) {
  text-decoration : none;
}

nav a:not(.selected-link):hover {
  text-decoration : underline;
}


/*Añadir bordes punteados de tamaño 0.15em y del color c2 al último enlace que hay como hijo directo en el nav del encabezado que está junto a una imagen*/

nav a:last-child {
  border-bottom : 0.15em solid c2;
}



/*Aplica márgenes interiores superiores e inferiores de 2em al nav con la clase "social-media" que está en el pie de página usando una sola propiedad*/

nav.social-media {
  margin : 2em 0;
}


/*Selecciona el formulario que está a continuación de un título h1 y céntralo horizontalmente y también ese título que es descendiente directo del main*/

main + h1 {
  display : flex;
  justify-content : center;
}


/*Aplica color de fondo c2 y color de texto c1 y márgenes interiores de 1.5em al main*/

main {
  background-color : c2;
  padding : 1.5em;
}


/*Aplica color de texto c1 al enlace con id condicions-generals*/

#condicions-generals {
  color : c1;
}


/*Aplica márgenes interiores de 0.4em (superior e inferior) a todos los párrafos que son descendientes directos de un formulario*/

form > p {
  margin : 0.4em 0;
}


/*Selecciona todos los inputs de tipo submit que sean descendientes de un formulario y aplica el color de fondo c3 y un margen exterior superior de 1.5em y un margen interior de 0.2em*/

form input[type="submit"]:checked +.accent {
  background-color : c3;
  margin-top : 1.5em;
  margin-bottom : 0.2em;
}


/*Selecciona todos los inputs con la clase accent de tipo checkbox que estén seleccionados y aplica un accent-color de c4*/

form input[type="checkbox"].accent:checked {
  accent-color : c4;
}