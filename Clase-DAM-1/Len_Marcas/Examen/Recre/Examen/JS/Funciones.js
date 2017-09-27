function recuento() {
	var p = document.getElementsByTagName('img');
	var tirActual;
	var puntos = 0;

	if( (p[1].src == p[2].src) && 
   	   (p[2].src == p[3].src) )
   	    // Las tres imágenes son iguales
        puntos = 1000;
    else
   	    if ( (p[1].src == p[2].src) || 
   	         (p[1].src == p[3].src) || 
   	         (p[2].src == p[3].src) )
   	  	  // Dos iḿágenes iguales
   	  	  puntos = 500;
   	    else
   	  	  // Las tres imágenes distintas
   	  	  puntos = 0;

   	// Actualizar el contador actual
    tirActual = document.getElementById('total2');
    tirActual.innerHTML = puntos;
}

function aleatorio(num) {
	var p = Math.floor((Math.random()*3)+1);
	var imagen = document.getElementsByTagName('img');

	if(p==1){
		imagen[num].src = "../Imagenes/Fresa.png";
	} 

	if(p==2){
		imagen[num].src = "../Imagenes/Limon.png";
	} 
	
	if (p==3) {
		imagen[num].src = "../Imagenes/Sandia.png";
	}
}

// Falta esto
function jugar() {
	var imagenes = document.getElementsByTagName('img');

	for (var i = 1; i < imagenes.length; i++) {
		aleatorio(i);
	}
	recuento();
}

function jugarCam1(num) {
	aleatorio(num);
	recuento();
}

function reiniciar(total){
	var p

	for (var i = 1; i < 3; i++) {
		p = document.getElementById(total+i);
		p.innerHTML = 0;
	}
}

function guardar() {
	var tot2 = document.getElementById("total2");
	var puntos = parseInt(tot2.innerHTML);
	tot2.innerHTML = 0; // Falta esto
	var tot1 = document.getElementById("total1");
	puntos += parseInt(tot1.innerHTML);
	tot1.innerHTML = puntos;

}