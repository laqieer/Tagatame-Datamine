// Decompiled with JetBrains decompiler
// Type: SRPG.ChatChannelWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002155")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("UI/ChatChannelWindow")]
  [FlowNode.Pin(99, "Close", FlowNode.PinTypes.Output, 99)]
  [FlowNode.Pin(2, "Request(PageIndex)", FlowNode.PinTypes.Output, 2)]
  public class ChatChannelWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400913F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject PanelTemplate1;
    [Token(Token = "0x4009140")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject PanelTemplate2;
    [Token(Token = "0x4009141")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform ChatChannelBtn;
    [Token(Token = "0x4009142")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform ChatChannelPagePanel;
    [Token(Token = "0x4009143")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform PageItemRoot;
    [Token(Token = "0x4009144")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ChannelPageItem;
    [Token(Token = "0x4009145")]
    [FieldOffset(Offset = "0x24")]
    private GameObject[] mChannelPages;
    [Token(Token = "0x4009146")]
    [FieldOffset(Offset = "0x28")]
    private ChatChannel mChannel;
    [Token(Token = "0x4009147")]
    [FieldOffset(Offset = "0x2C")]
    public int ONE_VIEW;
    [Token(Token = "0x4009148")]
    private const int page_item_max = 20;
    [Token(Token = "0x4009149")]
    [FieldOffset(Offset = "0x30")]
    private GameManager gm;

    [Token(Token = "0x170013C2")]
    public ChatChannel Channel
    {
      [Token(Token = "0x6008BFB"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (ChatChannel) null;
      }
      [Token(Token = "0x6008BFC"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x6008BFD")]
    [Address(RVA = "0x4FB5C0", Offset = "0x4FA3C0", VA = "0x104FB5C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008BFE")]
    [Address(RVA = "0x4FB630", Offset = "0x4FA430", VA = "0x104FB630")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008BFF")]
    [Address(RVA = "0x4FC150", Offset = "0x4FAF50", VA = "0x104FC150")]
    private void Start()
    {
    }

    [Token(Token = "0x6008C00")]
    [Address(RVA = "0x4FB9C0", Offset = "0x4FA7C0", VA = "0x104FB9C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008C01")]
    [Address(RVA = "0x4FB800", Offset = "0x4FA600", VA = "0x104FB800")]
    private void RefreshPageButton(int begin, int end)
    {
    }

    [Token(Token = "0x6008C02")]
    [Address(RVA = "0x4FB790", Offset = "0x4FA590", VA = "0x104FB790")]
    private void OnSelectPage(int page)
    {
    }

    [Token(Token = "0x6008C03")]
    [Address(RVA = "0x4FC170", Offset = "0x4FAF70", VA = "0x104FC170")]
    public ChatChannelWindow()
    {
    }
  }
}
