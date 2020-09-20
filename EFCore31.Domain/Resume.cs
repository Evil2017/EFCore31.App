using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCore31.Domain
{
    public class Resume
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        [DisplayName("描述内容")]
        public string Description { get; set; }
        [Display(Prompt = "输入队员ID", Name = "队员ID")]
        public int PlayerId { get; set; }
        [Display(Prompt = "输入队员", Name = "队员")]
        public Player Player { get; set; }
    }
}
