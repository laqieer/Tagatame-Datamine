// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchMissionExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200345D")]
  public class LeagueMatchMissionExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchMissionModel>,
    IRenderModel
  {
    [Token(Token = "0x400F85B")]
    [FieldOffset(Offset = "0x34")]
    private string _iname;
    [Token(Token = "0x400F85C")]
    [FieldOffset(Offset = "0x38")]
    private List<RewardIcon> mRewardIcons;
    [Token(Token = "0x400F85D")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchMissionExhibit.EKey), typeof (LeagueMatchMissionExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F85E")]
    [FieldOffset(Offset = "0x40")]
    public RewardIcon m_RewardIconTemplete;

    [Token(Token = "0x1700216D")]
    public string Iname
    {
      [Token(Token = "0x600E976"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E977")]
    [Address(RVA = "0xAE0420", Offset = "0xADF220", VA = "0x10AE0420", Slot = "8")]
    public void Render(LeagueMatchMissionModel model)
    {
    }

    [Token(Token = "0x600E978")]
    [Address(RVA = "0xAE0080", Offset = "0xADEE80", VA = "0x10AE0080")]
    private void CreateRewardIcon(LeagueMatchRewardParam reward_param)
    {
    }

    [Token(Token = "0x600E979")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchMissionExhibit()
    {
    }

    [Token(Token = "0x200345E")]
    private enum EKey
    {
      [Token(Token = "0x400F860")] None,
      [Token(Token = "0x400F861")] Name,
      [Token(Token = "0x400F862")] Explain,
      [Token(Token = "0x400F863")] NotClearObj,
      [Token(Token = "0x400F864")] ClearObj,
      [Token(Token = "0x400F865")] ReceivedObj,
      [Token(Token = "0x400F866")] ReceiveBtn,
      [Token(Token = "0x400F867")] CountTxtProg,
      [Token(Token = "0x400F868")] CountTxtIval,
      [Token(Token = "0x400F869")] RewardIcon,
    }
  }
}
