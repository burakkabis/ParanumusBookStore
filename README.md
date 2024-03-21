### <p id="description">BookStore projesinin temel hali bu projedir.Daha gelismis ve surdurulebilir versiyonu uzerinde calismaktayim.Gelismis projeyi incelemek icin githubimda bulunan BOOKSTROEPROFESSIONAL repositorye bakabilirsiniz.</p>


### <p id="description">Bu projeden bahsedecek olursam;</p>

<p id="description">Entities katmaninda BookPurchaseRequest ve PurchaseResponse nesnelerini olusturdum.</p>



<p id="description">Musteri tiplerini ise Enum yapisini kullanarak icerisinde PremiumRegular ve Employee musterilerini tanimladim.</p>


<p id="description">Business katmaninda ise BookStoreManager is sinifini olusturup bu sinifin icersinde HandlePurchase() ve CalculateDiscount() methodlarini tanimladim.</p>


<p id="description">CalculateDiscount() metodu customerType ve totalAmount parametrelerini alarak indirimi belirliyor.</p>



<p id="description">HandlePurchase() metodu ise PurchaseRequest nesnesini parametre olarak alip OriginalPrice, DiscountedAmount ve FinalPrice i geri donduruyor.</p>

### <p id="description">Program.cs de ise;</p>



<p id="description">Book classi turunden 2 tane book nesnesi olusturup bir books listesine ekliyorum.Daha sonra PurchaseRequest nesnesi olusturup , customerType, books ve totalAmount degerlerini veriyorum.</p>





<p id="description">Son olarak BookStoreManager nesnesini olusturup icerisinde bulunan HandlePurchase metoduna, olusturmus oldugum purchaseRequest parametetresini verip, PurchaseResponse turunden response degerine atip, ConsoleWriteline metodu ile response icerisinde bulunan OriginalPrice,DiscountedAmount ve FinalPrice'i ekrana yazdiriyorum.</p>




!(![1](https://github.com/burakkabis/ParanumusBookStore/assets/134310460/e511eab8-5c49-49a4-8c9e-4cc4a23e9916)
)


!(![2](https://github.com/burakkabis/ParanumusBookStore/assets/134310460/e0ee0635-6c44-42ce-a3f2-ff3468443aff)
)


!(![3](https://github.com/burakkabis/ParanumusBookStore/assets/134310460/861a80fd-86e3-43b6-b0e2-be983d1e0bb2)
)



