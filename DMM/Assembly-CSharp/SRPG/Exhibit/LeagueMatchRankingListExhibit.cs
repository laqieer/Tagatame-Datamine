// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchRankingListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003463")]
  public class LeagueMatchRankingListExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchRankingListModel>,
    IRenderModel
  {
    [Token(Token = "0x400F87E")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchRankingListExhibit.EKey), typeof (LeagueMatchRankingListExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F87F")]
    [FieldOffset(Offset = "0x38")]
    public UnitIcon m_UnitIconTemplete;
    [Token(Token = "0x400F880")]
    [FieldOffset(Offset = "0x3C")]
    public AwardItem m_AwardItemTemplate;
    [Token(Token = "0x400F881")]
    [FieldOffset(Offset = "0x40")]
    public SerializeValueBehaviour m_SvbTemplate;

    [Token(Token = "0x600E97F")]
    [Address(RVA = "0xAE0DE0", Offset = "0xADFBE0", VA = "0x10AE0DE0", Slot = "8")]
    public void Render(LeagueMatchRankingListModel model)
    {
    }

    [Token(Token = "0x600E980")]
    [Address(RVA = "0xAE1430", Offset = "0xAE0230", VA = "0x10AE1430")]
    private void SetPortDetail(int _portId)
    {
    }

    [Token(Token = "0x600E981")]
    [Address(RVA = "0xAE14E0", Offset = "0xAE02E0", VA = "0x10AE14E0")]
    private void SetUserIcon(UnitData _unitData)
    {
    }

    [Token(Token = "0x600E982")]
    [Address(RVA = "0xAE1320", Offset = "0xAE0120", VA = "0x10AE1320")]
    private void SetAward(string _award)
    {
    }

    [Token(Token = "0x600E983")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRankingListExhibit()
    {
    }

    [Token(Token = "0x2003464")]
    private enum EKey
    {
      [Token(Token = "0x400F883")] None,
      [Token(Token = "0x400F884")] PlayerName,
      [Token(Token = "0x400F885")] Point,
      [Token(Token = "0x400F886")] UserIcon,
      [Token(Token = "0x400F887")] Level,
      [Token(Token = "0x400F888")] Award,
      [Token(Token = "0x400F889")] IsBelongPort,
      [Token(Token = "0x400F88A")] PortName,
      [Token(Token = "0x400F88B")] PortDetail,
      [Token(Token = "0x400F88C")] RankIcon,
      [Token(Token = "0x400F88D")] RankImage,
      [Token(Token = "0x400F88E")] Rank,
      [Token(Token = "0x400F88F")] IsActiveRankText,
      [Token(Token = "0x400F890")] IsActiveOutOfRankText,
    }
  }
}
