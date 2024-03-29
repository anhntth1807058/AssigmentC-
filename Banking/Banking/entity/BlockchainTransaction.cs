namespace Banking.entity
{
    public class BlockchainTransaction
    {
        public string TransactionId { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public  TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public long CreatedAtMLS { get; set; }
        public long UpdatedAtMLS { get; set; }
        public int Status { get; set; }
        public enum TransactionStatus
        {
            COMPLETED = 1,
            DELETED = -1,
            PENDING = 0
        }
        public enum TransactionType
        {
            WITHDRAW = 1,
            DEPOSIT = 2,
            TRANSFER = 3
        }
    }
}