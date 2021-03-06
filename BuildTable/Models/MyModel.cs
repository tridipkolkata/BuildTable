﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildTable.Models
{

    public class MainViewModel
    {
        public List<Student> Students { get; set; }
        public int SelectedState { get; set; }
        public int SelectedCity { get; set; }
    }

    public class Student
    {
        [Required(ErrorMessage = "ID Required")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Required (ErrorMessage = "State Required")]
        public int StateID { get; set; }
        [Required(ErrorMessage = "City Required")]
        public int CityID { get; set; }
        public List<States> States { get; set; }
        public List<Cities> Cities { get; set; }
    }

    public class States
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Cities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StateID { get; set; }
    }
}