// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureAreaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001969")]
  public class AdventureAreaParam
  {
    [Token(Token = "0x4005C84")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005C85")]
    [FieldOffset(Offset = "0xC")]
    private string mAreaName;
    [Token(Token = "0x4005C86")]
    [FieldOffset(Offset = "0x10")]
    private List<AdventureAreaParam.LiberationCond> mCondAreaList;
    [Token(Token = "0x4005C87")]
    [FieldOffset(Offset = "0x14")]
    private int mUiIndex;
    [Token(Token = "0x4005C88")]
    [FieldOffset(Offset = "0x18")]
    private string mWebViewURL;
    [Token(Token = "0x4005C89")]
    [FieldOffset(Offset = "0x1C")]
    private string mWebViewTitle;
    [Token(Token = "0x4005C8A")]
    [FieldOffset(Offset = "0x20")]
    private List<AdventureAreaParam.QuestInfo> mQuestInfoList;

    [Token(Token = "0x17000A93")]
    public string Iname
    {
      [Token(Token = "0x6006795"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A94")]
    public string AreaName
    {
      [Token(Token = "0x6006796"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A95")]
    public List<AdventureAreaParam.LiberationCond> CondAreaList
    {
      [Token(Token = "0x6006797"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<AdventureAreaParam.LiberationCond>) null;
      }
    }

    [Token(Token = "0x17000A96")]
    public int UiIndex
    {
      [Token(Token = "0x6006798"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A97")]
    public string WebViewURL
    {
      [Token(Token = "0x6006799"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A98")]
    public string WebViewTitle
    {
      [Token(Token = "0x600679A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A99")]
    public List<AdventureAreaParam.QuestInfo> QuestInfoList
    {
      [Token(Token = "0x600679B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<AdventureAreaParam.QuestInfo>) null;
      }
    }

    [Token(Token = "0x17000A9A")]
    public int LevelMax
    {
      [Token(Token = "0x600679C"), Address(RVA = "0x31BDE0", Offset = "0x31ABE0", VA = "0x1031BDE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600679D")]
    [Address(RVA = "0x31B6B0", Offset = "0x31A4B0", VA = "0x1031B6B0")]
    public void Deserialize(JSON_AdventureAreaParam json)
    {
    }

    [Token(Token = "0x600679E")]
    [Address(RVA = "0x31BA40", Offset = "0x31A840", VA = "0x1031BA40")]
    public static void Deserialize(
      ref List<AdventureAreaParam> list,
      JSON_AdventureAreaParam[] json)
    {
    }

    [Token(Token = "0x600679F")]
    [Address(RVA = "0x31BC20", Offset = "0x31AA20", VA = "0x1031BC20")]
    public static AdventureAreaParam GetParam(string iname) => (AdventureAreaParam) null;

    [Token(Token = "0x60067A0")]
    [Address(RVA = "0x31BD30", Offset = "0x31AB30", VA = "0x1031BD30")]
    public AdventureAreaParam()
    {
    }

    [Token(Token = "0x200196A")]
    public class QuestInfo
    {
      [Token(Token = "0x4005C8B")]
      [FieldOffset(Offset = "0x8")]
      private TimeSpan mAdvTime;
      [Token(Token = "0x4005C8C")]
      [FieldOffset(Offset = "0x10")]
      private string mCostId;
      [Token(Token = "0x4005C8D")]
      [FieldOffset(Offset = "0x14")]
      private AdventureCostParam mCostParam;
      [Token(Token = "0x4005C8E")]
      [FieldOffset(Offset = "0x18")]
      private string mCondId;
      [Token(Token = "0x4005C8F")]
      [FieldOffset(Offset = "0x1C")]
      private AdventureCondParam mCondParam;
      [Token(Token = "0x4005C90")]
      [FieldOffset(Offset = "0x20")]
      private string mBuffId;
      [Token(Token = "0x4005C91")]
      [FieldOffset(Offset = "0x24")]
      private BuffEffectParam mBuffParam;
      [Token(Token = "0x4005C92")]
      [FieldOffset(Offset = "0x28")]
      private string mBuffName;
      [Token(Token = "0x4005C93")]
      [FieldOffset(Offset = "0x2C")]
      private string mBuffDesc;

      [Token(Token = "0x17000A9B")]
      public TimeSpan AdvTime
      {
        [Token(Token = "0x60067A1"), Address(RVA = "0x2ECBB0", Offset = "0x2EB9B0", VA = "0x102ECBB0")] get
        {
          return new TimeSpan();
        }
      }

      [Token(Token = "0x17000A9C")]
      public string CostId
      {
        [Token(Token = "0x60067A2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000A9D")]
      public AdventureCostParam CostParam
      {
        [Token(Token = "0x60067A3"), Address(RVA = "0x32D130", Offset = "0x32BF30", VA = "0x1032D130")] get
        {
          return (AdventureCostParam) null;
        }
      }

      [Token(Token = "0x17000A9E")]
      public string CondId
      {
        [Token(Token = "0x60067A4"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000A9F")]
      public AdventureCondParam CondParam
      {
        [Token(Token = "0x60067A5"), Address(RVA = "0x32CFE0", Offset = "0x32BDE0", VA = "0x1032CFE0")] get
        {
          return (AdventureCondParam) null;
        }
      }

      [Token(Token = "0x17000AA0")]
      public string BuffId
      {
        [Token(Token = "0x60067A6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000AA1")]
      public BuffEffectParam BuffParam
      {
        [Token(Token = "0x60067A7"), Address(RVA = "0x32CF30", Offset = "0x32BD30", VA = "0x1032CF30")] get
        {
          return (BuffEffectParam) null;
        }
      }

      [Token(Token = "0x17000AA2")]
      public string BuffName
      {
        [Token(Token = "0x60067A8"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000AA3")]
      public string BuffDesc
      {
        [Token(Token = "0x60067A9"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60067AA")]
      [Address(RVA = "0x32CE00", Offset = "0x32BC00", VA = "0x1032CE00")]
      public void Deserialize(JSON_AdventureAreaParam.QuestInfo json)
      {
      }

      [Token(Token = "0x60067AB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public QuestInfo()
      {
      }
    }

    [Token(Token = "0x200196B")]
    public class LiberationCond
    {
      [Token(Token = "0x4005C94")]
      [FieldOffset(Offset = "0x8")]
      private string mAreaName;
      [Token(Token = "0x4005C95")]
      [FieldOffset(Offset = "0xC")]
      private int mLevel;

      [Token(Token = "0x17000AA4")]
      public string AreaName
      {
        [Token(Token = "0x60067AC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000AA5")]
      public int Level
      {
        [Token(Token = "0x60067AD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60067AE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LiberationCond()
      {
      }

      [Token(Token = "0x60067AF")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public LiberationCond(string area_name, int level)
      {
      }
    }
  }
}
