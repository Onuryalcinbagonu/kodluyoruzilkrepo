### [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.

Binary search tree algoritmasında en üstteki node olarak root olarak geçer.
Roottan küçük olanlar sol tarafında büyük olanlara ise sağ tarafında bulunur. 

7 bizim Rootumuz olsun. Sağında 5 solunda 8 bulunur. Küçük olan sayı sırayla sol taraflara büyük olan sayılar sırayla sağ tarafa düğüm olarak eklenerek gider.
    
           7
       5       8
      1       6 9
     0   3
        2 4