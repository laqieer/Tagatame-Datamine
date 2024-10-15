// Decompiled with JetBrains decompiler
// Type: SRPG.HotDeal_BannerList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200263C")]
  [AddComponentMenu("UI/HotDeal/HotDeal_BannerList")]
  public class HotDeal_BannerList : MonoBehaviour
  {
    [Token(Token = "0x400B28F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private HotDeal_Banner m_OriginalObj;
    [Token(Token = "0x400B290")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform m_InstanseParent;
    [Token(Token = "0x400B291")]
    [FieldOffset(Offset = "0x14")]
    private List<HotDeal_Banner> m_ChildrenObj;

    [Token(Token = "0x600AA9D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AA9E")]
    [Address(RVA = "0x6DF750", Offset = "0x6DE550", VA = "0x106DF750")]
    public void SetListData(List<HotDealInfo> _lists)
    {
    }

    [Token(Token = "0x600AA9F")]
    [Address(RVA = "0x6DFA40", Offset = "0x6DE840", VA = "0x106DFA40")]
    public HotDeal_BannerList()
    {
    }
  }
}
