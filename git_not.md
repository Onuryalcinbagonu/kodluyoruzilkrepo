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

Yanlış bir commit atılması durumunda geri alınması için aşağıdaki komut yazılır ve yeni bir commit olarak ekler.

``` 
git log -n 2
git revert commitID
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

## Notlar

* Commit listesini nasıl görürüz? git log
* 2 commit arasındaki farkları nasıl görürüz? Nasıl yorumlarız? git diff eskiCommitId..yeniCommidID dosyaAdi
* Yaptığımız bir commit işlemini nasıl geri alabiliriz? git revert commitID
* Yaptığımız bir commit işlemini nasıl silebiliriz? git reset --hard commitID
* Yaptığımız bir commit işlemini nasıl değiştirebiliriz? git add . git commit --amend
* Yaptığımız bir commit işleminin mesajını nasıl değiştirebiliriz? git commit --amend -m "Yeni Commit Mesajı" 