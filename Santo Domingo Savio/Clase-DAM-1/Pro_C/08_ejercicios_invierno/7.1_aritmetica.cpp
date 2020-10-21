
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    // En una clase hay 170 alumnos organizados en filas de 17
    // hacer un programa que localize a cada alumno por su numero de fila
    
    int alumno = 0, fila = 0, localizar;

    printf("Que alumno quieres consultar : ");
    scanf(" %i", &localizar);

    if(localizar >=1 && localizar <= 170){
        
	fila = ((localizar - 1) / 17);
        alumno = ((localizar - 1) % 17) + 1;
	
	printf("El alumno esta en la fila %i, columna %i\n", fila, alumno);
    } 
    return EXIT_SUCCESS;

}
