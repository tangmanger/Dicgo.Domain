using Dicgo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicgo.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ToolAttribute : Attribute
    {
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
        /// <summary>
        /// 工具
        /// </summary>
        /// <param name="toolName">工具名称</param>
        /// <param name="toolType">工具类型</param>
        /// <param name="classificationType">工具分类</param>
        /// <param name="viewType">View</param>
        /// <param name="viewModelType">ViewModel</param>
        /// <param name="icon">图标</param>
        /// <param name="sortId">排序（升序 默认0）</param>
        /// <param name="isVisible">是否可见（默认true）</param>
        public ToolAttribute(string toolName, string toolType, string classificationType, Type? viewType, Type? viewModelType, string icon, int sortId = 0, bool isVisible = true)
        {
            ToolName = toolName;
            ToolType = toolType;
            ClassificationType = classificationType;
            ViewType = viewType;
            ViewModelType = viewModelType;
            Icon = icon;
            SortId = sortId;
            IsVisible = isVisible;
        }
    }

}
