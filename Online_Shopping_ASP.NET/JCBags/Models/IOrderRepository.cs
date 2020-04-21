/*
//  Student Name: Jabin Choi
//  Student ID: 300974443
//  Sec: 008
//  Date: 28th Nov, 2018
//  Title: Assignment 04
*/

using System.Linq;

namespace JCBags.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
