// Decompiled with JetBrains decompiler
// Type: SRPG.ExpansionPurchaseParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AD1")]
  public class ExpansionPurchaseParam
  {
    [Token(Token = "0x400637E")]
    public const int EnableRepurchaseDay = 3;
    [Token(Token = "0x400637F")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006380")]
    [FieldOffset(Offset = "0xC")]
    private string mBuyCoinProduct;
    [Token(Token = "0x4006381")]
    [FieldOffset(Offset = "0x10")]
    private int mPeriod;
    [Token(Token = "0x4006382")]
    [FieldOffset(Offset = "0x14")]
    private int mIgnoreLock;
    [Token(Token = "0x4006383")]
    [FieldOffset(Offset = "0x18")]
    private List<ExpansionPurchaseType> mExpansions;
    [Token(Token = "0x4006384")]
    [FieldOffset(Offset = "0x1C")]
    private string mUrl;

    [Token(Token = "0x17000C7C")]
    public string Iname
    {
      [Token(Token = "0x6006E7A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C7D")]
    public string BuyCoinProduct
    {
      [Token(Token = "0x6006E7B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C7E")]
    public int Period
    {
      [Token(Token = "0x6006E7C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7F")]
    public int IgnoreLock
    {
      [Token(Token = "0x6006E7D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C80")]
    public List<ExpansionPurchaseType> Expansions
    {
      [Token(Token = "0x6006E7E"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<ExpansionPurchaseType>) null;
      }
    }

    [Token(Token = "0x17000C81")]
    public string Url
    {
      [Token(Token = "0x6006E7F"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C82")]
    public string Desc
    {
      [Token(Token = "0x6006E80"), Address(RVA = "0x361BD0", Offset = "0x3609D0", VA = "0x10361BD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006E81")]
    [Address(RVA = "0x361370", Offset = "0x360170", VA = "0x10361370")]
    public bool Deserialize(JSON_ExpansionPurchaseParam json) => new bool();

    [Token(Token = "0x6006E82")]
    [Address(RVA = "0x361240", Offset = "0x360040", VA = "0x10361240")]
    public static void Deserialize(
      ref List<ExpansionPurchaseParam> ref_params,
      JSON_ExpansionPurchaseParam[] json)
    {
    }

    [Token(Token = "0x6006E83")]
    [Address(RVA = "0x361800", Offset = "0x360600", VA = "0x10361800")]
    public bool IsIncludeExpansionPurchaseQuest(
      string _quest_iname,
      ExpansionPurchaseParam.eType _type)
    {
      return new bool();
    }

    [Token(Token = "0x6006E84")]
    [Address(RVA = "0x361990", Offset = "0x360790", VA = "0x10361990")]
    public bool IsIncludeExpansionPurchaseType(ExpansionPurchaseParam.eType _type) => new bool();

    [Token(Token = "0x6006E85")]
    [Address(RVA = "0x3618D0", Offset = "0x3606D0", VA = "0x103618D0")]
    public bool IsIncludeExpansionPurchaseTypeAndValue(
      ExpansionPurchaseParam.eType _type,
      int _value)
    {
      return new bool();
    }

    [Token(Token = "0x6006E86")]
    [Address(RVA = "0x361A50", Offset = "0x360850", VA = "0x10361A50")]
    public bool IsIncludeExpansionPurchaseType(ExpansionPurchaseParam.eType[] _type_list)
    {
      return new bool();
    }

    [Token(Token = "0x6006E87")]
    [Address(RVA = "0x361500", Offset = "0x360300", VA = "0x10361500")]
    public List<ExpansionPurchaseType> GetExpansionPurchaseTypeList(
      ExpansionPurchaseParam.eType _type)
    {
      return (List<ExpansionPurchaseType>) null;
    }

    [Token(Token = "0x6006E88")]
    [Address(RVA = "0x361740", Offset = "0x360540", VA = "0x10361740")]
    public bool IsEnablePurchase() => new bool();

    [Token(Token = "0x6006E89")]
    [Address(RVA = "0x3616A0", Offset = "0x3604A0", VA = "0x103616A0")]
    public string GetText(string table, string key) => (string) null;

    [Token(Token = "0x6006E8A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExpansionPurchaseParam()
    {
    }

    [Token(Token = "0x2001AD2")]
    public enum eType
    {
      [Token(Token = "0x4006386")] None,
      [Token(Token = "0x4006387")] TripleSpeed,
      [Token(Token = "0x4006388")] AutoBox,
      [Token(Token = "0x4006389")] ExtraCount,
      [Token(Token = "0x400638A")] ChallengeCount,
      [Token(Token = "0x400638B")] DropUp,
      [Token(Token = "0x400638C")] GuildFrameAdd,
      [Token(Token = "0x400638D")] GuildTrainingTime,
      [Token(Token = "0x400638E")] GuildEnergyRecoveryUp,
      [Token(Token = "0x400638F")] DailyBulkClear,
    }

    [Token(Token = "0x2001AD3")]
    public enum eQuestType
    {
      [Token(Token = "0x4006391")] None,
      [Token(Token = "0x4006392")] StoryNormal,
      [Token(Token = "0x4006393")] StoryHard,
      [Token(Token = "0x4006394")] StoryExtra,
      [Token(Token = "0x4006395")] OthreQuest,
    }
  }
}
