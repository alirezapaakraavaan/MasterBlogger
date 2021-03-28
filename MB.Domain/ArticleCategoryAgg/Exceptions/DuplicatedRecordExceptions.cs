using System;

namespace MB.Domain.ArticleCategoryAgg.Exceptions
{
    public class DuplicatedRecordExceptions : Exception
    {
        public DuplicatedRecordExceptions()
        {
        }

        public DuplicatedRecordExceptions(string message) : base(message)
        {
        }
    }
}