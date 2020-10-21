#include <stdio.h>
#include <stdlib.h>

#define MUEVE(f,c) "\x1b["#f";"#c"f"
int main(int argc, char *argv[]){

    printf(MUEVE(10,5) "Hola\n");
    return EXIT_SUCCESS;

}
