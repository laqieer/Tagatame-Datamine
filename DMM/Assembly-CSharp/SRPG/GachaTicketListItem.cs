// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTicketListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002459")]
  [AddComponentMenu("UI/GachaTicketListItem")]
  [FlowNode.Pin(10, "OnDetailClick", FlowNode.PinTypes.Output, 10)]
  public class GachaTicketListItem : ContentNode, IFlowInterface
  {
    [Token(Token = "0x400A53D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SRPG_Button detailBtn;
    [Token(Token = "0x400A53E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private SRPG_Button execBtn;
    [Token(Token = "0x400A53F")]
    [FieldOffset(Offset = "0x38")]
    private readonly string GACHA_URL_PREFIX;
    [Token(Token = "0x400A540")]
    [FieldOffset(Offset = "0x3C")]
    private string mDetailURL;

    [Token(Token = "0x6009EDF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "18")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009EE0")]
    [Address(RVA = "0x614AF0", Offset = "0x6138F0", VA = "0x10614AF0")]
    public void Refresh(GachaTopParamNew param, Action<GachaTopParamNew> selectCallback)
    {
    }

    [Token(Token = "0x6009EE1")]
    [Address(RVA = "0x614A20", Offset = "0x613820", VA = "0x10614A20")]
    private void OnDetail()
    {
    }

    [Token(Token = "0x6009EE2")]
    [Address(RVA = "0x614D70", Offset = "0x613B70", VA = "0x10614D70")]
    public GachaTicketListItem()
    {
    }
  }
}
