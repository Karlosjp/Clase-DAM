
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){
    
    char *nombres[] = {
        "Angel y Tome0",
	"Miguel",
        "Jose Manuel", 
	"Fernando M y me encntraras",
	"Alvaro",
	"Iván Dando",
	"Santiago Suma y Sieger",
	NULL
    };


    for (int n=0; nombres[n]!=NULL; n++)
        printf("%i.- %s\n", n+1, nombres[n]); 

    return EXIT_SUCCESS;

}
