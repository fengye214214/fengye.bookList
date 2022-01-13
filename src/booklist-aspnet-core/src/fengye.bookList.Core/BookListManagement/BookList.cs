using Abp.Domain.Entities.Auditing;

namespace fengye.bookList.BookListManagement
{
    /// <summary>
    /// 书单
    /// </summary>
    public class BookList : CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Intro { get; set; }
    }
}
