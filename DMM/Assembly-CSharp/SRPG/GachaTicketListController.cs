// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTicketListController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002458")]
  public class GachaTicketListController : MonoBehaviour
  {
    [Token(Token = "0x400A53A")]
    [FieldOffset(Offset = "0xC")]
    private List<GachaTopParamNew> mGachaTicketList;
    [Token(Token = "0x400A53B")]
    [FieldOffset(Offset = "0x10")]
    private Action<GachaTopParamNew> mSelectCallback;
    [Token(Token = "0x400A53C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit contentExhibit;

    [Token(Token = "0x1700163B")]
    public GachaTopParamNew[] GachaTicketList
    {
      [Token(Token = "0x6009ED7"), Address(RVA = "0x6149E0", Offset = "0x6137E0", VA = "0x106149E0")] get
      {
        return (GachaTopParamNew[]) null;
      }
    }

    [Token(Token = "0x6009ED8")]
    [Address(RVA = "0x50A210", Offset = "0x509010", VA = "0x1050A210")]
    public void Initialize(
      List<GachaTopParamNew> gachaTicketList,
      Action<GachaTopParamNew> selectCallback)
    {
    }

    [Token(Token = "0x6009ED9")]
    [Address(RVA = "0x6145B0", Offset = "0x6133B0", VA = "0x106145B0")]
    public void CreateNodes()
    {
    }

    [Token(Token = "0x6009EDA")]
    [Address(RVA = "0x614890", Offset = "0x613690", VA = "0x10614890")]
    private void SetupNode(ContentNode node, BaseItemModel model)
    {
    }

    [Token(Token = "0x6009EDB")]
    [Address(RVA = "0x614880", Offset = "0x613680", VA = "0x10614880")]
    public void RefreshTicketButtonList()
    {
    }

    [Token(Token = "0x6009EDC")]
    [Address(RVA = "0x614860", Offset = "0x613660", VA = "0x10614860")]
    private void OnSelectTicket(GachaTopParamNew param)
    {
    }

    [Token(Token = "0x6009EDD")]
    [Address(RVA = "0x614550", Offset = "0x613350", VA = "0x10614550")]
    public void Clear()
    {
    }

    [Token(Token = "0x6009EDE")]
    [Address(RVA = "0x614970", Offset = "0x613770", VA = "0x10614970")]
    public GachaTicketListController()
    {
    }
  }
}
