// Decompiled with JetBrains decompiler
// Type: SRPG.RuneIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029AA")]
  public class RuneIconParam : ContentSource.Param
  {
    [Token(Token = "0x400C9E2")]
    [FieldOffset(Offset = "0x10")]
    public BindRuneData mRune;
    [Token(Token = "0x400C9E3")]
    [FieldOffset(Offset = "0x14")]
    private RuneIconNode mNode;

    [Token(Token = "0x600BD2C")]
    [Address(RVA = "0x84C240", Offset = "0x84B040", VA = "0x1084C240", Slot = "11")]
    public override void OnSetup(ContentNode node)
    {
    }

    [Token(Token = "0x600BD2D")]
    [Address(RVA = "0x84C1D0", Offset = "0x84AFD0", VA = "0x1084C1D0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600BD2E")]
    [Address(RVA = "0x490820", Offset = "0x48F620", VA = "0x10490820", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600BD2F")]
    [Address(RVA = "0x84C2B0", Offset = "0x84B0B0", VA = "0x1084C2B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BD30")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public RuneIconParam()
    {
    }
  }
}
