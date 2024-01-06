# Master1
Burada bir açıklama gerçekleşmektedir.
## Bu Yeni Bir Başlık
Aşağıdaki komut satırı klasör içerisindeki dosya ve dizinleri gösterir.
```
ls -al
```
<<<<<<< HEAD

Jira üzerinden gelen bir görevin commiti aşağıdaki şekilde belirtilerek atılmalıdır.
```
git commit -m "[issueId service:Jira] fileName created"
```
=======
>>>>>>> 9e3e8bafcd89d0065ae98f264ee1b2ba1169fcc8
Aşağıdaki komut satırı commit atmadan commit içeriğini değiştirmeye yarar.

```git
git add index.md
git commit --amend
```
Ya da hem ekleyip mesaj değişmesini istersek aşağıdaki komut satırını yazarız.
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
Bir branchi silmek için aşağıdaki komut satırını yazarız.Geçiş yapılan branche geçiş yapılır sonra silinir.
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
Tüm projenin main/master branchi üzerinde olabilmesi için diğer branchlerin merge edilmesi yani birleştirilmesi gerekmektedir.Bunun için aşağıdaki komut satırı yazılır.Böylelikle tüm (hem header hem de main) commitleride getirir.Header branch olarak 30 commit varsa onlarıda getirir.Historyler gelir.

```
git merge mainIleBirlesecekBranchIsmi
```
Branchler merge edilince bir commit fırsatı sunulması aşağıdaki komut satırı yazılır. Sadece bir genel bir commit istenildiği zaman **--squash** ile yazılır. Diğer footer branchına ait commitler gelmez
```
git merge --squash mainIleBirlesecekBranchIsmi
git commit -m "mainIleBirlesecekBranchIsmi isimli branch ile birleştirildi"
```
Bir diğer birleştirme yöntemi ise rebasedir.Bu birleştirme yönteminde commitleri main/master branchin sonuna ekler.Mergete ise tarihe göre ekler. 
```
git checkout ana-dal
git rebase feature-dal
```
Eğer merge veya rebase yaparken mesela main dalında ve diğer dalda (header vb) aynı dosya üzerinde çalışılabilir.Bu durumda hata alınırsa aşağıdaki komut satırı ile işlemler geri alınabilir.Yahut isteğinize göre kabul gören değişikliği seçebilirsiniz.
```
git merge --abort
```
**Not:** Branch push yapıldıysa merge yoksa rebase kullanılmalı.
## Notlar

* Commit listesini nasıl görürüz? git log
* 2 commit arasındaki farkları nasıl görürüz? Nasıl yorumlarız? git diff eskiCommitId..yeniCommidID dosyaAdi
* Yaptığımız bir commit işlemini nasıl geri alabiliriz? git revert commitID
* Yaptığımız bir commit işlemini nasıl silebiliriz? git reset --hard commitID
* Yaptığımız bir commit işlemini nasıl değiştirebiliriz? git add . git commit --amend
* Yaptığımız bir commit işleminin mesajını nasıl değiştirebiliriz? git commit --amend -m "Yeni Commit Mesajı" 