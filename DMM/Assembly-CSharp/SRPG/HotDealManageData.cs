// Decompiled with JetBrains decompiler
// Type: SRPG.HotDealManageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019CE")]
  public class HotDealManageData
  {
    [Token(Token = "0x4005EE3")]
    [FieldOffset(Offset = "0x8")]
    private List<SRPG.HotDealInfo> mHotDealInfo;

    [Token(Token = "0x17000B2F")]
    public List<SRPG.HotDealInfo> HotDealInfo
    {
      [Token(Token = "0x600693E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<SRPG.HotDealInfo>) null;
      }
    }

    [Token(Token = "0x600693F")]
    [Address(RVA = "0x359510", Offset = "0x358310", VA = "0x10359510")]
    public void Deserialize(Json_HotDealInfo[] json, bool is_refresh = false)
    {
    }

    [Token(Token = "0x6006940")]
    [Address(RVA = "0x359B50", Offset = "0x358950", VA = "0x10359B50")]
    public bool IsExistHotDeal() => new bool();

    [Token(Token = "0x6006941")]
    [Address(RVA = "0x359B90", Offset = "0x358990", VA = "0x10359B90")]
    public bool IsNewlyGeneratedHotDeal() => new bool();

    [Token(Token = "0x6006942")]
    [Address(RVA = "0x359970", Offset = "0x358770", VA = "0x10359970")]
    public List<SRPG.HotDealInfo> GenerateHotDealNewlyList() => (List<SRPG.HotDealInfo>) null;

    [Token(Token = "0x6006943")]
    [Address(RVA = "0x359A60", Offset = "0x358860", VA = "0x10359A60")]
    public List<SRPG.HotDealInfo> GenerateHotDealNewly() => (List<SRPG.HotDealInfo>) null;

    [Token(Token = "0x6006944")]
    [Address(RVA = "0x359C20", Offset = "0x358A20", VA = "0x10359C20")]
    public bool IsUnLookedHotDeal() => new bool();

    [Token(Token = "0x6006945")]
    [Address(RVA = "0x3593F0", Offset = "0x3581F0", VA = "0x103593F0")]
    public void ClearBuyHotDeal()
    {
    }

    [Token(Token = "0x6006946")]
    [Address(RVA = "0x359720", Offset = "0x358520", VA = "0x10359720")]
    public bool EnablePopHotDealCheck() => new bool();

    [Token(Token = "0x6006947")]
    [Address(RVA = "0x359CB0", Offset = "0x358AB0", VA = "0x10359CB0")]
    public HotDealManageData()
    {
    }
  }
}
