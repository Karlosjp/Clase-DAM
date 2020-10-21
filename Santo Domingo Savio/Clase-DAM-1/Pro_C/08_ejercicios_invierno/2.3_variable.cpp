

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
    Crea pos_menor
    Crea num_comparar 
    Mientras numero de preguntas <= 10
        pregunta numero
        guarda numero en pos_menor_
        si pos_menor > num_comparar
            num_comparar = pos_menor
        escribe "el numero menor es " num_comparar
    */

    int pos_menor, num_comparar = 0;

    for (int c=10; c>0; c--){
  
        printf("Escribe un numero, te quedan %i numeros por escribir : ", c);
        scanf(" %i", &pos_menor);
        
        if(num_comparar == 0)
            num_comparar = pos_menor;

        if(pos_menor < num_comparar)
            num_comparar = pos_menor;
 
   }
    
    printf("\nEl numero menor es %i\n", num_comparar);

    return EXIT_SUCCESS;

}
