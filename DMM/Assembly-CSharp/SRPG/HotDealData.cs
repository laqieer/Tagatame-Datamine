// Decompiled with JetBrains decompiler
// Type: SRPG.HotDealData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002638")]
  public class HotDealData
  {
    [Token(Token = "0x400B270")]
    [FieldOffset(Offset = "0x8")]
    private int m_select_index;
    [Token(Token = "0x400B271")]
    [FieldOffset(Offset = "0xC")]
    private List<HotDealInfo> m_hotDealInfoSlideList;

    [Token(Token = "0x600AA6E")]
    [Address(RVA = "0x6DE830", Offset = "0x6DD630", VA = "0x106DE830")]
    public void Setup(List<HotDealInfo> _infos)
    {
    }

    [Token(Token = "0x600AA6F")]
    [Address(RVA = "0x6DE6F0", Offset = "0x6DD4F0", VA = "0x106DE6F0")]
    public void Next()
    {
    }

    [Token(Token = "0x600AA70")]
    [Address(RVA = "0x6DE750", Offset = "0x6DD550", VA = "0x106DE750")]
    public void Prev()
    {
    }

    [Token(Token = "0x600AA71")]
    [Address(RVA = "0x6DE580", Offset = "0x6DD380", VA = "0x106DE580")]
    public int GetSlideListCount() => new int();

    [Token(Token = "0x600AA72")]
    [Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")]
    public List<HotDealInfo> GetSlideList() => (List<HotDealInfo>) null;

    [Token(Token = "0x600AA73")]
    [Address(RVA = "0x6DE4C0", Offset = "0x6DD2C0", VA = "0x106DE4C0")]
    public HotDealInfo GetCurrHotDealInfo() => (HotDealInfo) null;

    [Token(Token = "0x600AA74")]
    [Address(RVA = "0x6DE520", Offset = "0x6DD320", VA = "0x106DE520")]
    public HotDealInfo GetCurrHotDealInfo(int number) => (HotDealInfo) null;

    [Token(Token = "0x600AA75")]
    [Address(RVA = "0x6DE7B0", Offset = "0x6DD5B0", VA = "0x106DE7B0")]
    public void SetCurrHotDealInfo(HotDealInfo _info)
    {
    }

    [Token(Token = "0x600AA76")]
    [Address(RVA = "0x6DE630", Offset = "0x6DD430", VA = "0x106DE630")]
    public bool IsFoundNextInfo() => new bool();

    [Token(Token = "0x600AA77")]
    [Address(RVA = "0x6DE690", Offset = "0x6DD490", VA = "0x106DE690")]
    public bool IsFoundPrevInfo() => new bool();

    [Token(Token = "0x600AA78")]
    [Address(RVA = "0x6DE5C0", Offset = "0x6DD3C0", VA = "0x106DE5C0")]
    public bool IsFindInfo(int num) => new bool();

    [Token(Token = "0x600AA79")]
    [Address(RVA = "0x6DE470", Offset = "0x6DD270", VA = "0x106DE470")]
    private int Culing(int input) => new int();

    [Token(Token = "0x600AA7A")]
    [Address(RVA = "0x6DE860", Offset = "0x6DD660", VA = "0x106DE860")]
    public HotDealData()
    {
    }
  }
}
