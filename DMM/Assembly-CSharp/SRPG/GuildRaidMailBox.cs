// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidMailBox
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
  [Token(Token = "0x2002577")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Receive All", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Received", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/GuildRaid/GuildRaidMailBox")]
  public class GuildRaidMailBox : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AD3B")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400AD3C")]
    private const int PIN_IN_RECEIVE_ALL = 1;
    [Token(Token = "0x400AD3D")]
    private const int PIN_OUT_RECEIVE = 10;
    [Token(Token = "0x400AD3E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button ReceiveAllButton;
    [Token(Token = "0x400AD3F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildRaidMailBoxItem mTemplate;
    [Token(Token = "0x400AD40")]
    [FieldOffset(Offset = "0x14")]
    private List<GuildRaidMailBoxItem> mItemList;

    [Token(Token = "0x600A5E5")]
    [Address(RVA = "0x6804A0", Offset = "0x67F2A0", VA = "0x106804A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A5E6")]
    [Address(RVA = "0x6807F0", Offset = "0x67F5F0", VA = "0x106807F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A5E7")]
    [Address(RVA = "0x680740", Offset = "0x67F540", VA = "0x10680740")]
    private void OnReceiveItem(SRPG_Button button)
    {
    }

    [Token(Token = "0x600A5E8")]
    [Address(RVA = "0x680600", Offset = "0x67F400", VA = "0x10680600")]
    private void OnReceiveAllItem()
    {
    }

    [Token(Token = "0x600A5E9")]
    [Address(RVA = "0x680C10", Offset = "0x67FA10", VA = "0x10680C10")]
    public GuildRaidMailBox()
    {
    }
  }
}
