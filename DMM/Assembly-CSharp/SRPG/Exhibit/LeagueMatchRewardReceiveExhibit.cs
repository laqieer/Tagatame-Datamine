// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchRewardReceiveExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200346D")]
  public class LeagueMatchRewardReceiveExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchRewardReceiveModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8BF")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchRewardReceiveExhibit.EKey), typeof (LeagueMatchRewardReceiveExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F8C0")]
    [FieldOffset(Offset = "0x38")]
    public Transform mRewardRoot;

    [Token(Token = "0x600E98E")]
    [Address(RVA = "0xAE1DE0", Offset = "0xAE0BE0", VA = "0x10AE1DE0", Slot = "8")]
    public void Render(LeagueMatchRewardReceiveModel model)
    {
    }

    [Token(Token = "0x600E98F")]
    [Address(RVA = "0xAE1D50", Offset = "0xAE0B50", VA = "0x10AE1D50")]
    private void CreateRewardIcon(
      LeagueMatchRewardReceiveModel model,
      JSON_LeagueMatchReward[] rewards)
    {
    }

    [Token(Token = "0x600E990")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRewardReceiveExhibit()
    {
    }

    [Token(Token = "0x200346E")]
    private enum EKey
    {
      [Token(Token = "0x400F8C2")] None,
      [Token(Token = "0x400F8C3")] SeasonRewardList,
      [Token(Token = "0x400F8C4")] DefenseRewardList,
      [Token(Token = "0x400F8C5"), CustomEnumDesc("ランクアイコン（SpriteSheet）")] SeasonRankIcon,
      [Token(Token = "0x400F8C6"), CustomEnumDesc("ランク名（SpriteSheet）")] SeasonRankName,
    }
  }
}
