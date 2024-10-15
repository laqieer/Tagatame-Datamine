// Decompiled with JetBrains decompiler
// Type: SRPG.BondMissionContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020C5")]
  public class BondMissionContentParam : ContentSource.Param
  {
    [Token(Token = "0x4008D76")]
    [FieldOffset(Offset = "0x10")]
    public BondMissionParam BondMissionParam;
    [Token(Token = "0x4008D77")]
    [FieldOffset(Offset = "0x14")]
    private BondMissionContentNode mNode;

    [Token(Token = "0x6008897")]
    [Address(RVA = "0x49CCC0", Offset = "0x49BAC0", VA = "0x1049CCC0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6008898")]
    [Address(RVA = "0x490820", Offset = "0x48F620", VA = "0x10490820", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6008899")]
    [Address(RVA = "0x49CD80", Offset = "0x49BB80", VA = "0x1049CD80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600889A")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public BondMissionContentParam()
    {
    }
  }
}
