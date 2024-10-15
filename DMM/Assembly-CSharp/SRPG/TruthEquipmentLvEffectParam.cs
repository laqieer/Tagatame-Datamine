// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentLvEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DAF")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentLvEffectParam
  {
    [Token(Token = "0x4007640")]
    [FieldOffset(Offset = "0x14")]
    private TruthEquipmentRecipeParam m_RecipeParam;
    [Token(Token = "0x4007641")]
    [FieldOffset(Offset = "0x18")]
    private TruthEquipmentStatusParam m_StatusParam;

    [Token(Token = "0x1700105C")]
    public string RecipeID
    {
      [Token(Token = "0x600796D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600796E"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700105D")]
    public string StatusID
    {
      [Token(Token = "0x600796F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007970"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x1700105E")]
    public string LearnAbilityID
    {
      [Token(Token = "0x6007971"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007972"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x1700105F")]
    [IgnoreMember]
    public TruthEquipmentRecipeParam RecipeParam
    {
      [Token(Token = "0x6007973"), Address(RVA = "0x3C0540", Offset = "0x3BF340", VA = "0x103C0540")] get
      {
        return (TruthEquipmentRecipeParam) null;
      }
    }

    [Token(Token = "0x17001060")]
    [IgnoreMember]
    public TruthEquipmentStatusParam StatusParam
    {
      [Token(Token = "0x6007974"), Address(RVA = "0x3C05F0", Offset = "0x3BF3F0", VA = "0x103C05F0")] get
      {
        return (TruthEquipmentStatusParam) null;
      }
    }

    [Token(Token = "0x6007975")]
    [Address(RVA = "0x3C04F0", Offset = "0x3BF2F0", VA = "0x103C04F0")]
    public void Deserialize(JSON_TruthEquipmentLvEffectParam json)
    {
    }

    [Token(Token = "0x6007976")]
    [Address(RVA = "0x3C04D0", Offset = "0x3BF2D0", VA = "0x103C04D0")]
    public void AddStatus(
      ref BaseStatus add,
      ref BaseStatus scale,
      EElement element,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x6007977")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentLvEffectParam()
    {
    }
  }
}
