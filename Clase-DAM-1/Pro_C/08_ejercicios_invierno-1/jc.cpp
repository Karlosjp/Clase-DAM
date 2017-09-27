
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    char palabra[] = "Cacatua";

    for(int i=0; i<sizeof(palabra)/sizeof(char)-1; i++)
        printf("%c\n", palabra[i]+3);
    	return EXIT_SUCCESS;

}
