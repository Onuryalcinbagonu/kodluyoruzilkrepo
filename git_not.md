# Master1
Burada bir açıklama gerçekleşmektedir.
## Bu Yeni Bir Başlık

```
ls -al
```
Klasör içerisindeki dosya ve dizinleri gösterir.

```git
git add index.md
git commit --amend
```
ya da hem ekleyip mesaj değişmesini istemezsek
```git
git add index.md
git commit --amend "Yeni Commit Mesajı" 
```

* En son atılmış olan commiti düzenlemeyi sağlar. En son commiti değiştirmek
* Yeni dosyalar eklemek
* Commit mesajını düzeltmek gibi bir çok işlem yapılabilir.

Yanlış bir commit atılması durumunda geri alınması için aşağıdaki komut yazılır ve yeni bir commit olarak ekler. (en son atılmış commit olmalı revert)

``` 
git log -n 2
git revert commitID
```
-n ile istenilen commite dönülür 
``` 
git log -n 2
git revert -n commitID
```

Eğer istediğimiz commite dönmek istersek aşağıdaki komut satırı yazılır. Ancak branch ile ilişkisi olmaz.

```
git checkout commitID
```

Şuanki committen bir başka commit aralığına kadar silmek istersek aşağıdaki komut satırını yazarız . Fakat tehlikeli olabilir!

```
git reset --hard gitmekistenen_CommitID 
```
İki commit arasındaki farklılıkları görmek için aşağıdaki komut satırını yazarız.

```
git diff eskiCommitID..yeniCommitID dosyaAdi
git diff cf48a76c58ff74a..cf48a76c58ff74a6a5ad2 index.md
```
Hangi branchte olduğumuzu aşağıdaki komut satırlıyla öğreniriz.
```
git branch
```
Yeni bir branch açmak için aşağıdaki komut satırını yazarız.
```
git branch header
```
Branche geçiş yapmak için
```
git checkout branchName
```
Hem branch oluşturmak ve o branche geçiş yapmak için aşağıdaki komut satırı yazılır.
```
git checkout -b branchName
```
Bir branchi silmek için aşağıdaki komut satırını yazarız.Herhangi bir mastera geçiş yapılır sonra silinir.
```
git checkout gecisyapilacakBranch
git branch -D silinecekBranch
```
Son commiteki değişikler gönderilmesi istendi.Bir kod yazıldı ve bu kodda yanlışlar olduğunu sonradan farkına vardınız. Fakat yeni yeni kodlarda yazılmış oldu. Bu durumda aşağıdaki komut satırı yazılır. Bu durumda son committen itibaren yazılan tüm kodlar stash üzerinde saklanır ve son atılan commite dönülür. Burası geçicidir.
```
git stash
```
Stashleri listelemek için aşağıdaki komut satırı yazılır
``` 
git stash list
```
Stashleri silmek için aşağıdaki komut satırı yazılır.
```
git stash clear
```
Son committen sonra yazdığımız kodların ilk stashi getirmek için aşağıdaki komut satırı yazılır. Bu stashi de listeden siler.
```
git stash pop
```
Listedeki stashlerden birini getirmek için aşağıdaki komut satırı yazılır ve listeden silinmez.

```
git stash apply stashID
```
Stash listesini temizlemek için aşağıdaki komut satırı yazılır.

```
git stash clear
```
## Notlar

* Commit listesini nasıl görürüz? git log
* 2 commit arasındaki farkları nasıl görürüz? Nasıl yorumlarız? git diff eskiCommitId..yeniCommidID dosyaAdi
* Yaptığımız bir commit işlemini nasıl geri alabiliriz? git revert commitID
* Yaptığımız bir commit işlemini nasıl silebiliriz? git reset --hard commitID
* Yaptığımız bir commit işlemini nasıl değiştirebiliriz? git add . git commit --amend
* Yaptığımız bir commit işleminin mesajını nasıl değiştirebiliriz? git commit --amend -m "Yeni Commit Mesajı" 