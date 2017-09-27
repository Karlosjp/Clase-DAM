
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    // Haz una barra de estado que crezca de izquierda a derecha y termine en >
    int n = 0;
    
    while(n<15){
        printf("=");
	n++;
    }

    printf("=>\n");

    return EXIT_SUCCESS;

}
