using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class JumpTypeDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 参数1
        /// </summary>
        public int typeData1;

        /// <summary> 
        /// 参数2
        /// </summary>
        public int typeData2;

    }
}