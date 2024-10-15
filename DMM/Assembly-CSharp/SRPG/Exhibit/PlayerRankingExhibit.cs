// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PlayerRankingExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003497")]
  public class PlayerRankingExhibit : BaseExhibit, IRenderModel<PlayerRankingModel>, IRenderModel
  {
    [Token(Token = "0x400F9A8")]
    private const int OUT_OF_RANK_VALUE = -1;
    [Token(Token = "0x400F9A9")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PlayerRankingExhibit.EKey), typeof (PlayerRankingExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F9AA")]
    [FieldOffset(Offset = "0x38")]
    public AwardItem m_AwardItemTemplate;

    [Token(Token = "0x600E9CF")]
    [Address(RVA = "0xAEC7A0", Offset = "0xAEB5A0", VA = "0x10AEC7A0", Slot = "8")]
    public void Render(PlayerRankingModel _model)
    {
    }

    [Token(Token = "0x600E9D0")]
    [Address(RVA = "0xAECB40", Offset = "0xAEB940", VA = "0x10AECB40")]
    private void SetAward(string _award)
    {
    }

    [Token(Token = "0x600E9D1")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public PlayerRankingExhibit()
    {
    }

    [Token(Token = "0x2003498")]
    private enum EKey
    {
      [Token(Token = "0x400F9AC")] None,
      [Token(Token = "0x400F9AD")] RankText,
      [Token(Token = "0x400F9AE")] RankImage,
      [Token(Token = "0x400F9AF")] UnitIcon,
      [Token(Token = "0x400F9B0")] Name,
      [Token(Token = "0x400F9B1")] Level,
      [Token(Token = "0x400F9B2")] Award,
      [Token(Token = "0x400F9B3")] CombatPower,
      [Token(Token = "0x400F9B4")] PortName,
      [Token(Token = "0x400F9B5")] PortNone,
      [Token(Token = "0x400F9B6")] PortActive,
      [Token(Token = "0x400F9B7")] CombatPowerText,
    }
  }
}
