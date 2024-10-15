// Decompiled with JetBrains decompiler
// Type: SRPG.GachaInfoWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200243C")]
  [FlowNode.Pin(10, "Setup", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("UI/Gacha/GachaInfoWindow", 32741)]
  [FlowNode.Pin(110, "TabSelect Rate", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(200, "TabSelected", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "TabSelect Detail", FlowNode.PinTypes.Input, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(120, "TabSelect Pickup", FlowNode.PinTypes.Input, 120)]
  public class GachaInfoWindow : FlowNodePersistent
  {
    [Token(Token = "0x400A428")]
    public const int PIN_IN_SETUP_URL = 10;
    [Token(Token = "0x400A429")]
    public const int PIN_IN_TAB_WEBVIEW = 100;
    [Token(Token = "0x400A42A")]
    public const int PIN_IN_TAB_RATEVIEW = 110;
    [Token(Token = "0x400A42B")]
    public const int PIN_IN_TAB_PICKUPVIEW = 120;
    [Token(Token = "0x400A42C")]
    public const int PIN_OT_TABCHANGED = 200;
    [Token(Token = "0x400A42D")]
    [FieldOffset(Offset = "0x18")]
    private GachaInfoWindow.Tab m_Tab;
    [Token(Token = "0x400A42E")]
    [FieldOffset(Offset = "0x1C")]
    private FlowWindowController m_WindowController;
    [Token(Token = "0x400A42F")]
    [FieldOffset(Offset = "0x20")]
    private string m_BaseURL;
    [Token(Token = "0x400A430")]
    [FieldOffset(Offset = "0x24")]
    [Header("召喚/提供割合を表示する際のURLのPrefix")]
    [SerializeField]
    private string url_prefix;
    [Token(Token = "0x400A431")]
    [FieldOffset(Offset = "0x28")]
    [Header("召喚/ピックアップを表示する際のURLのPrefix")]
    [SerializeField]
    private string url_pickup_prefix;
    [Token(Token = "0x400A432")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SharedWebWindow m_Target;
    [Token(Token = "0x400A433")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle DetailTab;
    [Token(Token = "0x400A434")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Toggle RateTab;
    [Token(Token = "0x400A435")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Toggle PickupTab;
    [Token(Token = "0x400A436")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GachaInfoWindow.Tab InitTab;

    [Token(Token = "0x6009E05")]
    [Address(RVA = "0x609FC0", Offset = "0x608DC0", VA = "0x10609FC0", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6009E06")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009E07")]
    [Address(RVA = "0x4A4C30", Offset = "0x4A3A30", VA = "0x104A4C30", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6009E08")]
    [Address(RVA = "0x4A4CF0", Offset = "0x4A3AF0", VA = "0x104A4CF0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009E09")]
    [Address(RVA = "0x60A040", Offset = "0x608E40", VA = "0x1060A040", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009E0A")]
    [Address(RVA = "0x60A2A0", Offset = "0x6090A0", VA = "0x1060A2A0")]
    private void Setup()
    {
    }

    [Token(Token = "0x6009E0B")]
    [Address(RVA = "0x60A150", Offset = "0x608F50", VA = "0x1060A150")]
    public void OnClose(GameObject go)
    {
    }

    [Token(Token = "0x6009E0C")]
    [Address(RVA = "0x60A1B0", Offset = "0x608FB0", VA = "0x1060A1B0")]
    private bool SetTab(GachaInfoWindow.Tab tab) => new bool();

    [Token(Token = "0x6009E0D")]
    [Address(RVA = "0x60A6A0", Offset = "0x6094A0", VA = "0x1060A6A0")]
    public GachaInfoWindow()
    {
    }

    [Token(Token = "0x200243D")]
    public enum Tab : byte
    {
      [Token(Token = "0x400A438")] NONE,
      [Token(Token = "0x400A439")] DETAIL,
      [Token(Token = "0x400A43A")] RATE,
      [Token(Token = "0x400A43B")] PICKUP,
    }
  }
}
