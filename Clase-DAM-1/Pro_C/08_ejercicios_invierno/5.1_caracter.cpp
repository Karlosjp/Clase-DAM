
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    //calcula la distancia entre 2 caracteres
    
    FILE *letra;
    char p_letra, s_letra, caracter;
    int pos_pl, pos_sl;
    
    printf("Escribe la primera letra : ");
    scanf(" %c", &p_letra);

    printf("Escribe la primera letra : ");
    scanf(" %c", &s_letra);
    
    letra = fopen("ejercicio.txt","r");

    while(feof(letra) == 0){
        caracter = fgetc(letra);
	if (caracter == p_letra){
    	    pos_pl = ftell(letra);
	    fseek(letra,0,SEEK_END);
	    printf("%i", pos_pl);
	}
    }
 
    rewind(letra);

    while(feof(letra) == 0){
        caracter = fgetc(letra);
	if (caracter == s_letra){
    	    pos_sl = ftell(letra);
	    fseek(letra,0,SEEK_END);
	    printf("%i", pos_sl);
	}
    }

    printf("Las letras %c y %c estan con una diferencia de : %i\n", p_letra, s_letra, pos_pl - pos_sl);
    
    fclose(letra);
    return EXIT_SUCCESS;

}
