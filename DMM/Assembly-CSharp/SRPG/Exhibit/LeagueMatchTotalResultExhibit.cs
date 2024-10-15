// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchTotalResultExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003471")]
  public class LeagueMatchTotalResultExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchTotalResultModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8D5")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchTotalResultExhibit.EKey), typeof (LeagueMatchTotalResultExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E993")]
    [Address(RVA = "0xAE2950", Offset = "0xAE1750", VA = "0x10AE2950", Slot = "8")]
    public void Render(LeagueMatchTotalResultModel model)
    {
    }

    [Token(Token = "0x600E994")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchTotalResultExhibit()
    {
    }

    [Token(Token = "0x2003472")]
    private enum EKey
    {
      [Token(Token = "0x400F8D7")] None,
      [Token(Token = "0x400F8D8")] WinLoseMark1,
      [Token(Token = "0x400F8D9")] WinLoseMark2,
      [Token(Token = "0x400F8DA")] WinLoseMark3,
      [Token(Token = "0x400F8DB")] OffensePoint,
      [Token(Token = "0x400F8DC")] DefenseWinNum,
      [Token(Token = "0x400F8DD")] DefensePoint,
      [Token(Token = "0x400F8DE")] BeforeTotaPoint,
      [Token(Token = "0x400F8DF")] GetTotaPoint,
      [Token(Token = "0x400F8E0")] RankIcon,
      [Token(Token = "0x400F8E1")] RankName,
    }
  }
}
