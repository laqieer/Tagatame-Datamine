// Decompiled with JetBrains decompiler
// Type: SRPG.SelectItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A80")]
  [AddComponentMenu("UI/SelectItemInfo")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class SelectItemInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x600C20C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C20D")]
    [Address(RVA = "0x8A6B50", Offset = "0x8A5950", VA = "0x108A6B50")]
    private void Start()
    {
    }

    [Token(Token = "0x600C20E")]
    [Address(RVA = "0x8A69C0", Offset = "0x8A57C0", VA = "0x108A69C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C20F")]
    [Address(RVA = "0x8A69E0", Offset = "0x8A57E0", VA = "0x108A69E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C210")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SelectItemInfo()
    {
    }
  }
}
