using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
	public enum allianceAttrType
	{
		None	=	0,//无
		allianceMemberNum	=	1,//allianceMemberNum联盟成员人数上限加值
		allianceDepotMulti	=	2,//allianceDepotMulti联盟仓库的存储容量加成
		allianceBuildingCostMulti	=	3,//allianceBuildingCostMulti建造联盟建筑资源消耗加成
		allianceFlagNum	=	4,//allianceFlagNum联盟旗帜上限加值
		allianceBuildingDurableMulti	=	5,//allianceBuildingDurableMulti联盟建筑耐久度加成
		allianceBuildingSpeedMulti	=	6,//allianceBuildingSpeedMulti联盟建筑建造速度加成
		allianceFlagSpeedMulti	=	7,//allianceFlagSpeedMulti联盟旗帜建造速度加成
	};

	public enum attrType
	{
		None	=	0,//无
		troopsCapacity	=	1,//troopsCapacity部队容量
		massTroopsCapacity	=	2,//massTroopsCapacity集结部队容量
		troopsDispatchNumber	=	3,//troopsDispatchNumber部队派遣队列
		angerMax	=	4,//angerMax怒气值上限
		troopsAnger	=	5,//troopsAnger部队怒气值
		attackAnger	=	6,//attackAnger普攻怒气值
		attackAngerMulti	=	7,//attackAngerMulti普攻怒气百分比
		heroExpMulti	=	8,//heroExpMulti统帅经验值百分比加成
		barbarianDamageMulti	=	9,//barbarianDamageMulti对野蛮人伤害比例
		barbarianVillageDamageMulti	=	10,//barbarianVillageDamageMulti对野蛮人城寨伤害比例
		barbarianAttackDamageMulti	=	11,//barbarianAttackDamageMulti对野蛮人普通攻击伤害比例
		barbarianFightBackDamageMulti	=	12,//barbarianFightBackDamageMulti对野蛮人反击伤害比例
		barbarianAttackDamageReduceMulti	=	13,//barbarianAttackDamageReduceMulti野蛮人普通攻击伤害减免比例
		barbarianFightBackDamageReduceMulti	=	14,//barbarianFightBackDamageReduceMulti野蛮人反击伤害减免比例
		barbarianVillageAttackDamageMulti	=	15,//barbarianVillageAttackDamageMulti对野蛮人城寨普通攻击伤害比例
		barbarianVillageFightBackDamageMulti	=	16,//barbarianVillageFightBackDamageMulti对野蛮人城寨反击伤害比例
		barbarianVillageAttackDamageReduceMulti	=	17,//barbarianVillageAttackDamageReduceMulti野蛮人城寨普通攻击伤害减免比例
		barbarianVillageFightBackDamageReduceMulti	=	18,//barbarianVillageFightBackDamageReduceMulti野蛮人城寨反击伤害减免比例
		barbarianSkillDamageMulti	=	19,//barbarianSkillDamageMulti对野蛮人技能伤害比例
		barbarianSkillDamageReduceMulti	=	20,//barbarianSkillDamageReduceMulti野蛮人技能伤害减免比例
		barbarianVillageSkillDamageMulti	=	21,//barbarianVillageSkillDamageMulti对野蛮人城寨技能伤害比例
		barbarianVillageSkillDamageReduceMulti	=	22,//barbarianVillageSkillDamageReduceMulti野蛮人城寨技能伤害减免比例
		infantryVsCavalryDamageMulti	=	23,//infantryVsCavalryDamageMulti步兵对骑兵伤害比例
		infantryVsSiegeCarDamageMulti	=	24,//infantryVsSiegeCarDamageMulti步兵对攻城器械伤害比例
		infantryVsWarningTowerDamageMulti	=	25,//infantryVsWarningTowerDamageMulti步兵对警戒塔伤害比例
		cavalryVsBowmenDamageMulti	=	26,//cavalryVsBowmenDamageMulti骑兵对弓兵伤害比例
		cavalryVsSiegeCarDamageMulti	=	27,//cavalryVsSiegeCarDamageMulti骑兵对攻城器械伤害比例
		cavalryVsWarningTowerDamageMulti	=	28,//cavalryVsWarningTowerDamageMulti骑兵对警戒塔伤害比例
		bowmenVsInfantryDamageMulti	=	29,//bowmenVsInfantryDamageMulti弓兵对步兵伤害比例
		bowmenVsSiegeCarDamageMulti	=	30,//bowmenVsSiegeCarDamageMulti弓兵对攻城器械伤害比例
		bowmenVsWarningTowerDamageMulti	=	31,//bowmenVsWarningTowerDamageMulti弓兵对警戒塔伤害比例
		siegeCarVsWarningTowerDamageMulti	=	32,//siegeCarVsWarningTowerDamageMulti攻城器械对警戒塔伤害比例
		infantryVsInfantryReduceMulti	=	33,//infantryVsInfantryReduceMulti步兵对步兵减伤比例
		infantryVsCavalryReduceMulti	=	34,//infantryVsCavalryReduceMulti步兵对骑兵减伤比例
		infantryVsBowmenReduceMulti	=	35,//infantryVsBowmenReduceMulti步兵对弓兵减伤比例
		infantryVsSiegeCarReduceMulti	=	36,//infantryVsSiegeCarReduceMulti步兵对攻城器械减伤比例
		infantryVsWarningTowerReduceMulti	=	37,//infantryVsWarningTowerReduceMulti步兵对警戒塔减伤比例
		attackDamageMulti	=	38,//attackDamageMulti普攻伤害百分比
		fightBackDamageMulti	=	39,//fightBackDamageMulti反击伤害百分比
		skillDamageMulti	=	40,//skillDamageMulti技能伤害百分比
		mainHeroSkillDamageMulti	=	41,//mainHeroSkillDamageMulti主将技能伤害百分比
		secondaryHeroSkillDamageMulti	=	42,//secondaryHeroSkillDamageMulti副将技能伤害百分比
		attackDamageReduceMulti	=	43,//attackDamageReduceMulti普攻伤害减免百分比
		fightBackDamageReduceMulti	=	44,//fightBackDamageReduceMulti反击伤害减免百分比
		skillDamageReduceMulti	=	45,//skillDamageReduceMulti技能伤害减免百分比
		cityDefenseAttackDamageMulti	=	46,//cityDefenseAttackDamageMulti攻城防守部队普攻伤害百分比
		cityDefenseFightBackDamageMulti	=	47,//cityDefenseFightBackDamageMulti攻城防守部队反击伤害百分比
		cityDefenseSkillDamageMulti	=	48,//cityDefenseSkillDamageMulti攻城防守部队技能伤害百分比
		cityDefenseAttackDamageReduceMulti	=	49,//cityDefenseAttackDamageReduceMulti攻城防守部队普攻伤害减免百分比
		cityDefenseFightBackDamageReduceMulti	=	50,//cityDefenseFightBackDamageReduceMulti攻城防守部队反击伤害减免百分比
		cityDefenseSkillDamageReduceMulti	=	51,//cityDefenseSkillDamageReduceMulti攻城防守部队技能伤害减免百分比
		cityAttackDamageMulti	=	52,//cityAttackDamageMulti攻城部队普攻伤害百分比
		cityFightBackDamageMulti	=	53,//cityFightBackDamageMulti攻城部队反击伤害百分比
		citySkillDamageMulti	=	54,//citySkillDamageMulti攻城部队技能伤害百分比
		cityAttackDamageReduceMulti	=	55,//cityAttackDamageReduceMulti攻城部队普攻伤害减免百分比
		cityFightBackDamageReduceMulti	=	56,//cityFightBackDamageReduceMulti攻城部队反击伤害减免百分比
		citySkillDamageReduceMulti	=	57,//citySkillDamageReduceMulti攻城部队技能伤害减免百分比
		massAttackDamageMulti	=	58,//massAttackDamageMulti集结部队普攻伤害百分比
		massFightBackDamageMulti	=	59,//massFightBackDamageMulti集结部队反击伤害百分比
		massSkillDamageMulti	=	60,//massSkillDamageMulti集结部队技能伤害百分比
		massAttackDamageReduceMulti	=	61,//massAttackDamageReduceMulti集结部队普攻伤害减免百分比
		massFightBackDamageReduceMulti	=	62,//massFightBackDamageReduceMulti集结部队反击伤害减免百分比
		massSkillDamageReduceMulti	=	63,//massSkillDamageReduceMulti集结部队技能伤害减免百分比
		garrisonAttackDamageMulti	=	64,//garrisonAttackDamageMulti驻防部队普攻伤害百分比
		garrisonFightBackDamageMulti	=	65,//garrisonFightBackDamageMulti驻防部队反击伤害百分比
		garrisonSkillDamageMulti	=	66,//garrisonSkillDamageMulti驻防部队技能伤害百分比
		wallDurableMax	=	67,//wallDurableMax城墙耐久上限
		infantryTrainNumber	=	68,//infantryTrainNumber步兵训练容量
		cavalryTrainNumber	=	69,//cavalryTrainNumber骑兵训练容量
		bowmenTrainNumber	=	70,//bowmenTrainNumber弓兵训练容量
		siegeCarTrainNumber	=	71,//siegeCarTrainNumber攻城器械训练容量
		infantryAttack	=	72,//infantryAttack步兵攻击力
		cavalryAttack	=	73,//cavalryAttack骑兵攻击力
		bowmenAttack	=	74,//bowmenAttack弓兵攻击力
		siegeCarAttack	=	75,//siegeCarAttack攻城器械攻击力
		warningTowerAttack	=	76,//warningTowerAttack警戒塔攻击力
		infantryDefense	=	77,//infantryDefense步兵防御力
		cavalryDefense	=	78,//cavalryDefense骑兵防御力
		bowmenDefense	=	79,//bowmenDefense弓兵防御力
		siegeCarDefense	=	80,//siegeCarDefense攻城器械防御力
		warningTowerDefense	=	81,//warningTowerDefense警戒塔防御力
		infantryHpMax	=	82,//infantryHpMax步兵生命值
		cavalryHpMax	=	83,//cavalryHpMax骑兵生命值
		bowmenHpMax	=	84,//bowmenHpMax弓兵生命值
		siegeCarHpMax	=	85,//siegeCarHpMax攻城器械生命值
		warningTowerHpMax	=	86,//warningTowerHpMax警戒塔生命力
		infantryMoveSpeed	=	87,//infantryMoveSpeed步兵行军速度
		cavalryMoveSpeed	=	88,//cavalryMoveSpeed骑兵行军速度
		bowmenMoveSpeed	=	89,//bowmenMoveSpeed弓兵行军速度
		siegeCarMoveSpeed	=	90,//siegeCarMoveSpeed攻城器械行军速度
		guardTowerAttack	=	91,//guardTowerAttack警戒塔基础攻击属性
		guardTowerDefense	=	92,//guardTowerDefense警戒塔基础防御属性
		guardTowerHpMax	=	93,//guardTowerHpMax警戒塔基础生命属性
		troopsCapacityMulti	=	94,//troopsCapacityMulti部队容量百分比
		massTroopsCapacityMulti	=	95,//massTroopsCapacityMulti集结部队容量百分比
		lightInjuredMulti	=	96,//lightInjuredMulti部队轻伤百分比
		severeInjuredMulti	=	97,//severeInjuredMulti部队重伤百分比
		deathMulti	=	98,//deathMulti部队死亡百分比
		troopsHealthMulti	=	99,//troopsHealthMulti部队治疗百分比
		troopsToHealthMulti	=	100,//troopsToHealthMulti部队受到治疗百分比
		infantryAttackMulti	=	101,//infantryAttackMulti步兵攻击力百分比
		cavalryAttackMulti	=	102,//cavalryAttackMulti骑兵攻击力百分比
		bowmenAttackMulti	=	103,//bowmenAttackMulti弓兵攻击力百分比
		siegeCarAttackMulti	=	104,//siegeCarAttackMulti攻城器械攻击力百分比
		rallyAttackMulti	=	105,//rallyAttackMulti集结部队攻击力百分比
		garrisonAttackMulti	=	106,//garrisonAttackMulti驻防部队攻击力百分比
		infantryDefenseMulti	=	107,//infantryDefenseMulti步兵防御力百分比
		cavalryDefenseMulti	=	108,//cavalryDefenseMulti骑兵防御力百分比
		bowmenDefenseMulti	=	109,//bowmenDefenseMulti弓兵防御力百分比
		siegeCarDefenseMulti	=	110,//siegeCarDefenseMulti攻城器械防御力百分比
		rallyDefenseMulti	=	111,//rallyDefenseMulti集结部队防御力百分比
		garrisonDefenseMulti	=	112,//garrisonDefenseMulti驻防部队防御力百分比
		infantryHpMaxMulti	=	113,//infantryHpMaxMulti步兵生命值百分比
		cavalryHpMaxMulti	=	114,//cavalryHpMaxMulti骑兵生命值百分比
		bowmenHpMaxMulti	=	115,//bowmenHpMaxMulti弓兵生命值百分比
		siegeCarHpMaxMulti	=	116,//siegeCarHpMaxMulti攻城器械生命值百分比
		rallyHpMaxMulti	=	117,//rallyHpMaxMulti集结部队生命值百分比
		garrisonHpMaxMulti	=	118,//garrisonHpMaxMulti驻防部队生命值百分比
		infantryMoveSpeedMulti	=	119,//infantryMoveSpeedMulti步兵行军速度百分比
		cavalryMoveSpeedMulti	=	120,//cavalryMoveSpeedMulti骑兵行军速度百分比
		bowmenMoveSpeedMulti	=	121,//bowmenMoveSpeedMulti弓兵行军速度百分比
		siegeCarMoveSpeedMulti	=	122,//siegeCarMoveSpeedMulti攻城器械行军速度百分比
		marchSpeedMulti	=	123,//marchSpeedMulti部队行军速度加成百分比
		rallyMoveSpeedMulti	=	124,//rallyMoveSpeedMulti集结部队行军速度百分比
		rallyTimesReduce	=	125,//rallyTimesReduce集结进攻准备时间减少
		troopsHealthResourcesMulti	=	126,//troopsHealthResourcesMulti部队治疗资源消耗百分比
		guardTowerAttackMulti	=	127,//guardTowerAttackMulti警戒塔攻击百分比属性
		guardTowerDefenseMulti	=	128,//guardTowerDefenseMulti警戒塔防御百分比属性
		guardTowerHpMaxMulti	=	129,//guardTowerHpMaxMulti警戒塔生命百分比属性
		attackCityDeathMulti	=	130,//attackCityDeathMulti攻城阵亡比例减免百分比
		scoutSpeedMulti	=	131,//scoutSpeedMulti斥候行军速度加成百分比
		scoutNumber	=	132,//scoutNumber斥候行军队列
		scoutView	=	133,//scoutView斥候探图范围
		vitalityReduction	=	134,//vitalityReduction攻击中立单位减少的行动力点数
		allTerrMoveSpeedMulti	=	135,//allTerrMoveSpeedMulti联盟领土内部队行军速度百分比
		allTerrAtkMulti	=	136,//allTerrAtkMulti联盟领土内部队攻击力百分比
		allTerrBurnSpeedMulti	=	137,//allTerrBurnSpeedMulti联盟建筑燃烧速度百分比
		builDqueue	=	138,//builDqueue建筑工人队列
		buildSpeedMulti	=	139,//buildSpeedMulti建造速度加成
		researchSpeedMulti	=	140,//researchSpeedMulti研究速度加成
		trainSpeedMulti	=	141,//trainSpeedMulti训练速度加成
		healSpeedMulti	=	142,//healSpeedMulti治疗速度加成
		foodCapacityMulti	=	143,//foodCapacityMulti粮食产量加成
		woodCapacityMulti	=	144,//woodCapacityMulti木头产量加成
		stoneCapacityMulti	=	145,//stoneCapacityMulti石头产量加成
		glodCapacityMulti	=	146,//glodCapacityMulti金币产量加成
		getFoodSpeedMulti	=	147,//getFoodSpeedMulti食物采集速度加成
		getWoodSpeedMulti	=	148,//getWoodSpeedMulti木头采集速度加成
		getStoneSpeedMulti	=	149,//getStoneSpeedMulti石头采集速度加成
		getGlodSpeedMulti	=	150,//getGlodSpeedMulti金币采集速度加成
		getDiamondSpeedMulti	=	151,//getDiamondSpeedMulti宝石采集速度加成
		troopsSpaceMulti	=	152,//troopsSpaceMulti部队运载量加成
		extraResourcesMulti	=	153,//extraResourcesMulti资源采集额外加成
		resourcesProtectSpaceMulti	=	154,//resourcesProtectSpaceMulti资源保护量加成
		maxVitality	=	155,//maxVitality行动力上限
		equipmentProduceSpeedMulti	=	156,//equipmentProduceSpeedMulti装备材料生产速度加成
		hospitalSpaceMulti	=	157,//hospitalSpaceMulti医院容量加成
		vitalityRecoveryMulti	=	158,//vitalityRecoveryMulti行动力恢复加成
		transportSpeedMulti	=	159,//transportSpeedMulti运输部队行军速度加成
		allianceHelpTime	=	160,//allianceHelpTime联盟帮助时间加成
	};

	public enum pveAttrType
	{
		None	=	0,//无
		heroHp	=	1,//heroHp生命值
		heroAtk	=	2,//heroAtk攻击力
		heroDef	=	3,//heroDef防御力
		atkSpeedMulti	=	4,//atkSpeedMulti攻击速度
		critProMulti	=	5,//critProMulti暴击概率
		critHurtMulti	=	6,//critHurtMulti暴击伤害比例
		runSpeed	=	7,//runSpeed移动速度
		runSpeedMulti	=	8,//runSpeedMulti移动速度百分比
		heroHpMulti	=	9,//heroHpMulti生命值百分比
		heroAtkMulti	=	10,//heroAtkMulti攻击力百分比
		heroDefMulti	=	11,//heroDefMulti防御力百分比
		hurtBoostMulti	=	12,//hurtBoostMulti伤害增强
		hurtReduceMulti	=	13,//hurtReduceMulti伤害减免
	};

	public class getWay
	{
		public int	npc;//npc
		public int	script;//script
		public int	ui;//npc
		public int	parm;//script
	};


}

