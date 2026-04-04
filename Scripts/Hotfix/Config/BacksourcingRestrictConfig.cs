using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BacksourcingRestrictDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 协议tag
        /// </summary>
        public int agreementTag;

        /// <summary> 
        /// 错误码
        /// </summary>
        public int l_descID;

    }
}