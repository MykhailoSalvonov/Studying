function z=Exchange(C,i)
    k=i+1;
    while C(k,i)==0
        k=k+1;
    end;
    for j=1:size(C,1)
        s=C(i,j);
        C(i,j)=C(k,j);
        C(k,j)=s;
    end;
    z=C;
end