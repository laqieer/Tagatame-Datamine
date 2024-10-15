// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryHighlightGiftWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024C6")]
  [FlowNode.Pin(0, "Screen Tap", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Wait Until Show Buttons", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/GalleryHighlightGiftWindow")]
  public class GalleryHighlightGiftWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A7E4")]
    private const int PIN_IN_SCREEN_TAP = 0;
    [Token(Token = "0x400A7E5")]
    private const int PIN_OUT_WAIT_UNTIL_SHOW_BUTTONS = 10;
    [Token(Token = "0x400A7E6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ExitButton;
    [Token(Token = "0x400A7E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ReplayButton;
    [Token(Token = "0x400A7E8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CanvasGroup TopCanvas;
    [Token(Token = "0x400A7E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ItemHolder;
    [Token(Token = "0x400A7EA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400A7EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject GoldTemplate;
    [Token(Token = "0x400A7EC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject CoinTemplate;
    [Token(Token = "0x400A7ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject AwardTemplate;
    [Token(Token = "0x400A7EE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject ConceptCardTemplate;
    [Token(Token = "0x400A7EF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject UnitTemplate;
    [Token(Token = "0x400A7F0")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject ArtifactTemplate;
    [Token(Token = "0x400A7F1")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> mItems;

    [Token(Token = "0x600A155")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A156")]
    [Address(RVA = "0x633AF0", Offset = "0x6328F0", VA = "0x10633AF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A157")]
    [Address(RVA = "0x634280", Offset = "0x633080", VA = "0x10634280")]
    public void Refresh(HighlightParam param, bool isReward)
    {
    }

    [Token(Token = "0x600A158")]
    [Address(RVA = "0x634100", Offset = "0x632F00", VA = "0x10634100")]
    private GameObject CreateItem(string iname, int num) => (GameObject) null;

    [Token(Token = "0x600A159")]
    [Address(RVA = "0x633F40", Offset = "0x632D40", VA = "0x10633F40")]
    private GameObject CreateCoinItem(int num) => (GameObject) null;

    [Token(Token = "0x600A15A")]
    [Address(RVA = "0x634080", Offset = "0x632E80", VA = "0x10634080")]
    private GameObject CreateGoldItem(int num) => (GameObject) null;

    [Token(Token = "0x600A15B")]
    [Address(RVA = "0x633E40", Offset = "0x632C40", VA = "0x10633E40")]
    private GameObject CreateAwardItem(string iname, int num) => (GameObject) null;

    [Token(Token = "0x600A15C")]
    [Address(RVA = "0x633FC0", Offset = "0x632DC0", VA = "0x10633FC0")]
    private GameObject CreateConceptCardItem(string iname, int num) => (GameObject) null;

    [Token(Token = "0x600A15D")]
    [Address(RVA = "0x6341C0", Offset = "0x632FC0", VA = "0x106341C0")]
    private GameObject CreateUnit(string iname, int num) => (GameObject) null;

    [Token(Token = "0x600A15E")]
    [Address(RVA = "0x633D60", Offset = "0x632B60", VA = "0x10633D60")]
    private GameObject CreateArtifact(string iname, int num) => (GameObject) null;

    [Token(Token = "0x600A15F")]
    [Address(RVA = "0x634730", Offset = "0x633530", VA = "0x10634730")]
    public GalleryHighlightGiftWindow()
    {
    }
  }
}
