using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattleMailDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 战斗胜利：单人->单目标
        /// </summary>
        public int victoryMailID1;

        /// <summary> 
        /// 战斗胜利：单人->多目标
        /// </summary>
        public int victoryMailID2;

        /// <summary> 
        /// 战斗胜利：集结队长->单目标
        /// </summary>
        public int victoryMailID3;

        /// <summary> 
        /// 战斗胜利：集结队长->多目标
        /// </summary>
        public int victoryMailID4;

        /// <summary> 
        /// 战斗胜利：集结队员->单目标
        /// </summary>
        public int victoryMailID5;

        /// <summary> 
        /// 战斗胜利：集结队员->多目标
        /// </summary>
        public int victoryMailID6;

        /// <summary> 
        /// 战斗胜利：防守队长->单目标
        /// </summary>
        public int victoryMailID7;

        /// <summary> 
        /// 战斗胜利：防守队长->多目标
        /// </summary>
        public int victoryMailID8;

        /// <summary> 
        /// 战斗胜利：防守队员->单目标
        /// </summary>
        public int victoryMailID9;

        /// <summary> 
        /// 战斗胜利：防守队员->多目标
        /// </summary>
        public int victoryMailID10;

        /// <summary> 
        /// 战斗失败：单人->单目标
        /// </summary>
        public int failMailID1;

        /// <summary> 
        /// 战斗失败：单人->多目标
        /// </summary>
        public int failMailID2;

        /// <summary> 
        /// 战斗失败：队长->单目标
        /// </summary>
        public int failMailID3;

        /// <summary> 
        /// 战斗失败：队长->多目标
        /// </summary>
        public int failMailID4;

        /// <summary> 
        /// 战斗失败：队员->单目标
        /// </summary>
        public int failMailID5;

        /// <summary> 
        /// 战斗失败：队员->多目标
        /// </summary>
        public int failMailID6;

        /// <summary> 
        /// 战斗失败：防守队长->单目标
        /// </summary>
        public int failMailID7;

        /// <summary> 
        /// 战斗失败：防守队长->多目标
        /// </summary>
        public int failMailID8;

        /// <summary> 
        /// 战斗失败：防守队员->单目标
        /// </summary>
        public int failMailID9;

        /// <summary> 
        /// 战斗失败：防守队员->多目标
        /// </summary>
        public int failMailID10;

        /// <summary> 
        /// 战斗无结果：单人->单目标
        /// </summary>
        public int noResultMailID1;

        /// <summary> 
        /// 战斗无结果：单人->多目标
        /// </summary>
        public int noResultMailID2;

        /// <summary> 
        /// 战斗无结果：队长->单目标
        /// </summary>
        public int noResultMailID3;

        /// <summary> 
        /// 战斗无结果：队长->多目标
        /// </summary>
        public int noResultMailID4;

        /// <summary> 
        /// 战斗无结果：队员->单目标
        /// </summary>
        public int noResultMailID5;

        /// <summary> 
        /// 战斗无结果：队员->多目标
        /// </summary>
        public int noResultMailID6;

        /// <summary> 
        /// 战斗无结果：防守队长->单目标
        /// </summary>
        public int noResultMailID7;

        /// <summary> 
        /// 战斗无结果：防守队长->多目标
        /// </summary>
        public int noResultMailID8;

        /// <summary> 
        /// 战斗无结果：防守队员->单目标
        /// </summary>
        public int noResultMailID9;

        /// <summary> 
        /// 战斗无结果：防守队员->多目标
        /// </summary>
        public int noResultMailID10;

    }
}