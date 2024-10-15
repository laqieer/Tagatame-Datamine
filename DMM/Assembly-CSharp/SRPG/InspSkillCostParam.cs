// Decompiled with JetBrains decompiler
// Type: SRPG.InspSkillCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BA3")]
  public class InspSkillCostParam
  {
    [Token(Token = "0x4006964")]
    [FieldOffset(Offset = "0x8")]
    private InspSkillCostType cost_type;
    [Token(Token = "0x4006965")]
    [FieldOffset(Offset = "0xC")]
    private int num;

    [Token(Token = "0x17000DD7")]
    public InspSkillCostType Type
    {
      [Token(Token = "0x600721F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new InspSkillCostType();
      }
    }

    [Token(Token = "0x17000DD8")]
    public int Num
    {
      [Token(Token = "0x6007220"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007221")]
    [Address(RVA = "0x376260", Offset = "0x375060", VA = "0x10376260")]
    public bool Deserialize(JSON_InspSkillCostParam json) => new bool();

    [Token(Token = "0x6007222")]
    [Address(RVA = "0x376100", Offset = "0x374F00", VA = "0x10376100")]
    public static bool Deserialize(
      JSON_InspSkillCostParam[] json,
      ref Dictionary<int, InspSkillCostParam> cost_param_dict)
    {
      return new bool();
    }

    [Token(Token = "0x6007223")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public InspSkillCostParam()
    {
    }
  }
}
