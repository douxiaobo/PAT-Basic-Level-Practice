#include <stdio.h>
int main()
{
    int step=0,n;
    (void)scanf("%d",&n);
    while(n!=1)
    {
        if(n%2==1)
            n=3*n+1;
        else
        {
            n=n/2;
            step++;
        }
    }
    printf("%d\n",step);
    return 0;
}