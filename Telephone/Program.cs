using Telephone;

List<Contact> contacts = new();

string optionStr;



do
{

    Console.WriteLine("1 - Yeni numara kaydetmek");
    Console.WriteLine("2- Varolan numarayi silmek");
    Console.WriteLine("3-Varolan numarayi guncellemek");
    Console.WriteLine("4- Rehberi listelemek");
    Console.WriteLine("5- Rehberde arama yapmak");
    Console.WriteLine("Select one option:");
    optionStr = Console.ReadLine();
    


    int option;
    bool optionFormat = int.TryParse(optionStr, out option);

    switch (option)
    {
        case 1:
            Console.WriteLine("Lütfen isim giriniz:");
        Name: string name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine("Cannot be empty!");
                goto Name;
            }

            Console.WriteLine("Lütfen soyisim giriniz:");
        Surname: string surname = Console.ReadLine();

            if (surname == null)
            {
                Console.WriteLine("Cannot be empty!");
                goto Surname;
            }

            Console.WriteLine("Lütfen telefon numarası giriniz:");
        Number: string telephoneNumber = Console.ReadLine();

            if (!telephoneNumber.StartsWith("+994"))

            {
                Console.WriteLine("Please start with country code");
                goto Number;


            }

            Contact contact1 = new()
            {
                Name = name,
                Surname = surname,
                TelephoneNumber = telephoneNumber
            };

            contacts.Add(contact1);
            break;
        case 2:

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        Option2: string input = Console.ReadLine();

            foreach (var item in contacts)
            {
                if (item.Name == input && item.Surname == input)
                {
                    Console.WriteLine(input + "isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?");
                    contacts.Remove(item);
                }
                if (item.Name != input && item.Surname != input)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" 1 - Silmeyi sonlandir");
                    Console.WriteLine("2- Yeniden dene");
                    string removeOptions = Console.ReadLine();
                    switch (removeOptions)
                    {
                        case "1":
                            break;
                        case "2":
                            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                            goto Option2;
                            break;
                    }



                }
            }
                break;

                case 4:

                    foreach (var item in contacts)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.TelephoneNumber);
            }
            

                    break;
        case 5:
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: 1");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: 2");

            string searchOptions = Console.ReadLine();

            switch (searchOptions)
            {
                case "1":
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    Text:  string searchText = Console.ReadLine();

                    foreach(var item in contacts)
                    {
                        if(item.Name == searchText && item.Surname == searchText)
                        {
                            Console.WriteLine(item.Name + item.Surname + item.TelephoneNumber);

                        } else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Bir daha deneyin");
                            goto Text;
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                   PhoneText: string telephoneText = Console.ReadLine();

                    foreach(var item in contacts)
                    {
                        if (item.TelephoneNumber == telephoneText)
                        {
                            Console.WriteLine(item.Name + item.Surname + item.TelephoneNumber);

                        }
                        else
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Bir daha deneyin");
                            goto PhoneText;
                        }
                    }
                    break;
            }

            break;

            

        default:
        
            Console.WriteLine("Please select the right option!");
            break;


    }

}
while (optionStr != null);
