function z=Gauss(A,b)
    C=Simplex(A,b);
    N=size(A,1);
    v(N)=C(N,N+1);
    for j=1: N-1
        s=0;
        for k=0: j-1
            s=s+C(N-j,N-k)*v(N-k);
        end
        v(N-j)=(C(N-j,N+1)-s)/C(N-j,N-j);
    end
    z=v';
end