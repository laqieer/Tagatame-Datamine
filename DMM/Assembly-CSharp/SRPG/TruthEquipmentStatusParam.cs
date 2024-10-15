// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentStatusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DBA")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentStatusParam
  {
    [Token(Token = "0x17001070")]
    public string Iname
    {
      [Token(Token = "0x60079B1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60079B2"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001071")]
    public TruthEquipmentStatusEffectParam[] Effects
    {
      [Token(Token = "0x60079B3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (TruthEquipmentStatusEffectParam[]) null;
      }
      [Token(Token = "0x60079B4"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60079B5")]
    [Address(RVA = "0x3C21C0", Offset = "0x3C0FC0", VA = "0x103C21C0")]
    public void Deserialize(JSON_TruthEquipmentStatusParam json)
    {
    }

    [Token(Token = "0x60079B6")]
    [Address(RVA = "0x3C1F40", Offset = "0x3C0D40", VA = "0x103C1F40")]
    public static void Deserialize(
      ref ParamDictionary<string, TruthEquipmentStatusParam> dict,
      JSON_TruthEquipmentStatusParam[] json)
    {
    }

    [Token(Token = "0x60079B7")]
    [Address(RVA = "0x3C1DE0", Offset = "0x3C0BE0", VA = "0x103C1DE0")]
    public void AddStatus(
      ref BaseStatus add,
      ref BaseStatus scale,
      EElement element,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60079B8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentStatusParam()
    {
    }
  }
}
