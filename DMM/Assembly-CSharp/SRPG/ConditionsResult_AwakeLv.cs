// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_AwakeLv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA2")]
  public class ConditionsResult_AwakeLv : ConditionsResult_Unit
  {
    [Token(Token = "0x4002CED")]
    [FieldOffset(Offset = "0x1C")]
    public int mCondsAwakeLv;

    [Token(Token = "0x170004CB")]
    public override string text
    {
      [Token(Token = "0x6003CEB"), Address(RVA = "0x10F3270", Offset = "0x10F2070", VA = "0x110F3270", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004CC")]
    public override string errorText
    {
      [Token(Token = "0x6003CEC"), Address(RVA = "0x10F31E0", Offset = "0x10F1FE0", VA = "0x110F31E0", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003CED")]
    [Address(RVA = "0x10F3170", Offset = "0x10F1F70", VA = "0x110F3170")]
    public ConditionsResult_AwakeLv(UnitData unitData, UnitParam unitParam, int condsAwakeLv)
    {
    }
  }
}
