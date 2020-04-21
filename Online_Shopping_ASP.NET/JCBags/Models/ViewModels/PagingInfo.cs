/*
//  Student Name: Jabin Choi
//  Student ID: 300974443
//  Sec: 008
//  Date: 28th Nov, 2018
//  Title: Assignment 04
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBags.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages =>
        (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
