﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRental.Models;

namespace VideoRental.ViewModels
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customer { get; set; }
    }
}