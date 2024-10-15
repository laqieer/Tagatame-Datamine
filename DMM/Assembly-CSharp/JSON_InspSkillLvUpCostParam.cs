// Decompiled with JetBrains decompiler
// Type: JSON_InspSkillLvUpCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
[Token(Token = "0x2000277")]
[MessagePackObject(true)]
[Serializable]
public class JSON_InspSkillLvUpCostParam
{
  [Token(Token = "0x4000A66")]
  [FieldOffset(Offset = "0x8")]
  public int id;
  [Token(Token = "0x4000A67")]
  [FieldOffset(Offset = "0xC")]
  public JSON_InspSkillLvUpCostParam.JSON_CostData[] costs;

  [Token(Token = "0x6000D55")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public JSON_InspSkillLvUpCostParam()
  {
  }

  [Token(Token = "0x2000278")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CostData
  {
    [Token(Token = "0x4000A68")]
    [FieldOffset(Offset = "0x8")]
    public int gold;

    [Token(Token = "0x6000D56")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CostData()
    {
    }
  }
}
