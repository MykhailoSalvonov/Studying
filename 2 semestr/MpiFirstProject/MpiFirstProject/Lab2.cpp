#include <stdio.h>
#include <string.h>
#include "mpi.h"

void Lab2(int* argc, char** argv)
{
    int rank, size;

    MPI_Init(argc, &argv);

    MPI_Comm_size(MPI_COMM_WORLD, &size);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);

    printf("Hello from process %d, of %d\n", rank, size);

    MPI_Finalize();
}