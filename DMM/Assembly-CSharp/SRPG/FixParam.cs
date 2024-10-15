// Decompiled with JetBrains decompiler
// Type: SRPG.FixParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AE7")]
  public class FixParam
  {
    [Token(Token = "0x400650B")]
    public const int DEFAULT_ADULT_AGE = 18;
    [Token(Token = "0x400650C")]
    [FieldOffset(Offset = "0x8")]
    public OInt CriticalRate_Cri_Multiply;
    [Token(Token = "0x400650D")]
    [FieldOffset(Offset = "0x1C")]
    public OInt CriticalRate_Cri_Division;
    [Token(Token = "0x400650E")]
    [FieldOffset(Offset = "0x30")]
    public OInt CriticalRate_Luk_Multiply;
    [Token(Token = "0x400650F")]
    [FieldOffset(Offset = "0x44")]
    public OInt CriticalRate_Luk_Division;
    [Token(Token = "0x4006510")]
    [FieldOffset(Offset = "0x58")]
    public OInt MinCriticalDamageRate;
    [Token(Token = "0x4006511")]
    [FieldOffset(Offset = "0x6C")]
    public OInt MaxCriticalDamageRate;
    [Token(Token = "0x4006512")]
    [FieldOffset(Offset = "0x80")]
    public OInt HighGridAtkRate;
    [Token(Token = "0x4006513")]
    [FieldOffset(Offset = "0x94")]
    public OInt HighGridDefRate;
    [Token(Token = "0x4006514")]
    [FieldOffset(Offset = "0xA8")]
    public OInt HighGridCriRate;
    [Token(Token = "0x4006515")]
    [FieldOffset(Offset = "0xBC")]
    public OInt DownGridAtkRate;
    [Token(Token = "0x4006516")]
    [FieldOffset(Offset = "0xD0")]
    public OInt DownGridDefRate;
    [Token(Token = "0x4006517")]
    [FieldOffset(Offset = "0xE4")]
    public OInt DownGridCriRate;
    [Token(Token = "0x4006518")]
    [FieldOffset(Offset = "0xF8")]
    public OInt ParalysedRate;
    [Token(Token = "0x4006519")]
    [FieldOffset(Offset = "0x10C")]
    public OInt PoisonDamageRate;
    [Token(Token = "0x400651A")]
    [FieldOffset(Offset = "0x120")]
    public OInt BlindnessHitRate;
    [Token(Token = "0x400651B")]
    [FieldOffset(Offset = "0x134")]
    public OInt BlindnessAvoidRate;
    [Token(Token = "0x400651C")]
    [FieldOffset(Offset = "0x148")]
    public OInt BerserkAtkRate;
    [Token(Token = "0x400651D")]
    [FieldOffset(Offset = "0x15C")]
    public OInt BerserkDefRate;
    [Token(Token = "0x400651E")]
    [FieldOffset(Offset = "0x170")]
    public OInt TokkouDamageRate;
    [Token(Token = "0x400651F")]
    [FieldOffset(Offset = "0x184")]
    public OInt AbilityRankUpCountCoin;
    [Token(Token = "0x4006520")]
    [FieldOffset(Offset = "0x198")]
    public OInt AbilityRankUpCountMax;
    [Token(Token = "0x4006521")]
    [FieldOffset(Offset = "0x1AC")]
    public OInt AbilityRankUpCountRecoveryVal;
    [Token(Token = "0x4006522")]
    [FieldOffset(Offset = "0x1C0")]
    public OLong AbilityRankUpCountRecoverySec;
    [Token(Token = "0x4006523")]
    [FieldOffset(Offset = "0x1E8")]
    public OInt StaminaRecoveryCoin;
    [Token(Token = "0x4006524")]
    [FieldOffset(Offset = "0x1FC")]
    public OInt StaminaRecoveryVal;
    [Token(Token = "0x4006525")]
    [FieldOffset(Offset = "0x210")]
    public OLong StaminaRecoverySec;
    [Token(Token = "0x4006526")]
    [FieldOffset(Offset = "0x238")]
    public OInt StaminaStockCap;
    [Token(Token = "0x4006527")]
    [FieldOffset(Offset = "0x24C")]
    public OInt StaminaAdd;
    [Token(Token = "0x4006528")]
    [FieldOffset(Offset = "0x260")]
    public OInt StaminaAdd2;
    [Token(Token = "0x4006529")]
    [FieldOffset(Offset = "0x274")]
    public OInt[] StaminaAddCost;
    [Token(Token = "0x400652A")]
    [FieldOffset(Offset = "0x278")]
    public OInt CaveStaminaMax;
    [Token(Token = "0x400652B")]
    [FieldOffset(Offset = "0x28C")]
    public OInt CaveStaminaRecoveryVal;
    [Token(Token = "0x400652C")]
    [FieldOffset(Offset = "0x2A0")]
    public OLong CaveStaminaRecoverySec;
    [Token(Token = "0x400652D")]
    [FieldOffset(Offset = "0x2C8")]
    public OInt CaveStaminaStockCap;
    [Token(Token = "0x400652E")]
    [FieldOffset(Offset = "0x2DC")]
    public OInt CaveStaminaAdd;
    [Token(Token = "0x400652F")]
    [FieldOffset(Offset = "0x2F0")]
    public OInt[] CaveStaminaAddCost;
    [Token(Token = "0x4006530")]
    [FieldOffset(Offset = "0x2F4")]
    public OInt ChallengeArenaMax;
    [Token(Token = "0x4006531")]
    [FieldOffset(Offset = "0x308")]
    public OLong ChallengeArenaCoolDownSec;
    [Token(Token = "0x4006532")]
    [FieldOffset(Offset = "0x330")]
    public OInt ArenaMedalMultipler;
    [Token(Token = "0x4006533")]
    [FieldOffset(Offset = "0x344")]
    public OInt ArenaCoinRewardMultipler;
    [Token(Token = "0x4006534")]
    [FieldOffset(Offset = "0x358")]
    public OInt ArenaResetCooldownCost;
    [Token(Token = "0x4006535")]
    [FieldOffset(Offset = "0x36C")]
    public OInt[] ArenaResetTicketCost;
    [Token(Token = "0x4006536")]
    [FieldOffset(Offset = "0x370")]
    public OInt ChallengeTourMax;
    [Token(Token = "0x4006537")]
    [FieldOffset(Offset = "0x384")]
    public OInt ChallengeMultiMax;
    [Token(Token = "0x4006538")]
    [FieldOffset(Offset = "0x398")]
    public OInt AwakeRate;
    [Token(Token = "0x4006539")]
    [FieldOffset(Offset = "0x3AC")]
    public OInt GemsGainNormalAttack;
    [Token(Token = "0x400653A")]
    [FieldOffset(Offset = "0x3C0")]
    public OInt GemsGainSideAttack;
    [Token(Token = "0x400653B")]
    [FieldOffset(Offset = "0x3D4")]
    public OInt GemsGainBackAttack;
    [Token(Token = "0x400653C")]
    [FieldOffset(Offset = "0x3E8")]
    public OInt GemsGainWeakAttack;
    [Token(Token = "0x400653D")]
    [FieldOffset(Offset = "0x3FC")]
    public OInt GemsGainCriticalAttack;
    [Token(Token = "0x400653E")]
    [FieldOffset(Offset = "0x410")]
    public OInt GemsGainKillBonus;
    [Token(Token = "0x400653F")]
    [FieldOffset(Offset = "0x424")]
    public OInt GemsGainDiffFloorCount;
    [Token(Token = "0x4006540")]
    [FieldOffset(Offset = "0x438")]
    public OInt GemsGainDiffFloorMax;
    [Token(Token = "0x4006541")]
    [FieldOffset(Offset = "0x44C")]
    public OInt ElementResistUpRate;
    [Token(Token = "0x4006542")]
    [FieldOffset(Offset = "0x460")]
    public OInt ElementResistDownRate;
    [Token(Token = "0x4006543")]
    [FieldOffset(Offset = "0x474")]
    public OInt GemsGainValue;
    [Token(Token = "0x4006544")]
    [FieldOffset(Offset = "0x488")]
    public OInt GemsBuffValue;
    [Token(Token = "0x4006545")]
    [FieldOffset(Offset = "0x49C")]
    public OInt GemsBuffTurn;
    [Token(Token = "0x4006546")]
    [FieldOffset(Offset = "0x4B0")]
    public OInt[] ShopUpdateTime;
    [Token(Token = "0x4006547")]
    [FieldOffset(Offset = "0x4B4")]
    public OInt ContinueCoinCost;
    [Token(Token = "0x4006548")]
    [FieldOffset(Offset = "0x4C8")]
    public OInt ContinueCoinCostMulti;
    [Token(Token = "0x4006549")]
    [FieldOffset(Offset = "0x4DC")]
    public OInt ContinueCoinCostMultiTower;
    [Token(Token = "0x400654A")]
    [FieldOffset(Offset = "0x4F0")]
    public OInt AvoidBaseRate;
    [Token(Token = "0x400654B")]
    [FieldOffset(Offset = "0x504")]
    public OInt AvoidParamScale;
    [Token(Token = "0x400654C")]
    [FieldOffset(Offset = "0x518")]
    public OInt MaxAvoidRate;
    [Token(Token = "0x400654D")]
    [FieldOffset(Offset = "0x52C")]
    public OString[] Products;
    [Token(Token = "0x400654E")]
    [FieldOffset(Offset = "0x530")]
    public OString VipCardProduct;
    [Token(Token = "0x400654F")]
    [FieldOffset(Offset = "0x534")]
    public OInt VipCardDate;
    [Token(Token = "0x4006550")]
    [FieldOffset(Offset = "0x548")]
    public OString PremiumProduct;
    [Token(Token = "0x4006551")]
    [FieldOffset(Offset = "0x54C")]
    public OInt FreeGachaGoldMax;
    [Token(Token = "0x4006552")]
    [FieldOffset(Offset = "0x560")]
    public OLong FreeGachaGoldCoolDownSec;
    [Token(Token = "0x4006553")]
    [FieldOffset(Offset = "0x588")]
    public OLong FreeGachaCoinCoolDownSec;
    [Token(Token = "0x4006554")]
    [FieldOffset(Offset = "0x5B0")]
    public OInt BuyGoldCost;
    [Token(Token = "0x4006555")]
    [FieldOffset(Offset = "0x5C4")]
    public OInt BuyGoldAmount;
    [Token(Token = "0x4006556")]
    [FieldOffset(Offset = "0x5D8")]
    public OInt SupportCost;
    [Token(Token = "0x4006557")]
    [FieldOffset(Offset = "0x5EC")]
    public Dictionary<EUnitCondition, OInt> DefaultCondTurns;
    [Token(Token = "0x4006558")]
    [FieldOffset(Offset = "0x5F0")]
    public OInt RandomEffectMax;
    [Token(Token = "0x4006559")]
    [FieldOffset(Offset = "0x604")]
    public OInt ChargeTimeMax;
    [Token(Token = "0x400655A")]
    [FieldOffset(Offset = "0x618")]
    public OInt ChargeTimeDecWait;
    [Token(Token = "0x400655B")]
    [FieldOffset(Offset = "0x62C")]
    public OInt ChargeTimeDecMove;
    [Token(Token = "0x400655C")]
    [FieldOffset(Offset = "0x640")]
    public OInt ChargeTimeDecAction;
    [Token(Token = "0x400655D")]
    [FieldOffset(Offset = "0x654")]
    public OInt AddHitRateSide;
    [Token(Token = "0x400655E")]
    [FieldOffset(Offset = "0x668")]
    public OInt AddHitRateBack;
    [Token(Token = "0x400655F")]
    [FieldOffset(Offset = "0x67C")]
    public OInt HpAutoHealRate;
    [Token(Token = "0x4006560")]
    [FieldOffset(Offset = "0x690")]
    public OInt MpAutoHealRate;
    [Token(Token = "0x4006561")]
    [FieldOffset(Offset = "0x6A4")]
    public OInt GoodSleepHpHealRate;
    [Token(Token = "0x4006562")]
    [FieldOffset(Offset = "0x6B8")]
    public OInt GoodSleepMpHealRate;
    [Token(Token = "0x4006563")]
    [FieldOffset(Offset = "0x6CC")]
    public OInt HpDyingRate;
    [Token(Token = "0x4006564")]
    [FieldOffset(Offset = "0x6E0")]
    public OInt ZeneiSupportSkillRate;
    [Token(Token = "0x4006565")]
    [FieldOffset(Offset = "0x6F4")]
    public OInt BeginnerDays;
    [Token(Token = "0x4006566")]
    [FieldOffset(Offset = "0x708")]
    public OInt ArtifactBoxCap;
    [Token(Token = "0x4006567")]
    [FieldOffset(Offset = "0x71C")]
    public OString CommonPieceFire;
    [Token(Token = "0x4006568")]
    [FieldOffset(Offset = "0x720")]
    public OString CommonPieceWater;
    [Token(Token = "0x4006569")]
    [FieldOffset(Offset = "0x724")]
    public OString CommonPieceThunder;
    [Token(Token = "0x400656A")]
    [FieldOffset(Offset = "0x728")]
    public OString CommonPieceWind;
    [Token(Token = "0x400656B")]
    [FieldOffset(Offset = "0x72C")]
    public OString CommonPieceShine;
    [Token(Token = "0x400656C")]
    [FieldOffset(Offset = "0x730")]
    public OString CommonPieceDark;
    [Token(Token = "0x400656D")]
    [FieldOffset(Offset = "0x734")]
    public OString CommonPieceAll;
    [Token(Token = "0x400656E")]
    [FieldOffset(Offset = "0x738")]
    public int PartyNumNormal;
    [Token(Token = "0x400656F")]
    [FieldOffset(Offset = "0x73C")]
    public int PartyNumEvent;
    [Token(Token = "0x4006570")]
    [FieldOffset(Offset = "0x740")]
    public int PartyNumMulti;
    [Token(Token = "0x4006571")]
    [FieldOffset(Offset = "0x744")]
    public int PartyNumArenaAttack;
    [Token(Token = "0x4006572")]
    [FieldOffset(Offset = "0x748")]
    public int PartyNumArenaDefense;
    [Token(Token = "0x4006573")]
    [FieldOffset(Offset = "0x74C")]
    public int PartyNumChQuest;
    [Token(Token = "0x4006574")]
    [FieldOffset(Offset = "0x750")]
    public int PartyNumTower;
    [Token(Token = "0x4006575")]
    [FieldOffset(Offset = "0x754")]
    public int PartyNumVersus;
    [Token(Token = "0x4006576")]
    [FieldOffset(Offset = "0x758")]
    public int PartyNumMultiTower;
    [Token(Token = "0x4006577")]
    [FieldOffset(Offset = "0x75C")]
    public int PartyNumOrdeal;
    [Token(Token = "0x4006578")]
    [FieldOffset(Offset = "0x760")]
    public int PartyNumRaid;
    [Token(Token = "0x4006579")]
    [FieldOffset(Offset = "0x764")]
    public int PartyNumGuildRaid;
    [Token(Token = "0x400657A")]
    [FieldOffset(Offset = "0x768")]
    public int PartyNumExtra;
    [Token(Token = "0x400657B")]
    [FieldOffset(Offset = "0x76C")]
    public int PartyNumGvG;
    [Token(Token = "0x400657C")]
    [FieldOffset(Offset = "0x770")]
    public int PartyNumWorldRaid;
    [Token(Token = "0x400657D")]
    [FieldOffset(Offset = "0x774")]
    public int PartyNumBulkSkip;
    [Token(Token = "0x400657E")]
    [FieldOffset(Offset = "0x778")]
    public int PartyNumLeagueMatchAtk;
    [Token(Token = "0x400657F")]
    [FieldOffset(Offset = "0x77C")]
    public int PartyNumLeagueMatchDefense;
    [Token(Token = "0x4006580")]
    [FieldOffset(Offset = "0x780")]
    public OBool IsDisableSuspend;
    [Token(Token = "0x4006581")]
    [FieldOffset(Offset = "0x78C")]
    public OInt SuspendSaveInterval;
    [Token(Token = "0x4006582")]
    [FieldOffset(Offset = "0x7A0")]
    public bool IsJobMaster;
    [Token(Token = "0x4006583")]
    [FieldOffset(Offset = "0x7A4")]
    public OInt DefaultDeathCount;
    [Token(Token = "0x4006584")]
    [FieldOffset(Offset = "0x7B8")]
    public OInt DefaultClockUpValue;
    [Token(Token = "0x4006585")]
    [FieldOffset(Offset = "0x7CC")]
    public OInt DefaultClockDownValue;
    [Token(Token = "0x4006586")]
    [FieldOffset(Offset = "0x7E0")]
    public OInt[] EquipArtifactSlotUnlock;
    [Token(Token = "0x4006587")]
    [FieldOffset(Offset = "0x7E4")]
    public OInt KnockBackHeight;
    [Token(Token = "0x4006588")]
    [FieldOffset(Offset = "0x7F8")]
    public OInt ThrowHeight;
    [Token(Token = "0x4006589")]
    [FieldOffset(Offset = "0x80C")]
    public OString[] ArtifactRarePiece;
    [Token(Token = "0x400658A")]
    [FieldOffset(Offset = "0x810")]
    public OString ArtifactCommonPiece;
    [Token(Token = "0x400658B")]
    [FieldOffset(Offset = "0x814")]
    public OString[] EquipCommonPiece;
    [Token(Token = "0x400658C")]
    [FieldOffset(Offset = "0x818")]
    public OInt[] EquipCommonPieceNum;
    [Token(Token = "0x400658D")]
    [FieldOffset(Offset = "0x81C")]
    public OString[] SoulCommonPiece;
    [Token(Token = "0x400658E")]
    [FieldOffset(Offset = "0x820")]
    public OInt[] EquipCommonPieceCost;
    [Token(Token = "0x400658F")]
    [FieldOffset(Offset = "0x824")]
    public OString[] EquipCmn;
    [Token(Token = "0x4006590")]
    [FieldOffset(Offset = "0x828")]
    public OInt AudienceMax;
    [Token(Token = "0x4006591")]
    [FieldOffset(Offset = "0x83C")]
    public OInt AbilityRankUpPointMax;
    [Token(Token = "0x4006592")]
    [FieldOffset(Offset = "0x850")]
    public OInt AbilityRankUpPointAddMax;
    [Token(Token = "0x4006593")]
    [FieldOffset(Offset = "0x864")]
    public OInt AbilityRankupPointCoinRate;
    [Token(Token = "0x4006594")]
    [FieldOffset(Offset = "0x878")]
    public OInt FirstFriendMax;
    [Token(Token = "0x4006595")]
    [FieldOffset(Offset = "0x88C")]
    public OInt FirstFriendCoin;
    [Token(Token = "0x4006596")]
    [FieldOffset(Offset = "0x8A0")]
    public OInt CombinationRate;
    [Token(Token = "0x4006597")]
    [FieldOffset(Offset = "0x8B4")]
    public OInt WeakUpRate;
    [Token(Token = "0x4006598")]
    [FieldOffset(Offset = "0x8C8")]
    public OInt ResistDownRate;
    [Token(Token = "0x4006599")]
    [FieldOffset(Offset = "0x8DC")]
    public OInt OrdealCT;
    [Token(Token = "0x400659A")]
    [FieldOffset(Offset = "0x8F0")]
    public OInt EsaAssist;
    [Token(Token = "0x400659B")]
    [FieldOffset(Offset = "0x904")]
    public OInt EsaResist;
    [Token(Token = "0x400659C")]
    [FieldOffset(Offset = "0x918")]
    public int CardSellMul;
    [Token(Token = "0x400659D")]
    [FieldOffset(Offset = "0x91C")]
    public int CardExpMul;
    [Token(Token = "0x400659E")]
    [FieldOffset(Offset = "0x920")]
    public OInt CardMax;
    [Token(Token = "0x400659F")]
    [FieldOffset(Offset = "0x934")]
    public OInt CardTrustMax;
    [Token(Token = "0x40065A0")]
    [FieldOffset(Offset = "0x948")]
    public OInt CardTrustPileUp;
    [Token(Token = "0x40065A1")]
    [FieldOffset(Offset = "0x95C")]
    public string CardSellCoinItem;
    [Token(Token = "0x40065A2")]
    [FieldOffset(Offset = "0x960")]
    public OInt CardAwakeUnlockLevelCap;
    [Token(Token = "0x40065A3")]
    [FieldOffset(Offset = "0x974")]
    public OInt TobiraLvCap;
    [Token(Token = "0x40065A4")]
    [FieldOffset(Offset = "0x988")]
    public OInt TobiraUnitLvCapBonus;
    [Token(Token = "0x40065A5")]
    [FieldOffset(Offset = "0x99C")]
    public OString[] TobiraUnlockElem;
    [Token(Token = "0x40065A6")]
    [FieldOffset(Offset = "0x9A0")]
    public OString[] TobiraUnlockBirth;
    [Token(Token = "0x40065A7")]
    [FieldOffset(Offset = "0x9A4")]
    public OInt IniValRec;
    [Token(Token = "0x40065A8")]
    [FieldOffset(Offset = "0x9B8")]
    public OInt GuerrillaVal;
    [Token(Token = "0x40065A9")]
    [FieldOffset(Offset = "0x9CC")]
    public OInt DraftSelectSeconds;
    [Token(Token = "0x40065AA")]
    [FieldOffset(Offset = "0x9E0")]
    public OInt DraftOrganizeSeconds;
    [Token(Token = "0x40065AB")]
    [FieldOffset(Offset = "0x9F4")]
    public OInt DraftPlaceSeconds;
    [Token(Token = "0x40065AC")]
    [FieldOffset(Offset = "0xA08")]
    public OInt DraftBanSeconds;
    [Token(Token = "0x40065AD")]
    [FieldOffset(Offset = "0xA1C")]
    public int GuildCreateCost;
    [Token(Token = "0x40065AE")]
    [FieldOffset(Offset = "0xA20")]
    public int GuildRenameCost;
    [Token(Token = "0x40065AF")]
    [FieldOffset(Offset = "0xA24")]
    public int GuildEmblemCost;
    [Token(Token = "0x40065B0")]
    [FieldOffset(Offset = "0xA28")]
    public int GuildInvestLimit;
    [Token(Token = "0x40065B1")]
    [FieldOffset(Offset = "0xA2C")]
    public int GuildDefaultMemberMax;
    [Token(Token = "0x40065B2")]
    [FieldOffset(Offset = "0xA30")]
    public int GuildDefaultSubMasterMax;
    [Token(Token = "0x40065B3")]
    [FieldOffset(Offset = "0xA34")]
    public int GuildEntryCoolTime;
    [Token(Token = "0x40065B4")]
    [FieldOffset(Offset = "0xA38")]
    public int GuildInvestCoolTime;
    [Token(Token = "0x40065B5")]
    [FieldOffset(Offset = "0xA3C")]
    public OInt ConvertRatePieceElement;
    [Token(Token = "0x40065B6")]
    [FieldOffset(Offset = "0xA50")]
    public OInt ConvertRatePieceCommon;
    [Token(Token = "0x40065B7")]
    [FieldOffset(Offset = "0xA68")]
    public long RaidEffectiveTime;
    [Token(Token = "0x40065B8")]
    [FieldOffset(Offset = "0xA70")]
    public OInt MTSkipCost;
    [Token(Token = "0x40065B9")]
    [FieldOffset(Offset = "0xA84")]
    public OString GachaChangePieceCoinIname;
    [Token(Token = "0x40065BA")]
    [FieldOffset(Offset = "0xA88")]
    public int AutoRepeatCountMax;
    [Token(Token = "0x40065BB")]
    [FieldOffset(Offset = "0xA8C")]
    public int AutoRepeatCoolTime;
    [Token(Token = "0x40065BC")]
    [FieldOffset(Offset = "0xA90")]
    public TobiraParam.Category ConceptcardSlot2UnlockTobira;
    [Token(Token = "0x40065BD")]
    [FieldOffset(Offset = "0xA94")]
    public int[] ConceptcardSlot2DecRate;
    [Token(Token = "0x40065D8")]
    [FieldOffset(Offset = "0xB40")]
    public DateTime InvalidSkillEnableTime;
    [Token(Token = "0x40065D9")]
    [FieldOffset(Offset = "0xB48")]
    public int CondBombCostJewelRate;
    [Token(Token = "0x40065DA")]
    [FieldOffset(Offset = "0xB4C")]
    public int CondBombDupliMax;
    [Token(Token = "0x40065DB")]
    [FieldOffset(Offset = "0xB50")]
    public int CondSlipDamageRate;
    [Token(Token = "0x40065DC")]
    [FieldOffset(Offset = "0xB54")]
    public int CondSlipAttackRate;
    [Token(Token = "0x40065DD")]
    [FieldOffset(Offset = "0xB58")]
    public int CondSlipHealCount;
    [Token(Token = "0x40065DE")]
    [FieldOffset(Offset = "0xB5C")]
    public int CondDownDamageRate;
    [Token(Token = "0x40065DF")]
    [FieldOffset(Offset = "0xB60")]
    public int CondDownAttackRate;
    [Token(Token = "0x40065E0")]
    [FieldOffset(Offset = "0xB64")]
    public int CondDownHealRate;
    [Token(Token = "0x40065E1")]
    [FieldOffset(Offset = "0xB68")]
    public int CondDowntHealMaxRate;
    [Token(Token = "0x40065E2")]
    [FieldOffset(Offset = "0xB6C")]
    public int RankmatchPointRangeSub;
    [Token(Token = "0x40065E3")]
    [FieldOffset(Offset = "0xB70")]
    public int RankmatchPointRangeAdd;
    [Token(Token = "0x40065E4")]
    [FieldOffset(Offset = "0xB74")]
    public int CondFreezeRate;
    [Token(Token = "0x40065E5")]
    [FieldOffset(Offset = "0xB78")]
    public DateTime AdvBeginAt;
    [Token(Token = "0x40065E6")]
    [FieldOffset(Offset = "0xB80")]
    public int AdvLotteryNum;
    [Token(Token = "0x40065E7")]
    [FieldOffset(Offset = "0xB84")]
    public string BondResetItem;
    [Token(Token = "0x40065E8")]
    [FieldOffset(Offset = "0xB88")]
    public int BondResetItemNum;
    [Token(Token = "0x40065E9")]
    [FieldOffset(Offset = "0xB8C")]
    public int GuildMasterChgDay;
    [Token(Token = "0x40065EA")]
    [FieldOffset(Offset = "0xB90")]
    public int GuildMemberChgDay;
    [Token(Token = "0x40065EB")]
    [FieldOffset(Offset = "0xB94")]
    public int OneEnergyGoldCost;
    [Token(Token = "0x40065EC")]
    [FieldOffset(Offset = "0xB98")]
    public int OneHourEnergyCost;
    [Token(Token = "0x40065ED")]
    [FieldOffset(Offset = "0xB9C")]
    public int PointQuestRankingDrawMax;
    [Token(Token = "0x40065EE")]
    [FieldOffset(Offset = "0xBA0")]
    public int PointQuestRankingLoadMax;
    [Token(Token = "0x40065EF")]
    [FieldOffset(Offset = "0xBA4")]
    public int PublicInfoCoolTime;
    [Token(Token = "0x40065F0")]
    [FieldOffset(Offset = "0xBA8")]
    public DateTime MasteryRewardEnableTime;
    [Token(Token = "0x40065F1")]
    [FieldOffset(Offset = "0xBB0")]
    public DateTime ToolTipRuneEnableTime;
    [Token(Token = "0x40065F2")]
    [FieldOffset(Offset = "0xBB8")]
    public DateTime UnitBadgeAllEnableTime;
    [Token(Token = "0x40065F3")]
    [FieldOffset(Offset = "0xBC0")]
    public int[] CrystalSubSlotRefRate;
    [Token(Token = "0x40065F4")]
    [FieldOffset(Offset = "0xBC4")]
    public int[] CrystalSetBonusRefRate;
    [Token(Token = "0x40065F5")]
    [FieldOffset(Offset = "0xBC8")]
    public int CrystalPlusMax;
    [Token(Token = "0x40065F6")]
    [FieldOffset(Offset = "0xBCC")]
    public int CrystalMax;
    [Token(Token = "0x40065F7")]
    [FieldOffset(Offset = "0xBD0")]
    public int[] CrystalSlotLevelLock;
    [Token(Token = "0x40065F8")]
    [FieldOffset(Offset = "0xBD4")]
    public int[] CrystalRankLotteryRate;
    [Token(Token = "0x40065F9")]
    [FieldOffset(Offset = "0xBD8")]
    public DateTime CrystalEnableAt;
    [Token(Token = "0x40065FA")]
    [FieldOffset(Offset = "0xBE0")]
    public DateTime RunePrideReleaseDate;
    [Token(Token = "0x40065FB")]
    [FieldOffset(Offset = "0xBE8")]
    public int AdultAge;
    [Token(Token = "0x40065FC")]
    [FieldOffset(Offset = "0xBEC")]
    public int LeagueMatchPriorNum;
    [Token(Token = "0x40065FD")]
    [FieldOffset(Offset = "0xBF0")]
    public int ExpansionSlotAddNum;
    [Token(Token = "0x40065FE")]
    [FieldOffset(Offset = "0xBF8")]
    private DateTime LeagueMatchMatchingStartTime;
    [Token(Token = "0x40065FF")]
    [FieldOffset(Offset = "0xC00")]
    private DateTime LeagueMatchMatchingEndTime;
    [Token(Token = "0x4006600")]
    [FieldOffset(Offset = "0xC08")]
    public int CombatPowerPlayerRankingMax;
    [Token(Token = "0x4006601")]
    [FieldOffset(Offset = "0xC0C")]
    public int CombatPowerPortRankingMax;
    [Token(Token = "0x4006602")]
    [FieldOffset(Offset = "0xC10")]
    public int InfiniteShopMaxNum;
    [Token(Token = "0x4006603")]
    [FieldOffset(Offset = "0xC14")]
    public int UnitStatusAwakeLimit;
    [Token(Token = "0x4006604")]
    [FieldOffset(Offset = "0xC18")]
    public string UnitStatusAwakeItem;
    [Token(Token = "0x4006605")]
    [FieldOffset(Offset = "0xC20")]
    private DateTime ProdcutsEndOfSale;

    [Token(Token = "0x17000C95")]
    public OInt MultiRoomCommentMax
    {
      [Token(Token = "0x6006EC5"), Address(RVA = "0x367C50", Offset = "0x366A50", VA = "0x10367C50")] get
      {
        return new OInt();
      }
      [Token(Token = "0x6006EC6"), Address(RVA = "0x367ED0", Offset = "0x366CD0", VA = "0x10367ED0")] private set
      {
      }
    }

    [Token(Token = "0x17000C96")]
    public OInt MultiInviteCommentMax
    {
      [Token(Token = "0x6006EC7"), Address(RVA = "0x367C30", Offset = "0x366A30", VA = "0x10367C30")] get
      {
        return new OInt();
      }
      [Token(Token = "0x6006EC8"), Address(RVA = "0x367EB0", Offset = "0x366CB0", VA = "0x10367EB0")] private set
      {
      }
    }

    [Token(Token = "0x17000C97")]
    public OInt InspirationSkillLvUpRate
    {
      [Token(Token = "0x6006EC9"), Address(RVA = "0x367BF0", Offset = "0x3669F0", VA = "0x10367BF0")] get
      {
        return new OInt();
      }
      [Token(Token = "0x6006ECA"), Address(RVA = "0x367E70", Offset = "0x366C70", VA = "0x10367E70")] private set
      {
      }
    }

    [Token(Token = "0x17000C98")]
    public OInt InspirationSkillSlotMax
    {
      [Token(Token = "0x6006ECB"), Address(RVA = "0x367C10", Offset = "0x366A10", VA = "0x10367C10")] get
      {
        return new OInt();
      }
      [Token(Token = "0x6006ECC"), Address(RVA = "0x367E90", Offset = "0x366C90", VA = "0x10367E90")] private set
      {
      }
    }

    [Token(Token = "0x17000C99")]
    public int[] QuestResetCost
    {
      [Token(Token = "0x6006ECD"), Address(RVA = "0x367C70", Offset = "0x366A70", VA = "0x10367C70")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6006ECE"), Address(RVA = "0x367EF0", Offset = "0x366CF0", VA = "0x10367EF0")] private set
      {
      }
    }

    [Token(Token = "0x17000C9A")]
    public int RuneEnhNextNum
    {
      [Token(Token = "0x6006ECF"), Address(RVA = "0x367C90", Offset = "0x366A90", VA = "0x10367C90")] get
      {
        return new int();
      }
      [Token(Token = "0x6006ED0"), Address(RVA = "0x367F30", Offset = "0x366D30", VA = "0x10367F30")] private set
      {
      }
    }

    [Token(Token = "0x17000C9B")]
    public int RuneMaxEvoNum
    {
      [Token(Token = "0x6006ED1"), Address(RVA = "0x367CA0", Offset = "0x366AA0", VA = "0x10367CA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006ED2"), Address(RVA = "0x367F50", Offset = "0x366D50", VA = "0x10367F50")] private set
      {
      }
    }

    [Token(Token = "0x17000C9C")]
    public int RuneStorageInit
    {
      [Token(Token = "0x6006ED3"), Address(RVA = "0x367CD0", Offset = "0x366AD0", VA = "0x10367CD0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006ED4"), Address(RVA = "0x367FB0", Offset = "0x366DB0", VA = "0x10367FB0")] private set
      {
      }
    }

    [Token(Token = "0x17000C9D")]
    public int RuneStorageExpansion
    {
      [Token(Token = "0x6006ED5"), Address(RVA = "0x367CC0", Offset = "0x366AC0", VA = "0x10367CC0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006ED6"), Address(RVA = "0x367F90", Offset = "0x366D90", VA = "0x10367F90")] private set
      {
      }
    }

    [Token(Token = "0x17000C9E")]
    public int RuneStorageMax
    {
      [Token(Token = "0x6006ED7"), Address(RVA = "0x367CE0", Offset = "0x366AE0", VA = "0x10367CE0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006ED8"), Address(RVA = "0x367FD0", Offset = "0x366DD0", VA = "0x10367FD0")] private set
      {
      }
    }

    [Token(Token = "0x17000C9F")]
    public int RuneStorageCoinCost
    {
      [Token(Token = "0x6006ED9"), Address(RVA = "0x367CB0", Offset = "0x366AB0", VA = "0x10367CB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EDA"), Address(RVA = "0x367F70", Offset = "0x366D70", VA = "0x10367F70")] private set
      {
      }
    }

    [Token(Token = "0x17000CA0")]
    public string RuneDedicatedCostIname
    {
      [Token(Token = "0x6006EDB"), Address(RVA = "0x367C80", Offset = "0x366A80", VA = "0x10367C80")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006EDC"), Address(RVA = "0x367F10", Offset = "0x366D10", VA = "0x10367F10")] private set
      {
      }
    }

    [Token(Token = "0x17000CA1")]
    public int StoryExChallengeMax
    {
      [Token(Token = "0x6006EDD"), Address(RVA = "0x367CF0", Offset = "0x366AF0", VA = "0x10367CF0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EDE"), Address(RVA = "0x367FF0", Offset = "0x366DF0", VA = "0x10367FF0")] private set
      {
      }
    }

    [Token(Token = "0x17000CA2")]
    public int StoryExResetMax
    {
      [Token(Token = "0x6006EDF"), Address(RVA = "0x367D00", Offset = "0x366B00", VA = "0x10367D00")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EE0"), Address(RVA = "0x368010", Offset = "0x366E10", VA = "0x10368010")] private set
      {
      }
    }

    [Token(Token = "0x17000CA3")]
    public string StoryExRsetCost
    {
      [Token(Token = "0x6006EE1"), Address(RVA = "0x367D10", Offset = "0x366B10", VA = "0x10367D10")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006EE2"), Address(RVA = "0x368030", Offset = "0x366E30", VA = "0x10368030")] private set
      {
      }
    }

    [Token(Token = "0x17000CA4")]
    public int WorldRaidDmgDropMax
    {
      [Token(Token = "0x6006EE3"), Address(RVA = "0x367D20", Offset = "0x366B20", VA = "0x10367D20")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EE4"), Address(RVA = "0x368050", Offset = "0x366E50", VA = "0x10368050")] private set
      {
      }
    }

    [Token(Token = "0x17000CA5")]
    public int DuelMax
    {
      [Token(Token = "0x6006EE5"), Address(RVA = "0x367BB0", Offset = "0x3669B0", VA = "0x10367BB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EE6"), Address(RVA = "0x367DF0", Offset = "0x366BF0", VA = "0x10367DF0")] private set
      {
      }
    }

    [Token(Token = "0x17000CA6")]
    public int DuelCoolTime
    {
      [Token(Token = "0x6006EE7"), Address(RVA = "0x367B90", Offset = "0x366990", VA = "0x10367B90")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EE8"), Address(RVA = "0x367DB0", Offset = "0x366BB0", VA = "0x10367DB0")] private set
      {
      }
    }

    [Token(Token = "0x17000CA7")]
    public int DuelBasePoint
    {
      [Token(Token = "0x6006EE9"), Address(RVA = "0x367B50", Offset = "0x366950", VA = "0x10367B50")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EEA"), Address(RVA = "0x367D30", Offset = "0x366B30", VA = "0x10367D30")] private set
      {
      }
    }

    [Token(Token = "0x17000CA8")]
    public int DuelWinPoint
    {
      [Token(Token = "0x6006EEB"), Address(RVA = "0x367BE0", Offset = "0x3669E0", VA = "0x10367BE0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EEC"), Address(RVA = "0x367E50", Offset = "0x366C50", VA = "0x10367E50")] private set
      {
      }
    }

    [Token(Token = "0x17000CA9")]
    public int DuelRestActPoint
    {
      [Token(Token = "0x6006EED"), Address(RVA = "0x367BC0", Offset = "0x3669C0", VA = "0x10367BC0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EEE"), Address(RVA = "0x367E10", Offset = "0x366C10", VA = "0x10367E10")] private set
      {
      }
    }

    [Token(Token = "0x17000CAA")]
    public int DuelBattlelHighRankerCoef
    {
      [Token(Token = "0x6006EEF"), Address(RVA = "0x367B60", Offset = "0x366960", VA = "0x10367B60")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EF0"), Address(RVA = "0x367D50", Offset = "0x366B50", VA = "0x10367D50")] private set
      {
      }
    }

    [Token(Token = "0x17000CAB")]
    public int DuelBattlelLowRankerCoef
    {
      [Token(Token = "0x6006EF1"), Address(RVA = "0x367B70", Offset = "0x366970", VA = "0x10367B70")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EF2"), Address(RVA = "0x367D70", Offset = "0x366B70", VA = "0x10367D70")] private set
      {
      }
    }

    [Token(Token = "0x17000CAC")]
    public int DuelCalcRankingSec
    {
      [Token(Token = "0x6006EF3"), Address(RVA = "0x367B80", Offset = "0x366980", VA = "0x10367B80")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EF4"), Address(RVA = "0x367D90", Offset = "0x366B90", VA = "0x10367D90")] private set
      {
      }
    }

    [Token(Token = "0x17000CAD")]
    public int DuelDailyRankingViewMax
    {
      [Token(Token = "0x6006EF5"), Address(RVA = "0x367BA0", Offset = "0x3669A0", VA = "0x10367BA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EF6"), Address(RVA = "0x367DD0", Offset = "0x366BD0", VA = "0x10367DD0")] private set
      {
      }
    }

    [Token(Token = "0x17000CAE")]
    public int DuelSeasonRankingViewMax
    {
      [Token(Token = "0x6006EF7"), Address(RVA = "0x367BD0", Offset = "0x3669D0", VA = "0x10367BD0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006EF8"), Address(RVA = "0x367E30", Offset = "0x366C30", VA = "0x10367E30")] private set
      {
      }
    }

    [Token(Token = "0x6006EF9")]
    [Address(RVA = "0x362F20", Offset = "0x361D20", VA = "0x10362F20")]
    public bool Deserialize(JSON_FixParam json) => new bool();

    [Token(Token = "0x6006EFA")]
    [Address(RVA = "0x362E70", Offset = "0x361C70", VA = "0x10362E70")]
    public OString[] ConvertOStringArray(string[] strs) => (OString[]) null;

    [Token(Token = "0x6006EFB")]
    [Address(RVA = "0x362DC0", Offset = "0x361BC0", VA = "0x10362DC0")]
    public OInt[] ConvertOIntArray(int[] strs) => (OInt[]) null;

    [Token(Token = "0x6006EFC")]
    [Address(RVA = "0x3673A0", Offset = "0x3661A0", VA = "0x103673A0")]
    public bool GetIsInvalidSkillEnable() => new bool();

    [Token(Token = "0x6006EFD")]
    [Address(RVA = "0x367430", Offset = "0x366230", VA = "0x10367430")]
    public bool GetIsMasteryRewardEnable() => new bool();

    [Token(Token = "0x6006EFE")]
    [Address(RVA = "0x367810", Offset = "0x366610", VA = "0x10367810")]
    public bool IsToolTipRuneEnable() => new bool();

    [Token(Token = "0x6006EFF")]
    [Address(RVA = "0x3678A0", Offset = "0x3666A0", VA = "0x103678A0")]
    public bool IsUnitBadgeAllEnable() => new bool();

    [Token(Token = "0x6006F00")]
    [Address(RVA = "0x3674C0", Offset = "0x3662C0", VA = "0x103674C0")]
    public bool IsCrystalEnable() => new bool();

    [Token(Token = "0x6006F01")]
    [Address(RVA = "0x367780", Offset = "0x366580", VA = "0x10367780")]
    public bool IsRunePrideEnable() => new bool();

    [Token(Token = "0x6006F02")]
    [Address(RVA = "0x367550", Offset = "0x366350", VA = "0x10367550")]
    public bool IsLeagueMatchMatchingTime() => new bool();

    [Token(Token = "0x6006F03")]
    [Address(RVA = "0x367930", Offset = "0x366730", VA = "0x10367930")]
    public FixParam()
    {
    }
  }
}
