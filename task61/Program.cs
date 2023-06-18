int [,]GetMtx(int n){
    if(n%2==0)n+=1;
    int [,]mtx=new int [n,n*2+2];
  
    return mtx;
}

void ShowMtx(int [,]mtx){
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=0;j<mtx.GetLength(1);j++){
            if(mtx[i,j]==0)Console.Write(" \t");
            else Console.Write($"{mtx[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void PascalTriangle(int n){
    int [,]mtx=GetMtx(n);
    int start=n;
    int end=start+1;
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=start;j<end;j++){
            if(mtx[i,start]==0){
                mtx[i,j]=1;
                }
            else{
                mtx[i,j]=mtx[i-1,j+1]+mtx[i-1,j-1];
            }
        }
        start--;
        end++;
    }
    ShowMtx(mtx);

}

Console.Clear();
Console.Write("insert the number of Pascal triangle: ");
int n=int.Parse(Console.ReadLine()!);
PascalTriangle(n);
