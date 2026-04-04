using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HyperlinkDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 备注
        /// </summary>
        public string comment;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_comment;

        /// <summary> 
        /// 中文
        /// </summary>
        public string cn;

        /// <summary> 
        /// 英语
        /// </summary>
        public string en;

        /// <summary> 
        /// 阿语
        /// </summary>
        public string arabic;

        /// <summary> 
        /// 土耳其语
        /// </summary>
        public string tr;

        /// <summary> 
        /// 俄语
        /// </summary>
        public string ru;

    }
}