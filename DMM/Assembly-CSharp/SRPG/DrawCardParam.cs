// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AAC")]
  public class DrawCardParam
  {
    [Token(Token = "0x40062DC")]
    [FieldOffset(Offset = "0x8")]
    public string Iname;
    [Token(Token = "0x40062DD")]
    [FieldOffset(Offset = "0x10")]
    public DateTime BeginAt;
    [Token(Token = "0x40062DE")]
    [FieldOffset(Offset = "0x18")]
    public DateTime EndAt;
    [Token(Token = "0x40062DF")]
    [FieldOffset(Offset = "0x20")]
    public DrawCardInfoParam[] mDrawCardInfos;
    [Token(Token = "0x40062E0")]
    [FieldOffset(Offset = "0x24")]
    public int type;
    [Token(Token = "0x40062E1")]
    [FieldOffset(Offset = "0x0")]
    public static bool DrawCardEnabled;
    [Token(Token = "0x40062E2")]
    [FieldOffset(Offset = "0x4")]
    public static int DrawCardStepCount;
    [Token(Token = "0x40062E3")]
    [FieldOffset(Offset = "0x8")]
    private static DrawCardParam.CardData[] mSelectDrawCards;
    [Token(Token = "0x40062E4")]
    [FieldOffset(Offset = "0xC")]
    public static int SelectDrawCardIndex;
    [Token(Token = "0x40062E5")]
    [FieldOffset(Offset = "0x10")]
    private static DrawCardParam.CardData mChoiceDrawCard;
    [Token(Token = "0x40062E6")]
    [FieldOffset(Offset = "0x14")]
    private static DrawCardParam.CardData[] mRewardDrawCards;

    [Token(Token = "0x17000C53")]
    public List<DrawCardInfoParam> DrawCardList
    {
      [Token(Token = "0x6006DF7"), Address(RVA = "0x35E250", Offset = "0x35D050", VA = "0x1035E250")] get
      {
        return (List<DrawCardInfoParam>) null;
      }
    }

    [Token(Token = "0x6006DF8")]
    [Address(RVA = "0x35CF90", Offset = "0x35BD90", VA = "0x1035CF90")]
    public void Deserialize(JSON_DrawCardParam json)
    {
    }

    [Token(Token = "0x6006DF9")]
    [Address(RVA = "0x35E090", Offset = "0x35CE90", VA = "0x1035E090")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x6006DFA")]
    [Address(RVA = "0x35D270", Offset = "0x35C070", VA = "0x1035D270")]
    public static void Deserialize(
      ref Dictionary<string, DrawCardParam> dict,
      JSON_DrawCardParam[] json)
    {
    }

    [Token(Token = "0x6006DFB")]
    [Address(RVA = "0x35DEC0", Offset = "0x35CCC0", VA = "0x1035DEC0")]
    public static DrawCardParam GetParam(string key) => (DrawCardParam) null;

    [Token(Token = "0x6006DFC")]
    [Address(RVA = "0x35D9B0", Offset = "0x35C7B0", VA = "0x1035D9B0")]
    public static DrawCardParam GetActiveDrawCardParam() => (DrawCardParam) null;

    [Token(Token = "0x6006DFD")]
    [Address(RVA = "0x35DCB0", Offset = "0x35CAB0", VA = "0x1035DCB0")]
    public static List<DrawCardRewardParam.Data> GetCurrentDrawCardRewardList()
    {
      return (List<DrawCardRewardParam.Data>) null;
    }

    [Token(Token = "0x17000C54")]
    public static List<DrawCardParam.CardData> SelectDrawCardList
    {
      [Token(Token = "0x6006DFE"), Address(RVA = "0x35E3D0", Offset = "0x35D1D0", VA = "0x1035E3D0")] get
      {
        return (List<DrawCardParam.CardData>) null;
      }
    }

    [Token(Token = "0x6006DFF")]
    [Address(RVA = "0x35D760", Offset = "0x35C560", VA = "0x1035D760")]
    public static bool EntrySelectDrawCards(ReqDrawCard.CardInfo[] select_cards) => new bool();

    [Token(Token = "0x6006E00")]
    [Address(RVA = "0x35CF30", Offset = "0x35BD30", VA = "0x1035CF30")]
    public static void ClearSelectDrawCard()
    {
    }

    [Token(Token = "0x17000C55")]
    public static DrawCardParam.CardData ChoiceDrawCard
    {
      [Token(Token = "0x6006E01"), Address(RVA = "0x35E210", Offset = "0x35D010", VA = "0x1035E210")] get
      {
        return (DrawCardParam.CardData) null;
      }
    }

    [Token(Token = "0x6006E02")]
    [Address(RVA = "0x35D3E0", Offset = "0x35C1E0", VA = "0x1035D3E0")]
    public static bool EntryChoiceDrawCard(ReqDrawCard.CardInfo draw_card_info) => new bool();

    [Token(Token = "0x6006E03")]
    [Address(RVA = "0x35CE70", Offset = "0x35BC70", VA = "0x1035CE70")]
    public static void ClearChoiceDrawCard()
    {
    }

    [Token(Token = "0x17000C56")]
    public static List<DrawCardParam.CardData> RewardDrawCardList
    {
      [Token(Token = "0x6006E04"), Address(RVA = "0x35E2F0", Offset = "0x35D0F0", VA = "0x1035E2F0")] get
      {
        return (List<DrawCardParam.CardData>) null;
      }
    }

    [Token(Token = "0x6006E05")]
    [Address(RVA = "0x35D530", Offset = "0x35C330", VA = "0x1035D530")]
    public static bool EntryRewardDrawCards(ReqDrawCard.CardInfo.Card[] reward_cards) => new bool();

    [Token(Token = "0x6006E06")]
    [Address(RVA = "0x35CED0", Offset = "0x35BCD0", VA = "0x1035CED0")]
    public static void ClearRewardDrawCard()
    {
    }

    [Token(Token = "0x6006E07")]
    [Address(RVA = "0x35DE70", Offset = "0x35CC70", VA = "0x1035DE70")]
    public static int GetDrawCardType() => new int();

    [Token(Token = "0x6006E08")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DrawCardParam()
    {
    }

    [Token(Token = "0x6006E09")]
    [Address(RVA = "0x35E160", Offset = "0x35CF60", VA = "0x1035E160")]
    static DrawCardParam()
    {
    }

    [Token(Token = "0x2001AAD")]
    public class CardData
    {
      [Token(Token = "0x40062E7")]
      [FieldOffset(Offset = "0x8")]
      public int ItemType;
      [Token(Token = "0x40062E8")]
      [FieldOffset(Offset = "0xC")]
      public string ItemIname;
      [Token(Token = "0x40062E9")]
      [FieldOffset(Offset = "0x10")]
      public int ItemNum;
      [Token(Token = "0x40062EA")]
      [FieldOffset(Offset = "0x14")]
      public bool IsMiss;

      [Token(Token = "0x6006E0A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CardData()
      {
      }

      [Token(Token = "0x6006E0B")]
      [Address(RVA = "0x35B3A0", Offset = "0x35A1A0", VA = "0x1035B3A0")]
      public CardData(int type, string iname, int num, int is_miss = 0)
      {
      }
    }
  }
}
