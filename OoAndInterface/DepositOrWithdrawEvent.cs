using System;

namespace OoAndInterface
{
    class DepositOrWithdrawEvent : IEvent
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public bool IsDeposit { get; }

        public DepositOrWithdrawEvent(DateTime date, decimal amount, bool isDeposit)
        {
            Date = date;
            Amount = amount;
            IsDeposit = isDeposit;
        }
    }
}
