int [,]GetMtx(){
    int [,]mtx=new int [new Random().Next(3,8),new Random().Next(3,8)];
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
void BrushMtx(int [,]mtx){
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=1;j<mtx.GetLength(1);j++){
            if(mtx[i,j]<mtx[i,j-1]){
                int less=mtx[i,j];
                mtx[i,j]=mtx[i,j-1];
                mtx[i,j-1]=less;
                for (int k=j-1;k>0;k--){
                    if(mtx[i,k]<mtx[i,k-1]){
                        int min=mtx[i,k];
                        mtx[i,k]=mtx[i,k-1];
                        mtx[i,k-1]=min;
                    }
                }
            }
        }
    }
}


int [,]mtx=GetMtx();
ShowMtx(mtx);
Console.WriteLine("now matrix look like:");
BrushMtx(mtx);
ShowMtx(mtx);