// Decompiled with JetBrains decompiler
// Type: SRPG.InnWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002649")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "退店", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/InnWindow")]
  public class InnWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B2D8")]
    [FieldOffset(Offset = "0xC")]
    [Description("フレンド申請通知バッジ")]
    public GameObject NotificationBadge;
    [Token(Token = "0x400B2D9")]
    [FieldOffset(Offset = "0x10")]
    [Description("フレンドプレゼントボタン")]
    public GameObject FriendPresentButton;

    [Token(Token = "0x600AAE1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AAE2")]
    [Address(RVA = "0x6E3D90", Offset = "0x6E2B90", VA = "0x106E3D90")]
    private void Start()
    {
    }

    [Token(Token = "0x600AAE3")]
    [Address(RVA = "0x6E3970", Offset = "0x6E2770", VA = "0x106E3970", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AAE4")]
    [Address(RVA = "0x6E3C40", Offset = "0x6E2A40", VA = "0x106E3C40")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AAE5")]
    [Address(RVA = "0x6E3AD0", Offset = "0x6E28D0", VA = "0x106E3AD0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AAE6")]
    [Address(RVA = "0x6E3C20", Offset = "0x6E2A20", VA = "0x106E3C20")]
    private bool OnGoOutInn() => new bool();

    [Token(Token = "0x600AAE7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public InnWindow()
    {
    }
  }
}
