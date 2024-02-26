#include <stdio.h>
#include <string.h>
#include "mpi.h"
#define BUF_LEN 256
#define MSG_TAG 100

using namespace std;

void HelloWorld1(int* argc, char** argv);
void HelloWorld2(int* argc, char** argv);
void HelloWorld3(int* argc, char** argv);
void lb4(int* argc, char** argv);

int main(int* argc, char** argv)
{
    lb4(argc, argv);
    return 0;
}

void HelloWorld1(int* argc, char** argv)
{
    MPI_Init(argc, &argv);
    printf("Hello World");

    MPI_Finalize();
}

void HelloWorld2(int* argc, char** argv)
{
    int rank, size;

    MPI_Init(argc, &argv);
    
    MPI_Comm_size(MPI_COMM_WORLD, &size);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);

    printf("Hello from process %d, of %d\n", rank, size);

    MPI_Finalize();
}

void HelloWorld3(int* argc, char** argv)
{
    int my_rank;
    int numprocs;
    int source, dest;
    char message[BUF_LEN];
    MPI_Status status;

    MPI_Init(argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &my_rank);
    MPI_Comm_size(MPI_COMM_WORLD, &numprocs);

    if (my_rank != 0) {
        sprintf_s(message, sizeof(message), "Hello from process %d", my_rank);
        dest = 0;
        MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);
    }
    else {
        for (source = 1; source < numprocs; source++) {
            MPI_Recv(message, BUF_LEN, MPI_CHAR, source, MSG_TAG, MPI_COMM_WORLD, &status);
            printf("%s\n", message);
        }
    }

    MPI_Finalize();
}

void lb4(int* argc, char** argv)
{
    int my_rank;
    int numprocs;
    int source, dest;
    char message[BUF_LEN];
    MPI_Status status;

    MPI_Init(argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &my_rank);
    MPI_Comm_size(MPI_COMM_WORLD, &numprocs);

    if (my_rank == 0) {
        dest = 1;
        sprintf_s(message, sizeof(message), "Hello from process %d to process %d", my_rank, dest);
        MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);

        dest = 2;
        sprintf_s(message, sizeof(message), "Hello from process %d to process %d", my_rank, dest);
        MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);
    }
    else if (my_rank == 2) {
        dest = 0;
        sprintf_s(message, sizeof(message), "Hello from process %d to process %d", my_rank, dest);
        MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);

        dest = 1;
        sprintf_s(message, sizeof(message), "Hello from process %d to process %d", my_rank, dest);
        MPI_Send(message, strlen(message) + 1, MPI_CHAR, dest, MSG_TAG, MPI_COMM_WORLD);
    }

    for (source = 1; source < numprocs; source++) {
        if (source != my_rank) {
            MPI_Recv(message, BUF_LEN, MPI_CHAR, source, MSG_TAG, MPI_COMM_WORLD, &status);
            printf("%s\n", message);
        }
    }

    MPI_Finalize();
}

