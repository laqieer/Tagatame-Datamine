// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_UnitLv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA1")]
  public class ConditionsResult_UnitLv : ConditionsResult_Unit
  {
    [Token(Token = "0x4002CEC")]
    [FieldOffset(Offset = "0x1C")]
    public int mCondsLv;

    [Token(Token = "0x170004C9")]
    public override string text
    {
      [Token(Token = "0x6003CE8"), Address(RVA = "0x10F4A10", Offset = "0x10F3810", VA = "0x110F4A10", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004CA")]
    public override string errorText
    {
      [Token(Token = "0x6003CE9"), Address(RVA = "0x10F4900", Offset = "0x10F3700", VA = "0x110F4900", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003CEA")]
    [Address(RVA = "0x10F4890", Offset = "0x10F3690", VA = "0x110F4890")]
    public ConditionsResult_UnitLv(UnitData unitData, UnitParam unitParam, int condsLv)
    {
    }
  }
}
