// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchRankEffExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200346B")]
  public class LeagueMatchRankEffExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchRankEffModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8B9")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchRankEffExhibit.EKey), typeof (LeagueMatchRankEffExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F8BA")]
    private const int MAX_FRAME = 60;

    [Token(Token = "0x600E98C")]
    [Address(RVA = "0xAE0650", Offset = "0xADF450", VA = "0x10AE0650", Slot = "8")]
    public void Render(LeagueMatchRankEffModel model)
    {
    }

    [Token(Token = "0x600E98D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRankEffExhibit()
    {
    }

    [Token(Token = "0x200346C")]
    private enum EKey
    {
      [Token(Token = "0x400F8BC")] None,
      [Token(Token = "0x400F8BD")] BeforeRankIcon,
      [Token(Token = "0x400F8BE")] AfterRankIcon,
    }
  }
}
