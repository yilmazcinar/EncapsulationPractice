using EncapsulationOOPProject;

Car newCar1 = new Car()
{
    Marka = "Tofaş",
    Model = 1992,
    Renk = "Sarı",
    KapıSayisi = 4


};





Console.WriteLine($"Arabanın Markası : {newCar1.Marka}\n\nModeli : {newCar1.Model}\n\nRengi : {newCar1.Renk}\n\nKapı Sayısı : {newCar1.KapıSayisi}");

Console.WriteLine("--------------------------------------------------------------");

Car newCar2 = new Car()
{
    Marka = "Ferrari",
    Model = 2024,
    Renk = "Kırmızı",
    KapıSayisi = 7 


};



Console.WriteLine($"Arabanın Markası : {newCar2.Marka}\n\nModeli : {newCar2.Model}\n\nRengi : {newCar2.Renk}\n\nKapı Sayısı : {newCar2.KapıSayisi}");