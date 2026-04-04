using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HelpTipsDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 模板语言包
        /// </summary>
        public int l_typeID;

        /// <summary> 
        /// tips底图宽度
        /// </summary>
        public int width;

        /// <summary> 
        /// 参数{0}语言包
        /// </summary>
        public int l_data1;

        /// <summary> 
        /// 参数{1}语言包
        /// </summary>
        public int l_data2;

        /// <summary> 
        /// 参数{2}语言包
        /// </summary>
        public int l_data3;

        /// <summary> 
        /// 参数{3}语言包
        /// </summary>
        public int l_data4;

        /// <summary> 
        /// 参数{4}语言包
        /// </summary>
        public int l_data5;

    }
}