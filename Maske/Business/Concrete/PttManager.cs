using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person))
            {
                TimeSpan tarihFark = DateTime.Now - person.dateTime;
                if (tarihFark.Days>=7)
                {
                 _applicantService.ApplyForMask(person);
                   
                }
                else
                {
                    Console.WriteLine("7 gün içinde tekrar sipariş veremezsiniz!");
                    Console.WriteLine($"Bekleme Süreniz: {tarihFark.Days} gün!");
                }
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ!\n\nGeçersiz Kullanıcı Bilgileri! ");
            }
        }
    }
}
