// index.html içinden çalıştırılacak dosya değiştirilebilir!

// Type Safe Değil!

//var sayi1 = 10
//sayi1 = "Emir Baş"
//console.log(sayi1);


// let kullanarak type safe bir güvenlik sağlanır!
let sayi2 = 10
sayi2 = "İrem Oruç"

console.log(sayi2)

// Ekrana Objeyi getirme!
let sayi3 = 10
sayi3 = "İrem Oruç"
let student = {id:1, name:"İrem"}
console.log(student)


// Fonksiyon Tanımlama
// Save fonskiyonu içinde istediğimizi verebiliyoruz bu bir güvenlik açğıdır!
// puan = 10 fonskiyonumuzdaki default değeri gösterir!

function save1(ogrenci, puan = 10) {
    console.log("1. save fonksiyonu çalıştı!");
    console.log(ogrenci.name + ": "+ puan);
}
save1(student, 100)

//  Default değer fonksiyonda 1. sıradaysa undefined olarak tanımlanabilir!
function save2(puan = 10, ogrenci) {
    console.log("2. save fonksiyonu çalıştı!");
    console.log(ogrenci.name + ": "+ puan);
}
save2(undefined,student)


// Array

let students1 = ["İrem", "Emir", "Fahri", "Nezahat"]

console.log(students1);

student = {id:1, name:"Emir"}
let students2 = [student, {id:2, name:"İrem"}, "Tekirdağ",{city:"İstanbul"}]

console.log(students2);


// Functions

let showProducts = function (id,...products) {
    console.log(id);
    console.log(products[0]);
}

// Bu şekilde gönderirsek id undifended array ise boş olarak döner!
showProducts()

showProducts(10, ["Elma","Armut", "Karpuz"])


// Spread- Ayırmak anlamına gelir ve 3 nokta ile çaprılır!

let points = [1,23,94,4,56,64,1312,45,12]
console.log(...points);
console.log(Math.max(...points))

console.log("ABC", "D",..."EFG", "H");

// Destructuring
// Elimizdeki arrayin değerlerini değişkenlere atama yöntemi

let populations = [10000 , 20000 , 30000[40000 , 500000]]
let [small,medium,high[veryHigh, maximum]] = populations // sırasıyla
console.log(small)
console.log(medium)
console.log(high)

function someFunction([small], number){

        console.log(small)
}
someFunction(population)

let category = {id = 1, name: "içeçek"}
console.log(category.id)
console.log(category["name"])

let {id,name} = category
console.log(id)
console.log(name)

//Redux'e bak

