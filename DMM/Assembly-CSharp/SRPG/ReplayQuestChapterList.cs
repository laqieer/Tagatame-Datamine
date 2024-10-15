// Decompiled with JetBrains decompiler
// Type: SRPG.ReplayQuestChapterList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002943")]
  [FlowNode.Pin(0, "再読み込み", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/ReplayQuestChapterList")]
  [FlowNode.Pin(11, "閲覧可能なストーリーがない", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(10, "閲覧可能なストーリーがある", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(12, "アイテムが選択された", FlowNode.PinTypes.Output, 102)]
  public class ReplayQuestChapterList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C6C5")]
    private const int PIN_ID_REFRESH = 0;
    [Token(Token = "0x400C6C6")]
    private const int PIN_ID_EXIST = 10;
    [Token(Token = "0x400C6C7")]
    private const int PIN_ID_NOT_EXIST = 11;
    [Token(Token = "0x400C6C8")]
    private const int PIN_ID_SELECT = 12;
    [Token(Token = "0x400C6C9")]
    [FieldOffset(Offset = "0xC")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x400C6CA")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemContainer;
    [Token(Token = "0x400C6CB")]
    [FieldOffset(Offset = "0x14")]
    public bool Descending;
    [Token(Token = "0x400C6CC")]
    [FieldOffset(Offset = "0x18")]
    public GameObject BackToSection;
    [Token(Token = "0x400C6CD")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject BackToCategories;
    [Token(Token = "0x400C6CE")]
    [FieldOffset(Offset = "0x20")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C6CF")]
    [FieldOffset(Offset = "0x24")]
    private string sectionName;
    [Token(Token = "0x400C6D0")]
    [FieldOffset(Offset = "0x28")]
    private List<ListItemEvents> mItems;

    [Token(Token = "0x600BA9E")]
    [Address(RVA = "0x821420", Offset = "0x820220", VA = "0x10821420")]
    private void Start()
    {
    }

    [Token(Token = "0x600BA9F")]
    [Address(RVA = "0x820400", Offset = "0x81F200", VA = "0x10820400", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAA0")]
    [Address(RVA = "0x8204D0", Offset = "0x81F2D0", VA = "0x108204D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BAA1")]
    [Address(RVA = "0x821280", Offset = "0x820080", VA = "0x10821280")]
    private void SetTimerActive(Transform tr, bool value)
    {
    }

    [Token(Token = "0x600BAA2")]
    [Address(RVA = "0x820420", Offset = "0x81F220", VA = "0x10820420")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600BAA3")]
    [Address(RVA = "0x8214B0", Offset = "0x8202B0", VA = "0x108214B0")]
    public ReplayQuestChapterList()
    {
    }

    [Token(Token = "0x2002944")]
    private class ReplayChapterParam
    {
      [Token(Token = "0x400C6D1")]
      [FieldOffset(Offset = "0x8")]
      internal ChapterParam chapterParam;
      [Token(Token = "0x400C6D2")]
      [FieldOffset(Offset = "0xC")]
      internal bool replayLimit;

      [Token(Token = "0x600BAA4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReplayChapterParam()
      {
      }
    }
  }
}
