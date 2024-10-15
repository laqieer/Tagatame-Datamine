// Decompiled with JetBrains decompiler
// Type: SRPG.ContentScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200225B")]
  public class ContentScroller : SRPG_ScrollRect
  {
    [Token(Token = "0x40098BA")]
    [FieldOffset(Offset = "0x124")]
    private ContentController mContentController;

    [Token(Token = "0x170014A0")]
    public ContentController contentController
    {
      [Token(Token = "0x60092D3"), Address(RVA = "0x563370", Offset = "0x562170", VA = "0x10563370")] get
      {
        return (ContentController) null;
      }
    }

    [Token(Token = "0x60092D4")]
    [Address(RVA = "0x563260", Offset = "0x562060", VA = "0x10563260", Slot = "48")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x60092D5")]
    [Address(RVA = "0x563360", Offset = "0x562160", VA = "0x10563360")]
    public ContentScroller()
    {
    }
  }
}
