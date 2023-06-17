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

void FindMinSumRow(int [,]mtx){
    int min=100;
    int row=0;
    for(int i=0;i<mtx.GetLength(0);i++){
        int sum=0;
        for(int j=0;j<mtx.GetLength(1);j++){
            sum+=mtx[i,j];
        }
        if (sum<min){
            min=sum;
            row=i;
        }
    }
    Console.Write($"the row with lesser sum of elements is {row}");
}

Console.Clear();
var mtx=GetMtx();
ShowMtx(mtx);
FindMinSumRow(mtx);