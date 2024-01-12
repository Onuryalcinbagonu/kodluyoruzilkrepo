# Selection Sort Ödevi

## [22,27,16,2,18,6] -> Insertion Sort

Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.

1. Adım =>  22 | 27 16 2 18 6
2. Adım =>  16 22 | 27 2 18 6
3. Adım =>  16 22 27 | 2 18 6
4. Adım =>  2 16 22 27 | 18 6 
5. Adım =>  2 16 18 22 27 |6
6. Adım =>  2 6 16 18 22 27
 
Burada 4. adımda yer alan 2 sayısının sıralanmasında diğer sayılar olan 27 22 16 ile tekrar büyüklüğüne ve küçüklüğüne bakılarak sıralanır.

# Big-O gösterimini yazınız.
İnsert Sort algoritması en iyi durumda  O(n) en kötü durumdaysa O(n<sup>2</sup>) ile hesaplanır.

Time Complexity: Dizi sıralandıktan sonra 18 sayısı aşağıdaki case'lerden hangisinin kapsamına girer? Yazınız

    Average case: Aradığımız sayının ortada olması 
    Worst case: Aradığımız sayının sonda olması
    Best case: Aradığımız sayının dizinin en başında olması.
18 sayısı average case kapsamına girer.


# [7,3,5,8,2,9,4,15,6] dizisinin Selection Sort'a göre ilk 4 adımını yazınız.

* En küçük eleman hangisi bakılır en başa yazılır.7 2'nin yerine yazılır.

**2 3 5 8 7 9 4 15 6**
Tekrar aynı işlem uygulanarak 2' den sonra en küçük eleman hangisi bakılır yer değiştirilir.Bu sayı 3'tür ve yeri doğrudur sıradaki adıma geçilir.

* Tekrar aynı işlem uygulanarak 5' den sonra en küçük eleman hangisi bakılır 4 ' tür ve yer değiştirilir. Bu şekilde devam eder.

**2 3 4 8 7 9 5 15 6**


