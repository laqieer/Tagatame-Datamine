// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_Unit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA0")]
  public abstract class ConditionsResult_Unit : ConditionsResult
  {
    [Token(Token = "0x4002CEA")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mUnitData;
    [Token(Token = "0x4002CEB")]
    [FieldOffset(Offset = "0x18")]
    private UnitParam mUnitParam;

    [Token(Token = "0x170004C6")]
    public UnitData unitData
    {
      [Token(Token = "0x6003CE4"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x170004C7")]
    public bool hasUnitData
    {
      [Token(Token = "0x6003CE5"), Address(RVA = "0x3683C0", Offset = "0x3671C0", VA = "0x103683C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004C8")]
    public string unitName
    {
      [Token(Token = "0x6003CE6"), Address(RVA = "0x10F4BC0", Offset = "0x10F39C0", VA = "0x110F4BC0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003CE7")]
    [Address(RVA = "0x10F4B80", Offset = "0x10F3980", VA = "0x110F4B80")]
    public ConditionsResult_Unit(UnitData unitData, UnitParam unitParam)
    {
    }
  }
}
