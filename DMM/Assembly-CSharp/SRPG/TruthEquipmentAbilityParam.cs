// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentAbilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DAC")]
  [MessagePackObject(true)]
  [Serializable]
  public class TruthEquipmentAbilityParam
  {
    [Token(Token = "0x17001058")]
    public string Iname
    {
      [Token(Token = "0x6007960"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007961"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001059")]
    public eTruthEquipmentLearnType LearnType
    {
      [Token(Token = "0x6007962"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new eTruthEquipmentLearnType();
      }
      [Token(Token = "0x6007963"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700105A")]
    public string AbilityID
    {
      [Token(Token = "0x6007964"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007965"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x1700105B")]
    public string OverwriteAbilityID
    {
      [Token(Token = "0x6007966"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007967"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x6007968")]
    [Address(RVA = "0x3C0480", Offset = "0x3BF280", VA = "0x103C0480")]
    public void Deserialize(JSON_TruthEquipmentAbilityParam json)
    {
    }

    [Token(Token = "0x6007969")]
    [Address(RVA = "0x3C0310", Offset = "0x3BF110", VA = "0x103C0310")]
    public static void Deserialize(
      ref ParamDictionary<string, TruthEquipmentAbilityParam> dict,
      JSON_TruthEquipmentAbilityParam[] json)
    {
    }

    [Token(Token = "0x600796A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TruthEquipmentAbilityParam()
    {
    }
  }
}
