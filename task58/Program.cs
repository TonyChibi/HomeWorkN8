int [,]GetMtx(){
    int [,]mtx=new int [new Random().Next(3,5),new Random().Next(3,5)];
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=0;j<mtx.GetLength(1);j++){
                mtx[i,j]=new Random().Next(1,10);
        }
    }
    return mtx;
}

void ShowMtx(int [,]mtx){
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=0;j<mtx.GetLength(1);j++){
            Console.Write($"{mtx[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] MatrixMultiplication(int [,] A,int [,] B){
    if (A.GetLength(1)!=B.GetLength(0)){
        Console.WriteLine($"sorry, you can not multiply matrix {A} on matrix {B} ");
        return new int [0,0];
    }
    int []mlt=new int [A.GetLength(0)*B.GetLength(1)];
    int index=0;
    for(int n=0;n<A.GetLength(0);n++){
        for (int m=0;m<B.GetLength(1);m++){
            int sum=0;
            for(int k=0;k<A.GetLength(1);k++){
                sum=sum+A[n,k]*B[k,m];
            }
            mlt[index]=sum;
            index++;
        }
    }
    int [,]C=new int [A.GetLength(0),B.GetLength(1)];
    index=0;
    for (int i=0;i<C.GetLength(0);i++){
        for (int j=0;j<C.GetLength(1);j++){
            C[i,j]=mlt[index];
            index++;
        }
    }
    return C;
}


Console.WriteLine("the A matrix is: ");
int [,] A=GetMtx();
ShowMtx(A);
Console.Write(A.GetLength(0));
Console.WriteLine("the B maatrix is:");
int [,] B=GetMtx();
ShowMtx(B);
Console.WriteLine("after multiplicaton: ");
int [,] C=MatrixMultiplication(A,B);
ShowMtx(C);