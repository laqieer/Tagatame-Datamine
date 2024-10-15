// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200227D")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalData
  {
    [Token(Token = "0x400990F")]
    public const int SUB_CRYSTAL_REFRATE_MAX = 100;
    [Token(Token = "0x4009910")]
    [FieldOffset(Offset = "0x8")]
    private long mIid;
    [Token(Token = "0x4009911")]
    [FieldOffset(Offset = "0x10")]
    private int mRank;
    [Token(Token = "0x4009912")]
    [FieldOffset(Offset = "0x14")]
    private int mPlus;
    [Token(Token = "0x4009913")]
    [FieldOffset(Offset = "0x18")]
    private CrystalData.ESlotIndex mSlot;
    [Token(Token = "0x4009914")]
    [FieldOffset(Offset = "0x1C")]
    private int mFavorite;
    [Token(Token = "0x4009915")]
    [FieldOffset(Offset = "0x20")]
    private CrystalParam mCrystalParam;
    [Token(Token = "0x4009916")]
    [FieldOffset(Offset = "0x24")]
    private SkillData mEquipEffectSkill;
    [Token(Token = "0x4009917")]
    [FieldOffset(Offset = "0x28")]
    private int[] mCrystalSubSlotRefRate;
    [Token(Token = "0x4009918")]
    [FieldOffset(Offset = "0x2C")]
    private int[] CrystalSetBonusRefRate;
    [Token(Token = "0x4009919")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsDummy;

    [Token(Token = "0x170014A8")]
    public long Iid
    {
      [Token(Token = "0x6009342"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170014A9")]
    public int Rank
    {
      [Token(Token = "0x6009343"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170014AA")]
    public int Plus
    {
      [Token(Token = "0x6009344"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170014AB")]
    public CrystalData.ESlotIndex Slot
    {
      [Token(Token = "0x6009345"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new CrystalData.ESlotIndex();
      }
    }

    [Token(Token = "0x170014AC")]
    public int Favorite
    {
      [Token(Token = "0x6009346"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170014AD")]
    public CrystalParam GetCrystalParam
    {
      [Token(Token = "0x6009347"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (CrystalParam) null;
      }
    }

    [Token(Token = "0x170014AE")]
    public SkillData EquipEffectSkill
    {
      [Token(Token = "0x6009348"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x170014AF")]
    public bool IsMainSlotEquip
    {
      [Token(Token = "0x6009349"), Address(RVA = "0x26D070", Offset = "0x26BE70", VA = "0x1026D070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170014B0")]
    public bool IsFavorite
    {
      [Token(Token = "0x600934A"), Address(RVA = "0x568220", Offset = "0x567020", VA = "0x10568220")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170014B1")]
    public bool IsEquip
    {
      [Token(Token = "0x600934B"), Address(RVA = "0x3B3010", Offset = "0x3B1E10", VA = "0x103B3010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170014B2")]
    [IgnoreMember]
    public bool IsDummy
    {
      [Token(Token = "0x600934C"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600934D"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] set
      {
      }
    }

    [Token(Token = "0x170014B3")]
    public bool IsSaleEnable
    {
      [Token(Token = "0x600934E"), Address(RVA = "0x568230", Offset = "0x567030", VA = "0x10568230")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170014B4")]
    public bool IsEquipAny
    {
      [Token(Token = "0x600934F"), Address(RVA = "0x5681F0", Offset = "0x566FF0", VA = "0x105681F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170014B5")]
    public bool IsUsed
    {
      [Token(Token = "0x6009350"), Address(RVA = "0x568280", Offset = "0x567080", VA = "0x10568280")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009351")]
    [Address(RVA = "0x566D80", Offset = "0x565B80", VA = "0x10566D80")]
    public bool Deserialize(JSON_CrystalData json) => new bool();

    [Token(Token = "0x6009352")]
    [Address(RVA = "0x567FA0", Offset = "0x566DA0", VA = "0x10567FA0")]
    public JSON_CrystalData Serialize() => (JSON_CrystalData) null;

    [Token(Token = "0x6009353")]
    [Address(RVA = "0x568030", Offset = "0x566E30", VA = "0x10568030")]
    public void SetDummyData(CrystalData _data)
    {
    }

    [Token(Token = "0x6009354")]
    [Address(RVA = "0x5668F0", Offset = "0x5656F0", VA = "0x105668F0")]
    public CrystalData Clone(CrystalData.ESlotIndex slot) => (CrystalData) null;

    [Token(Token = "0x6009355")]
    [Address(RVA = "0x5680A0", Offset = "0x566EA0", VA = "0x105680A0")]
    private void UpdateEquipmentSkillData()
    {
    }

    [Token(Token = "0x6009356")]
    [Address(RVA = "0x567530", Offset = "0x566330", VA = "0x10567530")]
    public void GetStatus(
      ref BaseStatus fixed_status,
      ref BaseStatus scale_status,
      UnitData _unit_data = null)
    {
    }

    [Token(Token = "0x6009357")]
    [Address(RVA = "0x566EA0", Offset = "0x565CA0", VA = "0x10566EA0")]
    public List<CrystalAddLimitStatus> GetAddLimitStatusList()
    {
      return (List<CrystalAddLimitStatus>) null;
    }

    [Token(Token = "0x6009358")]
    [Address(RVA = "0x567030", Offset = "0x565E30", VA = "0x10567030")]
    public UnitData GetOwner(bool _is_include_over_write = false) => (UnitData) null;

    [Token(Token = "0x6009359")]
    [Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")]
    public void SetSlot(CrystalData.ESlotIndex _index)
    {
    }

    [Token(Token = "0x600935A")]
    [Address(RVA = "0x567810", Offset = "0x566610", VA = "0x10567810")]
    public static bool IsMainSlot(int crystalSlotIndex) => new bool();

    [Token(Token = "0x600935B")]
    [Address(RVA = "0x567280", Offset = "0x566080", VA = "0x10567280")]
    public void GetSortData(
      CrystalSortCondParam _param,
      bool _is_ascending,
      out List<long> _sort_value_list,
      out string _sort_name)
    {
    }

    [Token(Token = "0x600935C")]
    [Address(RVA = "0x5667B0", Offset = "0x5655B0", VA = "0x105667B0")]
    private int CheckHasStatus(
      BaseStatus _status,
      ParamTypes _target_param,
      string _tag_name,
      bool _is_ascending)
    {
      return new int();
    }

    [Token(Token = "0x600935D")]
    [Address(RVA = "0x5665F0", Offset = "0x5653F0", VA = "0x105665F0")]
    private int CheckHasAddParamLimit(
      ParamTypes _target_param,
      string _tag_name,
      bool _is_ascending)
    {
      return new int();
    }

    [Token(Token = "0x600935E")]
    [Address(RVA = "0x567600", Offset = "0x566400", VA = "0x10567600")]
    public int GetTargetAddParamLimit(ParamTypes _target_param, string _tag_name) => new int();

    [Token(Token = "0x600935F")]
    [Address(RVA = "0x567CA0", Offset = "0x566AA0", VA = "0x10567CA0")]
    public bool IsSetBonusTarget(string _main_iname) => new bool();

    [Token(Token = "0x6009360")]
    [Address(RVA = "0x567820", Offset = "0x566620", VA = "0x10567820")]
    public bool IsSetBonusMainCrystal(List<CrystalData> _crystal_datas) => new bool();

    [Token(Token = "0x6009361")]
    [Address(RVA = "0x566300", Offset = "0x565100", VA = "0x10566300")]
    public void CalcSaleResult(ref int GoldNum, ref int CoinNum)
    {
    }

    [Token(Token = "0x6009362")]
    [Address(RVA = "0x566A50", Offset = "0x565850", VA = "0x10566A50")]
    public static CrystalData CreateCrystalDataForDisplay(string iname, int rank = -1, long iid = 1)
    {
      return (CrystalData) null;
    }

    [Token(Token = "0x6009363")]
    [Address(RVA = "0x566960", Offset = "0x565760", VA = "0x10566960")]
    public static CrystalData CreateCrystalDataForDisplay(
      CrystalParam crystalParam,
      int rank = -1,
      long iid = 1)
    {
      return (CrystalData) null;
    }

    [Token(Token = "0x6009364")]
    [Address(RVA = "0x566BA0", Offset = "0x5659A0", VA = "0x10566BA0")]
    public static List<long> CreateCrystalIdList(UnitData _unit) => (List<long>) null;

    [Token(Token = "0x6009365")]
    [Address(RVA = "0x5677B0", Offset = "0x5665B0", VA = "0x105677B0")]
    public bool IsGradeUpConditions(CrystalData _data) => new bool();

    [Token(Token = "0x6009366")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalData()
    {
    }

    [Token(Token = "0x200227E")]
    public enum ESlotIndex
    {
      [Token(Token = "0x400991B")] NONE,
      [Token(Token = "0x400991C")] SLOT1,
      [Token(Token = "0x400991D")] SLOT2,
      [Token(Token = "0x400991E")] SLOT3,
      [Token(Token = "0x400991F")] SLOT4,
      [Token(Token = "0x4009920")] SLOT5,
      [Token(Token = "0x4009921")] SLOT6,
      [Token(Token = "0x4009922")] MAX,
    }
  }
}
