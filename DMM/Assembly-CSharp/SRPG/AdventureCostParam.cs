// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001979")]
  public class AdventureCostParam
  {
    [Token(Token = "0x4005CD2")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005CD3")]
    [FieldOffset(Offset = "0xC")]
    private int mApNum;
    [Token(Token = "0x4005CD4")]
    [FieldOffset(Offset = "0x10")]
    private List<AdventureCostParam.Cost> mCostList;

    [Token(Token = "0x17000AB8")]
    public string Iname
    {
      [Token(Token = "0x60067E1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AB9")]
    public int ApNum
    {
      [Token(Token = "0x60067E2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ABA")]
    public List<AdventureCostParam.Cost> CostList
    {
      [Token(Token = "0x60067E3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<AdventureCostParam.Cost>) null;
      }
    }

    [Token(Token = "0x60067E4")]
    [Address(RVA = "0x31DBC0", Offset = "0x31C9C0", VA = "0x1031DBC0")]
    public void Deserialize(JSON_AdventureCostParam json)
    {
    }

    [Token(Token = "0x60067E5")]
    [Address(RVA = "0x31D8E0", Offset = "0x31C6E0", VA = "0x1031D8E0")]
    public static void Deserialize(
      ref List<AdventureCostParam> list,
      JSON_AdventureCostParam[] json)
    {
    }

    [Token(Token = "0x60067E6")]
    [Address(RVA = "0x31DD30", Offset = "0x31CB30", VA = "0x1031DD30")]
    public static AdventureCostParam GetParam(string iname) => (AdventureCostParam) null;

    [Token(Token = "0x60067E7")]
    [Address(RVA = "0x31DE40", Offset = "0x31CC40", VA = "0x1031DE40")]
    public AdventureCostParam.ePlayerCostState GetPlayerCostState(string _area_iname)
    {
      return new AdventureCostParam.ePlayerCostState();
    }

    [Token(Token = "0x60067E8")]
    [Address(RVA = "0x31DD00", Offset = "0x31CB00", VA = "0x1031DD00")]
    public int GetCalcCampaignCostAP(string _area_iname) => new int();

    [Token(Token = "0x60067E9")]
    [Address(RVA = "0x31E090", Offset = "0x31CE90", VA = "0x1031E090")]
    public AdventureCostParam()
    {
    }

    [Token(Token = "0x200197A")]
    public enum ePlayerCostState
    {
      [Token(Token = "0x4005CD6")] Clear,
      [Token(Token = "0x4005CD7")] NotEnoughAP,
      [Token(Token = "0x4005CD8")] NotEnoughItem,
      [Token(Token = "0x4005CD9")] NotEnoughAll,
    }

    [Token(Token = "0x200197B")]
    public class Cost
    {
      [Token(Token = "0x4005CDA")]
      [FieldOffset(Offset = "0x8")]
      private string mItemIname;
      [Token(Token = "0x4005CDB")]
      [FieldOffset(Offset = "0xC")]
      private ItemParam mItemParam;
      [Token(Token = "0x4005CDC")]
      [FieldOffset(Offset = "0x10")]
      private int mItemNum;

      [Token(Token = "0x17000ABB")]
      public string ItemIname
      {
        [Token(Token = "0x60067EA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000ABC")]
      public ItemParam ItemParam
      {
        [Token(Token = "0x60067EB"), Address(RVA = "0x321680", Offset = "0x320480", VA = "0x10321680")] get
        {
          return (ItemParam) null;
        }
      }

      [Token(Token = "0x17000ABD")]
      public int ItemNum
      {
        [Token(Token = "0x60067EC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60067ED")]
      [Address(RVA = "0x321650", Offset = "0x320450", VA = "0x10321650")]
      public void Deserialize(JSON_AdventureCostParam.Cost json)
      {
      }

      [Token(Token = "0x60067EE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Cost()
      {
      }
    }
  }
}
