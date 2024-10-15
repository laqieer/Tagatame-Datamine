// Decompiled with JetBrains decompiler
// Type: SRPG.HotDealInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019CC")]
  public class HotDealInfo
  {
    [Token(Token = "0x4005ED8")]
    private const string LocalizeFineName = "external_BuyCoinHotDeal";
    [Token(Token = "0x4005ED9")]
    private const string LocalizePath = "Loc/japanese/";
    [Token(Token = "0x4005EDA")]
    private const string MessagePrefix = "_SPEECH";
    [Token(Token = "0x4005EDB")]
    [FieldOffset(Offset = "0x8")]
    private string m_BuyCoinProductIname;
    [Token(Token = "0x4005EDC")]
    [FieldOffset(Offset = "0x10")]
    private long m_StartTime;
    [Token(Token = "0x4005EDD")]
    [FieldOffset(Offset = "0x18")]
    private long m_EndTime;
    [Token(Token = "0x4005EDE")]
    [FieldOffset(Offset = "0x20")]
    private bool m_is_looked;
    [Token(Token = "0x4005EDF")]
    [FieldOffset(Offset = "0x24")]
    private BuyCoinProductParam m_BuyCoinProductParam_cache;
    [Token(Token = "0x4005EE0")]
    [FieldOffset(Offset = "0x28")]
    private BuyCoinHotDealParam m_BuyCoinHotDealParam_cache;
    [Token(Token = "0x4005EE1")]
    [FieldOffset(Offset = "0x2C")]
    private PaymentManager.Product m_Product_cache;

    [Token(Token = "0x600692A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public HotDealInfo()
    {
    }

    [Token(Token = "0x17000B2A")]
    public string ProductIname
    {
      [Token(Token = "0x600692B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000B2B")]
    public DateTime StartTime
    {
      [Token(Token = "0x600692C"), Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x103593A0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000B2C")]
    public DateTime EndTime
    {
      [Token(Token = "0x600692D"), Address(RVA = "0x359330", Offset = "0x358130", VA = "0x10359330")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000B2D")]
    public bool IsLooked
    {
      [Token(Token = "0x600692E"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600692F"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] set
      {
      }
    }

    [Token(Token = "0x17000B2E")]
    public bool IsStart
    {
      [Token(Token = "0x6006930"), Address(RVA = "0x359380", Offset = "0x358180", VA = "0x10359380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006931")]
    [Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")]
    public PaymentManager.Product GetProduct() => (PaymentManager.Product) null;

    [Token(Token = "0x6006932")]
    [Address(RVA = "0x359070", Offset = "0x357E70", VA = "0x10359070")]
    public string GetName() => (string) null;

    [Token(Token = "0x6006933")]
    [Address(RVA = "0x3590C0", Offset = "0x357EC0", VA = "0x103590C0")]
    public string GetPrice() => (string) null;

    [Token(Token = "0x6006934")]
    [Address(RVA = "0x3590A0", Offset = "0x357EA0", VA = "0x103590A0")]
    public string GetPrefabName() => (string) null;

    [Token(Token = "0x6006935")]
    [Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x103591A0")]
    public string GetUrl() => (string) null;

    [Token(Token = "0x6006936")]
    [Address(RVA = "0x3590F0", Offset = "0x357EF0", VA = "0x103590F0")]
    public int GetSortOrder() => new int();

    [Token(Token = "0x6006937")]
    [Address(RVA = "0x359110", Offset = "0x357F10", VA = "0x10359110")]
    public string GetSpeech() => (string) null;

    [Token(Token = "0x6006938")]
    [Address(RVA = "0x3591C0", Offset = "0x357FC0", VA = "0x103591C0")]
    public bool IsCheckedDisable() => new bool();

    [Token(Token = "0x6006939")]
    [Address(RVA = "0x359020", Offset = "0x357E20", VA = "0x10359020")]
    public void Deserialize(Json_HotDealInfo json)
    {
    }

    [Token(Token = "0x600693A")]
    [Address(RVA = "0x358DF0", Offset = "0x357BF0", VA = "0x10358DF0")]
    public void CreateCache()
    {
    }

    [Token(Token = "0x600693B")]
    [Address(RVA = "0x3592B0", Offset = "0x3580B0", VA = "0x103592B0")]
    public void ParamOverride(HotDealInfo info)
    {
    }
  }
}
