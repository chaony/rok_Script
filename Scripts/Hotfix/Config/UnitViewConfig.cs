using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class UnitViewDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 视野范围
        /// </summary>
        public int viewRange;

    }
}