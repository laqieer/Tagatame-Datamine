// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchRankingInfoExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003461")]
  public class LeagueMatchRankingInfoExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchRankingInfoModel>,
    IRenderModel
  {
    [Token(Token = "0x400F86E")]
    [FieldOffset(Offset = "0x34")]
    private List<RewardIcon> mRewardIcons;
    [Token(Token = "0x400F86F")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchRankingInfoExhibit.EKey), typeof (LeagueMatchRankingInfoExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F870")]
    [FieldOffset(Offset = "0x3C")]
    public RewardIcon m_RewardIconTemplete;

    [Token(Token = "0x600E97C")]
    [Address(RVA = "0xAE0B30", Offset = "0xADF930", VA = "0x10AE0B30", Slot = "8")]
    public void Render(LeagueMatchRankingInfoModel model)
    {
    }

    [Token(Token = "0x600E97D")]
    [Address(RVA = "0xAE0790", Offset = "0xADF590", VA = "0x10AE0790")]
    private void CreateRewardIcon(LeagueMatchRewardParam reward_param)
    {
    }

    [Token(Token = "0x600E97E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRankingInfoExhibit()
    {
    }

    [Token(Token = "0x2003462")]
    private enum EKey
    {
      [Token(Token = "0x400F872")] None,
      [Token(Token = "0x400F873")] RankIcon,
      [Token(Token = "0x400F874")] RankName,
      [Token(Token = "0x400F875")] IsBelong,
      [Token(Token = "0x400F876")] RankRateMin,
      [Token(Token = "0x400F877")] RankRateMax,
      [Token(Token = "0x400F878")] IsDispMin,
      [Token(Token = "0x400F879")] IsDispMax,
      [Token(Token = "0x400F87A")] IsDispSubLetter,
      [Token(Token = "0x400F87B")] RewardIcon,
      [Token(Token = "0x400F87C")] IsDispRankChar,
      [Token(Token = "0x400F87D")] IsDispPointChar,
    }
  }
}
