using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> phoneCatalog = new Dictionary<string, Dictionary<string, List<string>>>();
            Dictionary<string, List<string>> listOfNumbersForPerson = new Dictionary<string, List<string>>();

            List<string> listOfNumbers1 = new List<string>() { "112233", "445566", "778899" };
            List<string> listOfNumbers2 = new List<string>() { "123456", "678912", "345678" };

            listOfNumbersForPerson.Add("Ivanov Ivan Ivanovich", listOfNumbers1);
            listOfNumbersForPerson.Add("Ignatov Vladislav Vsevolodovich", listOfNumbers2);
            listOfNumbersForPerson.Add("Slepakov Stepan Petrovich", listOfNumbers2);

            phoneCatalog.Add("I", listOfNumbersForPerson);
            phoneCatalog.Add("S", listOfNumbersForPerson);

            ShowContactsAndNumbersForOneLetter(phoneCatalog);
            ShowAllNumberByFIO(listOfNumbersForPerson);
            FindContactByNumber(listOfNumbersForPerson);

            Console.ReadKey();
        }

        static void ShowContactsAndNumbersForOneLetter(Dictionary<string, Dictionary<string, List<string>>> phoneCatalog)
        {
            Console.WriteLine("На какую букву показать контакты и номера? Возможные варианты:");

            foreach (var key in phoneCatalog.Keys)
            {
                Console.WriteLine(key + ",");
            }

            string keyOfPhoneCatalog;
            Dictionary<string, List<string>> listFIOAndContacts;

            try
            {
                keyOfPhoneCatalog = Console.ReadLine();
                listFIOAndContacts = phoneCatalog[keyOfPhoneCatalog];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Справочник не содержит контактов на данную букву. Повторите попытку еще раз");
                keyOfPhoneCatalog = Console.ReadLine();
                listFIOAndContacts = phoneCatalog[keyOfPhoneCatalog];
            }

            foreach (var keyFIO in listFIOAndContacts.Keys)
            {
                if (keyFIO[0].ToString() == keyOfPhoneCatalog)
                {
                    Console.WriteLine(keyFIO[0]);
                    var listNumbers = listFIOAndContacts[keyFIO];
                    Console.WriteLine(keyFIO);

                    foreach (var val in listNumbers)
                    {
                        Console.WriteLine(val);
                    }
                }
            }
        }

        static List<string> FindContainsInListOfContacts(Dictionary<string, List<string>> listOfNumbersForPerson)
        {
            List<string> listFIOAndContacts = null;
            string fio = Console.ReadLine();

            foreach (var val in listOfNumbersForPerson.Keys)
            {
                if (val.Contains(fio))
                {
                    listFIOAndContacts = listOfNumbersForPerson[val];
                }
            }

            return listFIOAndContacts;
        }

        static void ShowAllNumberByFIO(Dictionary<string, List<string>> listOfNumbersForPerson)
        {
            Console.WriteLine("По какому ФИО показать все контакты?");
            List<string> listFIOAndContacts = null;
            listFIOAndContacts = FindContainsInListOfContacts(listOfNumbersForPerson);

            if (listFIOAndContacts == null)
            {
                Console.WriteLine("Справочник не содержит подобного ФИО. У вас есть еще одна попытка!");
                listFIOAndContacts = FindContainsInListOfContacts(listOfNumbersForPerson);
            }

            foreach (var val in listFIOAndContacts)
            {
                Console.WriteLine(val);
            }
        }

        static void FindContactByNumber(Dictionary<string, List<string>> listOfNumbersForPerson)
        {
            int countFindedNuber = 0;
            Console.WriteLine("По какому номеру найти контакт? Введите 6ти значный номер без пробелов и символов");
            var numberForFinding = Console.ReadLine();

            foreach (var fio in listOfNumbersForPerson.Keys)
            {
                var listOfNumber = listOfNumbersForPerson[fio];

                if (listOfNumber.Contains(numberForFinding))
                {
                    countFindedNuber++;
                    Console.WriteLine($"Найден контакт:{fio}. Его номера:");
                    foreach (var val in listOfNumber)
                    {
                        Console.WriteLine(val);
                    }
                }
            }

            if (countFindedNuber == 0)
            {
                Console.WriteLine("Такого номера нет в справочнике или вы ввели неверный номер");
            }
        }
    }
}
