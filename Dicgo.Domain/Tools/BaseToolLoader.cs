using Dicgo.Domain.Attributes;
using Dicgo.Domain.Enums;
using Dicgo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicgo.Domain.Tools
{
    public abstract class BaseToolLoader
    {
        protected BaseToolLoader()
        {
            Init();
        }
        /// <summary>
        /// 工具
        /// </summary>
        public List<ToolModel> Tools { get; private set; } = new List<ToolModel>();
        /// <summary>
        /// 获取类型
        /// </summary>
        /// <returns></returns>
        public abstract Type[] GetTypes();
        /// <summary>
        /// 颜色字典
        /// </summary>
        public abstract Dictionary<string, string> ColorDic { get; }
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual string GetLangText(string name)
        {
            return name;
        }
        private void Init()
        {
            Tools.Clear();
            var types = GetTypes();
            foreach (var item in types)
            {
                var toolAttribute =
               (ToolAttribute)Attribute.GetCustomAttribute(item, typeof(ToolAttribute));

                ToolModel toolModel = new ToolModel();
                toolModel.Icon = toolAttribute.Icon;
                toolModel.SortId = toolAttribute.SortId;
                toolModel.ToolName = GetLangText(toolAttribute.ToolName);
                toolModel.IsVisible = toolAttribute.IsVisible;
                toolModel.ClassificationType = toolAttribute.ClassificationType;
                toolModel.ViewType = toolAttribute.ViewType;
                toolModel.ToolType = toolAttribute.ToolType;
                toolModel.ViewModelType = toolAttribute.ViewModelType;
                if (ColorDic != null && ColorDic.ContainsKey(toolAttribute.ToolType))
                {
                    toolModel.Color = ColorDic[toolAttribute.ToolType];
                }
                Tools.Add(toolModel);

            }
        }
    }
}
