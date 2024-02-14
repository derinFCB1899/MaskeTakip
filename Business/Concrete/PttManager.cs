using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager: ISupplierService // İleriki talepleri de tahmin etmek önemli
    {
        private IApplicantService _applicantService; // Arayüzler, referans tutucu olarak kullanılır (Mikroservise giriş)

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
        {
            _applicantService = applicantService; // "_" kullanımının sebebi
        }
        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
        }
    }
}
