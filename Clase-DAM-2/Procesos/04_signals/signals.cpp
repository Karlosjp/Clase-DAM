#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <signal.h>
#include <unistd.h>

sig_atomic_t sigusr1_count = 0;

void handler (int signal_number)
{
    ++sigusr1_count;
}

int
main(int argc, char *argv[])
{
    struct sigaction sa;
    memset (&sa, 0, sizeof(sa));
    sa.sa_handler = &handler;
    sigaction(SIGUSR1, &sa, NULL);

    printf("SIGUSR1 was raised %d times \n", sigusr1_count);

    return EXIT_SUCCESS;
}
