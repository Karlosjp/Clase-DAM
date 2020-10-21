
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){
 
    // Imprime una cádena de caracteres con un beep del altavoz hasta que llegues al valor centinela

    char beep[] = "Hola";
    
    for (int n=0; beep[n]; n++)
        printf("Letra : %c\n\a", beep[n]);

    return EXIT_SUCCESS;

}
