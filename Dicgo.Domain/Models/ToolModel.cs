using Dicgo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicgo.Domain.Models
{
    public class ToolModel : BaseModel
    {
        private bool isSelected;

        /// <summary>
        /// 工具名称
        /// </summary>
        public string ToolName { get; set; } = "";
        /// <summary>
        /// 工具类型
        /// </summary>
        public string ToolType { get; set; }
        public string ClassificationType { get; set; }
        public Type? ViewType { get; set; }
        public Type? ViewModelType { get; set; }
        public string Icon { get; set; } = "";
        public int SortId { get; set; }
        public bool IsVisible { get; set; }
        public string? Color { get; set; }

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                RaiseOnPropertyChanged();
            }
        }
    }
}
