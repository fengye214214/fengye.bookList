using Abp.Domain.Entities.Auditing;

namespace fengye.bookList.BookListManagement
{
    /// <summary>
    /// 书籍标签
    /// </summary>
    public class BookTags : CreationAuditedEntity<long>
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { get; set; }
    }
}
