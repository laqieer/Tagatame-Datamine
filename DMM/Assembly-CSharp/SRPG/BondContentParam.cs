// Decompiled with JetBrains decompiler
// Type: SRPG.BondContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002090")]
  public class BondContentParam : ContentSource.Param
  {
    [Token(Token = "0x4008C65")]
    [FieldOffset(Offset = "0x10")]
    public BondGroupParam mBondGroupParam;
    [Token(Token = "0x4008C66")]
    [FieldOffset(Offset = "0x14")]
    private BondContentNode mNode;

    [Token(Token = "0x6008794")]
    [Address(RVA = "0x490850", Offset = "0x48F650", VA = "0x10490850", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6008795")]
    [Address(RVA = "0x490820", Offset = "0x48F620", VA = "0x10490820", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6008796")]
    [Address(RVA = "0x490910", Offset = "0x48F710", VA = "0x10490910")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008797")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public BondContentParam()
    {
    }
  }
}
