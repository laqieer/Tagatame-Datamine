// Decompiled with JetBrains decompiler
// Type: SRPG.GachaInfoSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200243B")]
  [FlowNode.NodeType("UI/Gacha/GachaInfoSelector", 32741)]
  [FlowNode.Pin(100, "Setup", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "Select Detail", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(120, "Select Rate", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(130, "Select Pickup", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(200, "Selected", FlowNode.PinTypes.Output, 200)]
  [AddComponentMenu("")]
  public class GachaInfoSelector : FlowNodePersistent
  {
    [Token(Token = "0x400A41C")]
    private const int PIN_IN_SETUP_URL = 100;
    [Token(Token = "0x400A41D")]
    private const int PIN_IN_SELECT_DETAIL = 110;
    [Token(Token = "0x400A41E")]
    private const int PIN_IN_SELECT_RATE = 120;
    [Token(Token = "0x400A41F")]
    private const int PIN_IN_SELECT_PICKUP = 130;
    [Token(Token = "0x400A420")]
    private const int PIN_OT_SELECTED = 200;
    [Token(Token = "0x400A421")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string url;
    [Token(Token = "0x400A422")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Header("召喚->提供割合を表示する際のURLのPrefix")]
    private string url_prefix;
    [Token(Token = "0x400A423")]
    [FieldOffset(Offset = "0x20")]
    [Header("召喚->ピックアップを表示する際のURLのPrefix")]
    [SerializeField]
    private string url_pickup_prefix;
    [Token(Token = "0x400A424")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject RateButton;
    [Token(Token = "0x400A425")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button PickupButton;
    [Token(Token = "0x400A426")]
    [FieldOffset(Offset = "0x2C")]
    private string m_BaseURL;
    [Token(Token = "0x400A427")]
    [FieldOffset(Offset = "0x30")]
    private FlowWindowController m_WindowController;

    [Token(Token = "0x6009DFF")]
    [Address(RVA = "0x609B70", Offset = "0x608970", VA = "0x10609B70", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6009E00")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    protected void Start()
    {
    }

    [Token(Token = "0x6009E01")]
    [Address(RVA = "0x609CC0", Offset = "0x608AC0", VA = "0x10609CC0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6009E02")]
    [Address(RVA = "0x609BF0", Offset = "0x6089F0", VA = "0x10609BF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009E03")]
    [Address(RVA = "0x609CF0", Offset = "0x608AF0", VA = "0x10609CF0")]
    private void Setup()
    {
    }

    [Token(Token = "0x6009E04")]
    [Address(RVA = "0x609EE0", Offset = "0x608CE0", VA = "0x10609EE0")]
    public GachaInfoSelector()
    {
    }
  }
}
