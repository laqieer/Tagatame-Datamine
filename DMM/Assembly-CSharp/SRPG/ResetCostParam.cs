// Decompiled with JetBrains decompiler
// Type: SRPG.ResetCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CB0")]
  public class ResetCostParam
  {
    [Token(Token = "0x40070A3")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40070A4")]
    [FieldOffset(Offset = "0xC")]
    private List<ResetCostInfoParam> cost;

    [Token(Token = "0x17000F4E")]
    public string Iname
    {
      [Token(Token = "0x600761B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F4F")]
    public List<ResetCostInfoParam> Cost
    {
      [Token(Token = "0x600761C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<ResetCostInfoParam>) null;
      }
    }

    [Token(Token = "0x600761D")]
    [Address(RVA = "0x396B30", Offset = "0x395930", VA = "0x10396B30")]
    public void Deserialize(JSON_ResetCostParam json)
    {
    }

    [Token(Token = "0x600761E")]
    [Address(RVA = "0x396DC0", Offset = "0x395BC0", VA = "0x10396DC0")]
    public static void Deserialize(
      ref Dictionary<string, ResetCostParam> param,
      JSON_ResetCostParam[] json)
    {
    }

    [Token(Token = "0x600761F")]
    [Address(RVA = "0x396F10", Offset = "0x395D10", VA = "0x10396F10")]
    public ResetCostInfoParam GetResetCostInfo(eResetCostType cost_type)
    {
      return (ResetCostInfoParam) null;
    }

    [Token(Token = "0x6007620")]
    [Address(RVA = "0x396FC0", Offset = "0x395DC0", VA = "0x10396FC0")]
    public bool IsEnableCoinCost() => new bool();

    [Token(Token = "0x6007621")]
    [Address(RVA = "0x397010", Offset = "0x395E10", VA = "0x10397010")]
    public bool IsEnableItemCost() => new bool();

    [Token(Token = "0x6007622")]
    [Address(RVA = "0x3970A0", Offset = "0x395EA0", VA = "0x103970A0")]
    public ResetCostParam()
    {
    }
  }
}
