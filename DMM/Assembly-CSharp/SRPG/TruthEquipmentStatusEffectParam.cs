// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentStatusEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DB9")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentStatusEffectParam
  {
    [Token(Token = "0x1700106D")]
    public ParamTypes Type
    {
      [Token(Token = "0x60079A9"), Address(RVA = "0x357AF0", Offset = "0x3568F0", VA = "0x10357AF0")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x60079AA"), Address(RVA = "0x357B10", Offset = "0x356910", VA = "0x10357B10")] private set
      {
      }
    }

    [Token(Token = "0x1700106E")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x60079AB"), Address(RVA = "0x34B070", Offset = "0x349E70", VA = "0x1034B070")] get
      {
        return new SkillParamCalcTypes();
      }
      [Token(Token = "0x60079AC"), Address(RVA = "0x3C1DD0", Offset = "0x3C0BD0", VA = "0x103C1DD0")] private set
      {
      }
    }

    [Token(Token = "0x1700106F")]
    public int Value
    {
      [Token(Token = "0x60079AD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60079AE"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x60079AF")]
    [Address(RVA = "0x3C1DA0", Offset = "0x3C0BA0", VA = "0x103C1DA0")]
    public void Deserialize(JSON_TruthEquipmentStatusEffectParam json)
    {
    }

    [Token(Token = "0x60079B0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentStatusEffectParam()
    {
    }
  }
}
