// Decompiled with JetBrains decompiler
// Type: SRPG.BookmarkUnitContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020EC")]
  public class BookmarkUnitContentParam : ContentSource.Param
  {
    [Token(Token = "0x4008E49")]
    [FieldOffset(Offset = "0x10")]
    public ItemParam mItemParam;
    [Token(Token = "0x4008E4A")]
    [FieldOffset(Offset = "0x14")]
    public UnitParam mUnitParam;
    [Token(Token = "0x4008E4B")]
    [FieldOffset(Offset = "0x18")]
    public QuestBookmarkWindow.ItemAndQuest mItemAndQuestParam;
    [Token(Token = "0x4008E4C")]
    [FieldOffset(Offset = "0x1C")]
    public bool isCheck;
    [Token(Token = "0x4008E4D")]
    [FieldOffset(Offset = "0x1D")]
    public bool isAvailable;
    [Token(Token = "0x4008E4E")]
    [FieldOffset(Offset = "0x1E")]
    public bool isCanSkip;
    [Token(Token = "0x4008E4F")]
    [FieldOffset(Offset = "0x20")]
    private BookmarkUnit mNode;

    [Token(Token = "0x600897A")]
    [Address(RVA = "0x4A3CA0", Offset = "0x4A2AA0", VA = "0x104A3CA0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600897B")]
    [Address(RVA = "0x44CFD0", Offset = "0x44BDD0", VA = "0x1044CFD0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600897C")]
    [Address(RVA = "0x4A3DD0", Offset = "0x4A2BD0", VA = "0x104A3DD0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600897D")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public BookmarkUnitContentParam()
    {
    }
  }
}
