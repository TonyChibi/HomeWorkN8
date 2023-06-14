Console.Clear();

int [,] GetSpiralMtx(){
    int [,] mtx= new int [4,4];
    int i=0;
    int j=0;
    int n=1;
    while(n<=mtx.GetLength(0)*mtx.GetLength(1)){
        if(i<mtx.GetLength(0)&&mtx[j,i]==0){
            while(i<mtx.GetLength(0)&&mtx[j,i]==0){
            mtx[j,i]=n;
            n++;
            i++;
            }
          
        }
        i--;
        j++;
        if(j<mtx.GetLength(1)&&mtx[j,i]==0){
            while(j<mtx.GetLength(1)&&mtx[j,i]==0){
            mtx[j,i]=n;
            n++;
            j++;
            }
      
        }
        j--;
        i--;
        if(i>=0&&mtx[j,i]==0){
            while(i>=0 && mtx[j,i]==0){
            mtx[j,i]=n;
            n++;
            i--;
            }

        }
        i++;
        j--;
        if(j>=0&&mtx[j,i]==0){
            while(j>=0 && mtx [j,i]==0){
            mtx[j,i]=n;
            n++;
            j--;
            }

        }
        j++;
        i++;

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

int [,]mtx=GetSpiralMtx();

ShowMtx(mtx);