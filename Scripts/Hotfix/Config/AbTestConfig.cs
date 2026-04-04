using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AbTestDefine
    {
        /// <summary> 
        /// 测试编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int id  { get; set; }

        /// <summary> 
        /// 测试开关（0关闭 1开启）
        /// </summary>
        public int open;

        /// <summary> 
        /// 0 强制关闭1 强制开启 2 保持概率结果，不做强制影响 3 保持原有概率结果，对新增分组用户进行调整）
        /// </summary>
        public int total;

        /// <summary> 
        /// 测试参数
        /// </summary>
        public int parm;

    }
}