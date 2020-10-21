

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    FILE *archivo;
    char caracter;
    int pos = 0;
    archivo = fopen("prueba.txt","r");

    if (archivo == NULL){
        printf("\nError de apertura");
    }
    else{
        while(feof(archivo) == 0){
	    caracter = fgetc(archivo);
	    pos = ftell(archivo);
	    printf("El contenido del archivo de prueba es %i %c \n",pos, caracter);
	}
    }
    fclose(archivo);
    return EXIT_SUCCESS;

}
