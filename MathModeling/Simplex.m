function z=Simplex (A,b)
    N=size(A,1); % Визначення числа рівнянь системи
    C=cat(2,A,b); % Створення розширеної матриці системи
    for i=1: N-1
        if C(i,i)==0
            C=Exchange(C,i);
        end
        for j=0:N
            C(i,N+ 1-j)=C(i,N+ 1-j)/C(i,i);
        end
        for m=i+1:N
            alpha=C(m,i);
            for j=i:N+1
                C(m,j)=C(m,j)-alpha*C(i,j);
            end
        end
    end
    C(N,N+1)=C(N,N+1)/C(N,N);
    C(N,N)=1;
    z=C;
end