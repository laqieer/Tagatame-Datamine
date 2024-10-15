// Decompiled with JetBrains decompiler
// Type: SRPG.GallerySortWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024D1")]
  [FlowNode.Pin(0, "ソート順の変更", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Save Setting", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "ソート種別の変更", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "Close", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GallerySortWindow")]
  public class GallerySortWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A822")]
    private const int SORT_ORDER_CHANGE = 0;
    [Token(Token = "0x400A823")]
    private const int SAVE_SETTING = 1;
    [Token(Token = "0x400A824")]
    private const int SORT_TYPE_CHANGE = 2;
    [Token(Token = "0x400A825")]
    private const int OUTPUT_CLOSE = 100;
    [Token(Token = "0x400A826")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle RarityButton;
    [Token(Token = "0x400A827")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle NameButton;
    [Token(Token = "0x400A828")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle AscButton;
    [Token(Token = "0x400A829")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle DescButton;
    [Token(Token = "0x400A82A")]
    [FieldOffset(Offset = "0x1C")]
    private GallerySettings mSettings;
    [Token(Token = "0x400A82B")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsRarityAscending;
    [Token(Token = "0x400A82C")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsNameAscending;
    [Token(Token = "0x400A82D")]
    [FieldOffset(Offset = "0x24")]
    private GallerySettings.SortType mCurrentSortType;

    [Token(Token = "0x600A18D")]
    [Address(RVA = "0x638360", Offset = "0x637160", VA = "0x10638360", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A18E")]
    [Address(RVA = "0x6385C0", Offset = "0x6373C0", VA = "0x106385C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A18F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GallerySortWindow()
    {
    }
  }
}
