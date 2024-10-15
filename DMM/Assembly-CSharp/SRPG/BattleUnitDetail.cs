// Decompiled with JetBrains decompiler
// Type: SRPG.BattleUnitDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E14")]
  [AddComponentMenu("Battle/UnitDetail/BattleUnitDetail")]
  public class BattleUnitDetail : MonoBehaviour
  {
    [Token(Token = "0x4002A6D")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    public GameObject GoLeaderSkill;
    [Token(Token = "0x4002A6E")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GoLeaderSkillBadge;
    [Token(Token = "0x4002A6F")]
    [FieldOffset(Offset = "0x14")]
    [Space(5f)]
    public GameObject GoLeader2Skill;
    [Token(Token = "0x4002A70")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    public GameObject GoFriendSkill;
    [Token(Token = "0x4002A71")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ConceptCardLSObj;
    [Token(Token = "0x4002A72")]
    [FieldOffset(Offset = "0x20")]
    public BitmapText ConceptCardLSCoef;
    [Token(Token = "0x4002A73")]
    [FieldOffset(Offset = "0x24")]
    [Space(10f)]
    public GameObject GoStatusParent;
    [Token(Token = "0x4002A74")]
    [FieldOffset(Offset = "0x28")]
    public BattleUnitDetailStatus StatusBaseItem;
    [Token(Token = "0x4002A75")]
    [FieldOffset(Offset = "0x2C")]
    public BattleUnitDetailStatus StatusBaseHpItem;
    [Token(Token = "0x4002A76")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    public GameObject GoElementParent;
    [Token(Token = "0x4002A77")]
    [FieldOffset(Offset = "0x34")]
    public BattleUnitDetailElement ElementBaseItem;
    [Token(Token = "0x4002A78")]
    [FieldOffset(Offset = "0x38")]
    [Space(10f)]
    public GameObject GoTagParent;
    [Token(Token = "0x4002A79")]
    [FieldOffset(Offset = "0x3C")]
    public BattleUnitDetailTag TagBaseItem;
    [Token(Token = "0x4002A7A")]
    [FieldOffset(Offset = "0x40")]
    public BattleUnitDetailTag TagBaseWideItem;
    [Token(Token = "0x4002A7B")]
    private const int TAG_BOUNDARY_LEN = 2;
    [Token(Token = "0x4002A7C")]
    private const int TAG_ENTRY_GRID_BASE = 1;
    [Token(Token = "0x4002A7D")]
    private const int TAG_ENTRY_GRID_WIDE = 2;
    [Token(Token = "0x4002A7E")]
    private const int TAG_ENTRY_GRID_MAX = 8;
    [Token(Token = "0x4002A7F")]
    [FieldOffset(Offset = "0x44")]
    [Space(10f)]
    public GameObject GoAtkDetailParent;
    [Token(Token = "0x4002A80")]
    [FieldOffset(Offset = "0x48")]
    public BattleUnitDetailAtkDetail AtkDetailBaseItem;
    [Token(Token = "0x4002A81")]
    [FieldOffset(Offset = "0x4C")]
    [Space(10f)]
    public GameObject GoCondParent;
    [Token(Token = "0x4002A82")]
    [FieldOffset(Offset = "0x50")]
    public BattleUnitDetailCond CondBaseItem;
    [Token(Token = "0x4002A83")]
    [FieldOffset(Offset = "0x54")]
    private SceneBattle mSb;
    [Token(Token = "0x4002A84")]
    [FieldOffset(Offset = "0x58")]
    private BattleCore mBc;
    [Token(Token = "0x4002A85")]
    [FieldOffset(Offset = "0x5C")]
    private TargetPlate mTargetSub;
    [Token(Token = "0x4002A86")]
    [FieldOffset(Offset = "0x60")]
    private TowerFloorParam mTF_Param;
    [Token(Token = "0x4002A87")]
    [FieldOffset(Offset = "0x0")]
    private static BattleUnitDetail mInstance;
    [Token(Token = "0x4002A88")]
    [FieldOffset(Offset = "0x4")]
    private static int[][] mFluctValues;

    [Token(Token = "0x17000425")]
    private TowerFloorParam TF_Param
    {
      [Token(Token = "0x6003A0A"), Address(RVA = "0x10B78E0", Offset = "0x10B66E0", VA = "0x110B78E0")] get
      {
        return (TowerFloorParam) null;
      }
    }

    [Token(Token = "0x17000426")]
    public static BattleUnitDetail Instance
    {
      [Token(Token = "0x6003A0B"), Address(RVA = "0x10B78A0", Offset = "0x10B66A0", VA = "0x110B78A0")] get
      {
        return (BattleUnitDetail) null;
      }
    }

    [Token(Token = "0x6003A0C")]
    [Address(RVA = "0x10B46C0", Offset = "0x10B34C0", VA = "0x110B46C0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6003A0D")]
    [Address(RVA = "0x10B4610", Offset = "0x10B3410", VA = "0x110B4610")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6003A0E")]
    [Address(RVA = "0x10B7110", Offset = "0x10B5F10", VA = "0x110B7110")]
    private void Start()
    {
    }

    [Token(Token = "0x6003A0F")]
    [Address(RVA = "0x10B4000", Offset = "0x10B2E00", VA = "0x110B4000")]
    public static void DestroyChildGameObjects(
      GameObject go_parent,
      List<GameObject> go_ignore_lists = null)
    {
    }

    [Token(Token = "0x6003A10")]
    public static void DestroyChildGameObjects<T>(
      GameObject go_parent,
      List<GameObject> go_ignore_lists = null)
    {
    }

    [Token(Token = "0x6003A11")]
    [Address(RVA = "0x10B4770", Offset = "0x10B3570", VA = "0x110B4770")]
    public void Refresh(Unit unit)
    {
    }

    [Token(Token = "0x6003A12")]
    [Address(RVA = "0x10B3C90", Offset = "0x10B2A90", VA = "0x110B3C90")]
    private void CreateManipulateAtkDetail(List<Unit.UnitManipulate> list)
    {
    }

    [Token(Token = "0x6003A13")]
    [Address(RVA = "0x10B3BD0", Offset = "0x10B29D0", VA = "0x110B3BD0")]
    private void CreateBattleUnitDetailAtkDetail(
      BattleUnitDetailAtkDetail.eAllType type,
      string addMsg)
    {
    }

    [Token(Token = "0x6003A14")]
    [Address(RVA = "0x10B4290", Offset = "0x10B3090", VA = "0x110B4290")]
    private string GetManipulateDamageTypeMsg(DamageTypes dmgType, string msg) => (string) null;

    [Token(Token = "0x6003A15")]
    [Address(RVA = "0x10B43F0", Offset = "0x10B31F0", VA = "0x110B43F0")]
    private string GetManipulateElementTypeMsg(int elem, string msg) => (string) null;

    [Token(Token = "0x6003A16")]
    [Address(RVA = "0x10B41B0", Offset = "0x10B2FB0", VA = "0x110B41B0")]
    public static BattleUnitDetail.eBudFluct ExchgBudFluct(
      int per,
      BattleUnitDetail.eFluctChk fluct_chk = BattleUnitDetail.eFluctChk.DEFAULT)
    {
      return new BattleUnitDetail.eBudFluct();
    }

    [Token(Token = "0x6003A17")]
    [Address(RVA = "0x10B4150", Offset = "0x10B2F50", VA = "0x110B4150")]
    public static BattleUnitDetail.eBudFluct ExchgBudFluct(
      int val,
      int max,
      BattleUnitDetail.eFluctChk fluct_chk = BattleUnitDetail.eFluctChk.DEFAULT)
    {
      return new BattleUnitDetail.eBudFluct();
    }

    [Token(Token = "0x6003A18")]
    [Address(RVA = "0x10B3900", Offset = "0x10B2700", VA = "0x110B3900")]
    private SkillData CheckFriendLeaderSkill(Unit _leader_unit, Unit _friend_unit)
    {
      return (SkillData) null;
    }

    [Token(Token = "0x6003A19")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BattleUnitDetail()
    {
    }

    [Token(Token = "0x6003A1A")]
    [Address(RVA = "0x10B76E0", Offset = "0x10B64E0", VA = "0x110B76E0")]
    static BattleUnitDetail()
    {
    }

    [Token(Token = "0x2000E15")]
    public enum eBudFluct
    {
      [Token(Token = "0x4002A8A")] NONE,
      [Token(Token = "0x4002A8B")] DW_L,
      [Token(Token = "0x4002A8C")] DW_M,
      [Token(Token = "0x4002A8D")] DW_S,
      [Token(Token = "0x4002A8E")] UP_S,
      [Token(Token = "0x4002A8F")] UP_M,
      [Token(Token = "0x4002A90")] UP_L,
    }

    [Token(Token = "0x2000E16")]
    public enum eFluctChk
    {
      [Token(Token = "0x4002A92")] DEFAULT,
      [Token(Token = "0x4002A93")] ELEMENT,
      [Token(Token = "0x4002A94")] ATK_DETAIL,
    }

    [Token(Token = "0x2000E17")]
    private enum eFluctSize
    {
      [Token(Token = "0x4002A96")] VAL_S,
      [Token(Token = "0x4002A97")] VAL_M,
      [Token(Token = "0x4002A98")] VAL_L,
    }
  }
}
