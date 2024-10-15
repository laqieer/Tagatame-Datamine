// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentParam
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
  [Token(Token = "0x2001DB0")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentParam
  {
    [Token(Token = "0x17001061")]
    public string Iname
    {
      [Token(Token = "0x6007978"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007979"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001062")]
    public string Name
    {
      [Token(Token = "0x600797A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600797B"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001063")]
    public string IconName
    {
      [Token(Token = "0x600797C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600797D"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001064")]
    public bool Enable
    {
      [Token(Token = "0x600797E"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600797F"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x17001065")]
    public TruthEquipmentLvEffectParam[] LvEffects
    {
      [Token(Token = "0x6007980"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (TruthEquipmentLvEffectParam[]) null;
      }
      [Token(Token = "0x6007981"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001066")]
    [IgnoreMember]
    public string IconPath
    {
      [Token(Token = "0x6007982"), Address(RVA = "0x3C1A80", Offset = "0x3C0880", VA = "0x103C1A80")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001067")]
    [IgnoreMember]
    public int MaxLv
    {
      [Token(Token = "0x6007983"), Address(RVA = "0x3C1AD0", Offset = "0x3C08D0", VA = "0x103C1AD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007984")]
    [Address(RVA = "0x3C0B80", Offset = "0x3BF980", VA = "0x103C0B80")]
    public void Deserialize(JSON_TruthEquipmentParam json)
    {
    }

    [Token(Token = "0x6007985")]
    [Address(RVA = "0x3C0A50", Offset = "0x3BF850", VA = "0x103C0A50")]
    public static void Deserialize(
      ref ParamDictionary<string, TruthEquipmentParam> dict,
      JSON_TruthEquipmentParam[] json)
    {
    }

    [Token(Token = "0x6007986")]
    [Address(RVA = "0x3C12F0", Offset = "0x3C00F0", VA = "0x103C12F0")]
    public void GetRecipeWithRange(
      int startLv,
      int endLv,
      ref int totalZenny,
      ref Dictionary<string, int> totalItems)
    {
    }

    [Token(Token = "0x6007987")]
    [Address(RVA = "0x3C06C0", Offset = "0x3BF4C0", VA = "0x103C06C0")]
    public void CalcBaseStatus(
      int lv,
      ref BaseStatus add,
      ref BaseStatus scale,
      EElement element,
      bool isDrawBaseStatus = false)
    {
    }

    [Token(Token = "0x6007988")]
    [Address(RVA = "0x3C06A0", Offset = "0x3BF4A0", VA = "0x103C06A0")]
    public void CalcBaseStatusForDisplay(
      int lv,
      ref BaseStatus add,
      ref BaseStatus scale,
      EElement element)
    {
    }

    [Token(Token = "0x6007989")]
    [Address(RVA = "0x3C08A0", Offset = "0x3BF6A0", VA = "0x103C08A0")]
    public void CalcLevelStatus(
      int lv,
      ref BaseStatus add,
      ref BaseStatus scale,
      EElement element,
      bool isDrawBaseStatus = false)
    {
    }

    [Token(Token = "0x600798A")]
    [Address(RVA = "0x3C1100", Offset = "0x3BFF00", VA = "0x103C1100")]
    public List<AbilityData> GetLearnedAbility(int lv, bool ignore_overwrite = false)
    {
      return (List<AbilityData>) null;
    }

    [Token(Token = "0x600798B")]
    [Address(RVA = "0x3C0D40", Offset = "0x3BFB40", VA = "0x103C0D40")]
    public List<AbilityData> ExcludeBaseAbility(
      List<TruthEquipmentAbilityParam> equipmentAbilityList,
      bool ignore_overwrite = false)
    {
      return (List<AbilityData>) null;
    }

    [Token(Token = "0x600798C")]
    [Address(RVA = "0x3C15D0", Offset = "0x3C03D0", VA = "0x103C15D0")]
    public List<ViewTruthEquipmentLearnAbility> GetViewLearnAbility(int lv)
    {
      return (List<ViewTruthEquipmentLearnAbility>) null;
    }

    [Token(Token = "0x600798D")]
    [Address(RVA = "0x3C1880", Offset = "0x3C0680", VA = "0x103C1880")]
    public bool IsGetAbility(int startLv, int endLv) => new bool();

    [Token(Token = "0x600798E")]
    [Address(RVA = "0x3C1980", Offset = "0x3C0780", VA = "0x103C1980")]
    public bool IsOverwriteAbility(int startLv, int endLv) => new bool();

    [Token(Token = "0x600798F")]
    [Address(RVA = "0x3C0F60", Offset = "0x3BFD60", VA = "0x103C0F60")]
    private List<TruthEquipmentAbilityParam> GetAbilityParamList(int startLv, int endLv)
    {
      return (List<TruthEquipmentAbilityParam>) null;
    }

    [Token(Token = "0x6007990")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentParam()
    {
    }
  }
}
