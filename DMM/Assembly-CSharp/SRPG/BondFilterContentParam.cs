// Decompiled with JetBrains decompiler
// Type: SRPG.BondFilterContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020A9")]
  public class BondFilterContentParam : ContentSource.Param
  {
    [Token(Token = "0x4008CA4")]
    [FieldOffset(Offset = "0x10")]
    public UnitParam UnitParam;
    [Token(Token = "0x4008CA5")]
    [FieldOffset(Offset = "0x14")]
    public bool IsSelect;
    [Token(Token = "0x4008CA6")]
    [FieldOffset(Offset = "0x18")]
    private BondFilterContentNode mNode;

    [Token(Token = "0x60087E6")]
    [Address(RVA = "0x492EE0", Offset = "0x491CE0", VA = "0x10492EE0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x60087E7")]
    [Address(RVA = "0x492EB0", Offset = "0x491CB0", VA = "0x10492EB0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x60087E8")]
    [Address(RVA = "0x493000", Offset = "0x491E00", VA = "0x10493000")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60087E9")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public BondFilterContentParam()
    {
    }
  }
}
