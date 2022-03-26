#include<iostream>
using namespace std;

    //prosedur => tidak memiliki nilai kembalian
void siswa(){
    string nama = "sihab";
    string jk_l = "laki-laki";
    cout<<nama<< " adalah seorang " << jk_l<< endl;
}

    //fungsi => memiliki nilai kembalian
string siswi(){
    string nama = "dea";
    string jkl = "perempuan";
    return (nama + " adalah seorang "+ jkl);
}

int main(){
    siswa(); //penulisan prosedur
    cout<<siswi()<<endl; // penulisan fungsi
    
}