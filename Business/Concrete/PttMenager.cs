﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class PttMenager : ISupplierService
    {
        public IApplicantService _applicantService;
        
        public PttMenager(IApplicantService applicantService) //Constructor metod.
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske talebi oluşturuldu.");
            }
        }

    }
}
