using System;

namespace DesignPatterns_InterfaceSegregationPrinciple
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        void CheckIn();
        void CheckOut(string Borrower);
        DateTime GetDueDate();

    }
}
