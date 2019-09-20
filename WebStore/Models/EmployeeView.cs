﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class EmployeeView
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Дата приема на работу
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
