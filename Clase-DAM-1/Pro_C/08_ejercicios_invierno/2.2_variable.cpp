

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
    Crea pos_mayor
    Crea num_comparar = 0
    Mientras numero de preguntas <= 10
        pregunta numero
        guarda numero en pos_mayor
        si pos_mayor > num_comparar
            num_comparar = pos_mayor
        escribe "el numero mayor es " num_comparar
    */

    int pos_mayor, num_comparar = 0;

    for (int c=10; c>0; c--){
  
        printf("Escribe un numero, te quedan %i numeros por escribir : ", c);
        scanf(" %i", &pos_mayor);

        if(pos_mayor > num_comparar)
            num_comparar = pos_mayor;
 
   }
    
    printf("\nEl numero mayor es %i\n", num_comparar);

    return EXIT_SUCCESS;

}
