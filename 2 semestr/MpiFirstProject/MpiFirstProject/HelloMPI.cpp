#include <stdio.h>
#include <string.h>
#include "mpi.h"
#define BUF_LEN 256
#define MSG_TAG 100

using namespace std;

int main(int argc, char** argv)
{
    int my_rank;
    int numprocs;
    int source; int dest;
    char message[BUF_LEN]; MPI_Status status;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &my_rank);
    MPI_Comm_size(MPI_COMM_WORLD, &numprocs);


    if (my_rank == 0) {
        // Нульовий процес відправляє повідомлення 1-му і 2-му
        for (dest = 1; dest < numprocs; dest++) {
            sprintf_s(message, sizeof(message), "Hello from process %d to process %d", my_rank, dest);
            MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);
        }
    }
    else if (my_rank == 1) {
        // Перший не відправляє повідомлення
    }
    else if (my_rank == 2) {
        // Другий процес відправляє повідомлення 0-му і 1-му
        for (dest = 0; dest < numprocs; dest++) {
            if (dest != my_rank) {
                sprintf_s(message, sizeof(message), "Hello from process %d to process %d", my_rank, dest);
                MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);
            }
        }
    }

    if (my_rank == 0) {
        // Нульовий процес очікує повідомлення від 2-го процесу
        MPI_Recv(message, BUF_LEN, MPI_CHAR, 2, MSG_TAG, MPI_COMM_WORLD, &status);
        printf("%s\n", message);
    }
    else if (my_rank == 1) {
        // Перший процес очікує повідомлення від 2-го та 0-го процесу
        for (source = 0; source < numprocs; source++) {
            if (source != my_rank) {
                MPI_Recv(message, BUF_LEN, MPI_CHAR, source, MSG_TAG, MPI_COMM_WORLD, &status);
                printf("%s\n", message);
            }
        }
    }
    else if (my_rank == 2) {
        // Другий процес очікує повідомлення від 0-го процесу
        MPI_Recv(message, BUF_LEN, MPI_CHAR, 0, MSG_TAG, MPI_COMM_WORLD, &status);
        printf("%s\n", message);
    }

    MPI_Finalize();
    return 0;
}

