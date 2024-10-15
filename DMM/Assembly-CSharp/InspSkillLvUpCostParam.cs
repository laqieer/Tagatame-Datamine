// Decompiled with JetBrains decompiler
// Type: InspSkillLvUpCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000279")]
public class InspSkillLvUpCostParam
{
  [Token(Token = "0x4000A69")]
  [FieldOffset(Offset = "0x8")]
  public int id;
  [Token(Token = "0x4000A6A")]
  [FieldOffset(Offset = "0xC")]
  public List<InspSkillLvUpCostParam.Cost> costs;

  [Token(Token = "0x6000D57")]
  [Address(RVA = "0x11D2D30", Offset = "0x11D1B30", VA = "0x111D2D30")]
  public static void Desirialize(
    JSON_InspSkillLvUpCostParam[] json,
    ref List<InspSkillLvUpCostParam> cost_params)
  {
  }

  [Token(Token = "0x6000D58")]
  [Address(RVA = "0x11D2F40", Offset = "0x11D1D40", VA = "0x111D2F40")]
  public InspSkillLvUpCostParam()
  {
  }

  [Token(Token = "0x200027A")]
  public class Cost
  {
    [Token(Token = "0x4000A6B")]
    [FieldOffset(Offset = "0x8")]
    public int gold;

    [Token(Token = "0x6000D59")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Cost()
    {
    }
  }
}
