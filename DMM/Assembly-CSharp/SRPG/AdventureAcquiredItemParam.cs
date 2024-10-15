// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureAcquiredItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F66")]
  public class AdventureAcquiredItemParam : ContentSource.Param
  {
    [Token(Token = "0x400846D")]
    [FieldOffset(Offset = "0x10")]
    public AdventureDrop DropData;
    [Token(Token = "0x400846E")]
    [FieldOffset(Offset = "0x14")]
    private AdventureAcquiredItemNode mNode;

    [Token(Token = "0x60080DB")]
    [Address(RVA = "0x418130", Offset = "0x416F30", VA = "0x10418130", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x60080DC")]
    [Address(RVA = "0x418100", Offset = "0x416F00", VA = "0x10418100", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x60080DD")]
    [Address(RVA = "0x418320", Offset = "0x417120", VA = "0x10418320")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60080DE")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public AdventureAcquiredItemParam()
    {
    }
  }
}
