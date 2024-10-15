// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBookItemRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F75")]
  public class AdventureBookItemRewardParam : ContentSource.Param
  {
    [Token(Token = "0x40084D7")]
    [FieldOffset(Offset = "0x10")]
    public AdventureBook.Item BookItem;
    [Token(Token = "0x40084D8")]
    [FieldOffset(Offset = "0x14")]
    public bool IsOpen;
    [Token(Token = "0x40084D9")]
    [FieldOffset(Offset = "0x15")]
    public bool IsAnim;
    [Token(Token = "0x40084DA")]
    [FieldOffset(Offset = "0x18")]
    private AdventureBookItemRewardNode mNode;

    [Token(Token = "0x1700128A")]
    public AdventureBookItemRewardNode Node
    {
      [Token(Token = "0x600813B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (AdventureBookItemRewardNode) null;
      }
    }

    [Token(Token = "0x600813C")]
    [Address(RVA = "0x41BE00", Offset = "0x41AC00", VA = "0x1041BE00", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600813D")]
    [Address(RVA = "0x41BDD0", Offset = "0x41ABD0", VA = "0x1041BDD0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600813E")]
    [Address(RVA = "0x41BF20", Offset = "0x41AD20", VA = "0x1041BF20")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600813F")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public AdventureBookItemRewardParam()
    {
    }
  }
}
