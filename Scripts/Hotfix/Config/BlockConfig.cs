using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BlockDefine
    {
        /// <summary> 
        /// 关键字
        /// </summary>
        [PrimaryKey] [AutoIncrement] public string ID  { get; set; }

    }
}