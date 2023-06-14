int [,,]Get3DMtx(){
    int [,,]mtx=new int [4,4,4];
    int n=10;
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=0;j<mtx.GetLength(1);j++){
            for (int k=0;k<mtx.GetLength(2);k++){
                mtx[i,j,k]=n;
                n++;
            }
        }
    }
    return mtx;
}

void ShowMtx(int [,,]mtx){
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=0;j<mtx.GetLength(1);j++){
            for (int k=0;k<mtx.GetLength(2);k++){
            Console.Write($"{mtx[i,j,k]}({i},{j},{k})\t");
            }
        Console.WriteLine();
        }
    }
}
int [,,]mtx=Get3DMtx();
ShowMtx(mtx);