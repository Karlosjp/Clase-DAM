#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <unistd.h>
#include <signal.h>
#include <strings.h>
#include <dlfcn.h>

sig_atomic_t num_hijos;

const * char imprimir[][];

void spawn ()
{
    pid_t pid_hijo;

    pid_hijo = fork();
    if(child_pid != 0)
        return;
}

int main (int argc, char *argv[])
{
    struct sigaction sa;
    bzero(&sa, sizeof(sa));

    void* handle = dlopen("funciones.so", RTLD_LAZY);
    sa.sa_handler = dlsym(handle, "escribir");
    sigation (SIGURS1, &sa, NULL);

    dlclose(handle);
}
