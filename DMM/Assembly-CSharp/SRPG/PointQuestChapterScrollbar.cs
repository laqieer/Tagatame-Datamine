// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestChapterScrollbar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002805")]
  public class PointQuestChapterScrollbar : Scrollbar
  {
    [Token(Token = "0x400BE75")]
    [FieldOffset(Offset = "0xE0")]
    public PointQuestChapterScrollRect ChapterScrollRect;

    [Token(Token = "0x600B4AF")]
    [Address(RVA = "0x7B2EC0", Offset = "0x7B1CC0", VA = "0x107B2EC0", Slot = "33")]
    public override void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B4B0")]
    [Address(RVA = "0x7B2F40", Offset = "0x7B1D40", VA = "0x107B2F40")]
    public PointQuestChapterScrollbar()
    {
    }
  }
}
