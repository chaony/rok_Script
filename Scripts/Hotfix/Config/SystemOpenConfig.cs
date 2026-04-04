using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SystemOpenDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 主城等级开启
        /// </summary>
        public int openLv;

        /// <summary> 
        /// 主线任务开启
        /// </summary>
        public int openTask;

        /// <summary> 
        /// 国家成就开启
        /// </summary>
        public int openSuccess;

        /// <summary> 
        /// 主城等级未达开启条件提示语
        /// </summary>
        public int l_promptID;

    }
}