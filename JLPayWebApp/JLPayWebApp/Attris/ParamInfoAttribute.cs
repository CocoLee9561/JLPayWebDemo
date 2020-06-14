using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Attris
{
    /// <summary>
    /// 参数信息
    /// </summary>
    public class ParamInfoAttribute : System.Attribute
    {
        private string name;
        private string inputType;
        private string description;
        private bool isRequired = false;

        public ParamInfoAttribute(string _name, string _inputType, string _des)
        {
            this.name = _name;
            this.inputType = _inputType;
            this.description = _des;
        }

        /// <summary>
        /// 参数名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// 参数类型
        /// </summary>
        public string InputType
        {
            get
            {
                return inputType;
            }
        }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// 是否必传
        /// </summary>
        public bool Required
        {
            get
            {
                return isRequired;
            }
            set
            {
                isRequired = value;
            }
        }

        /// <summary>
        /// 字符串长度
        /// </summary>
        public int stringLength
        {
            get;
            set;
        }
    }
}
