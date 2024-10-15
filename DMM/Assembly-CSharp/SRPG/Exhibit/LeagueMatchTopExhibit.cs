// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchTopExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200346F")]
  public class LeagueMatchTopExhibit : BaseExhibit, IRenderModel<LeagueMatchTopModel>, IRenderModel
  {
    [Token(Token = "0x400F8C7")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchTopExhibit.EKey), typeof (LeagueMatchTopExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E991")]
    [Address(RVA = "0xAE2690", Offset = "0xAE1490", VA = "0x10AE2690", Slot = "8")]
    public void Render(LeagueMatchTopModel model)
    {
    }

    [Token(Token = "0x600E992")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchTopExhibit()
    {
    }

    [Token(Token = "0x2003470")]
    private enum EKey
    {
      [Token(Token = "0x400F8C9")] None,
      [Token(Token = "0x400F8CA"), CustomEnumDesc("ランクアイコン（SpriteSheet）")] RankIcon,
      [Token(Token = "0x400F8CB"), CustomEnumDesc("ランク名（SpriteSheet）")] RankName,
      [Token(Token = "0x400F8CC")] GetPoint,
      [Token(Token = "0x400F8CD")] WinLoseMark1,
      [Token(Token = "0x400F8CE")] WinLoseMark2,
      [Token(Token = "0x400F8CF")] WinLoseMark3,
      [Token(Token = "0x400F8D0")] ChallengeCount,
      [Token(Token = "0x400F8D1")] ChallengeCountMax,
      [Token(Token = "0x400F8D2")] ShowRanking,
      [Token(Token = "0x400F8D3")] ShowShop,
      [Token(Token = "0x400F8D4")] ShowDefense,
    }
  }
}
