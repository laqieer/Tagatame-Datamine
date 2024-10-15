// Decompiled with JetBrains decompiler
// Type: SRPG.ExternalLinkWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023B2")]
  [AddComponentMenu("UI/ExternalLinkWindow")]
  public class ExternalLinkWindow : MonoBehaviour
  {
    [Token(Token = "0x400A139")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour SVB_Data;
    [Token(Token = "0x400A13A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemParent;
    [Token(Token = "0x400A13B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExternalLinkWindowItem ItemTempleate;
    [Token(Token = "0x400A13C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<ExternalVideoLinkParam.ePlaceType> SortOrder;
    [Token(Token = "0x400A13D")]
    [FieldOffset(Offset = "0x1C")]
    private List<ExternalVideoLinkParam> mListParam;
    [Token(Token = "0x400A13E")]
    [FieldOffset(Offset = "0x20")]
    private List<ExternalLinkWindowItem> mListItem;

    [Token(Token = "0x6009A7E")]
    [Address(RVA = "0x5E9EA0", Offset = "0x5E8CA0", VA = "0x105E9EA0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009A7F")]
    [Address(RVA = "0x5E9B40", Offset = "0x5E8940", VA = "0x105E9B40")]
    private void SetUp()
    {
    }

    [Token(Token = "0x6009A80")]
    [Address(RVA = "0x5EA3C0", Offset = "0x5E91C0", VA = "0x105EA3C0")]
    public ExternalLinkWindow()
    {
    }
  }
}
