// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisChapterSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024E3")]
  [AddComponentMenu("UI/Genesis/GenesisChapterSelector")]
  [FlowNode.Pin(103, "未解放をセレクト", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "期間外をセレクト", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "セレクトした", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "セレクト開始", FlowNode.PinTypes.Input, 1)]
  public class GenesisChapterSelector : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A878")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400A879")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private SRPG_ScrollRect ScrollRectController;
    [Token(Token = "0x400A87A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoSelParent;
    [Token(Token = "0x400A87B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GenesisChapterSelectorItem SelBaseItem;
    [Token(Token = "0x400A87C")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [SerializeField]
    private bool IsSortUpper;
    [Token(Token = "0x400A87D")]
    [FieldOffset(Offset = "0x20")]
    [Space(5f)]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400A87E")]
    [FieldOffset(Offset = "0x24")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x400A87F")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x400A880")]
    private const int PIN_OUT_SELECTED = 101;
    [Token(Token = "0x400A881")]
    private const int PIN_OUT_OUT_OF_PERIOD = 102;
    [Token(Token = "0x400A882")]
    private const int PIN_OUT_NO_LIBERATION = 103;
    [Token(Token = "0x400A883")]
    [FieldOffset(Offset = "0x28")]
    private List<GenesisChapterSelectorItem> mSelectList;

    [Token(Token = "0x600A1F1")]
    [Address(RVA = "0x63AE90", Offset = "0x639C90", VA = "0x1063AE90")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A1F2")]
    [Address(RVA = "0x63AF60", Offset = "0x639D60", VA = "0x1063AF60")]
    private void Init()
    {
    }

    [Token(Token = "0x600A1F3")]
    [Address(RVA = "0x63B7C0", Offset = "0x63A5C0", VA = "0x1063B7C0")]
    private void SetScrollPos(List<GenesisChapterParam> chapter_list)
    {
    }

    [Token(Token = "0x600A1F4")]
    [Address(RVA = "0x63AEE0", Offset = "0x639CE0", VA = "0x1063AEE0")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600A1F5")]
    [Address(RVA = "0x63B650", Offset = "0x63A450", VA = "0x1063B650")]
    private void OnSelectItem(GenesisChapterSelectorItem item)
    {
    }

    [Token(Token = "0x600A1F6")]
    [Address(RVA = "0x63AE70", Offset = "0x639C70", VA = "0x1063AE70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A1F7")]
    [Address(RVA = "0x63BA20", Offset = "0x63A820", VA = "0x1063BA20")]
    public GenesisChapterSelector()
    {
    }
  }
}
