// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchMapExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003459")]
  public class LeagueMatchMapExhibit : BaseExhibit, IRenderModel<LeagueMatchMapModel>, IRenderModel
  {
    [Token(Token = "0x400F84A")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchMapExhibit.EKey), typeof (LeagueMatchMapExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E972")]
    [Address(RVA = "0xADFC40", Offset = "0xADEA40", VA = "0x10ADFC40", Slot = "8")]
    public void Render(LeagueMatchMapModel model)
    {
    }

    [Token(Token = "0x600E973")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchMapExhibit()
    {
    }

    [Token(Token = "0x200345A")]
    private enum EKey
    {
      [Token(Token = "0x400F84C")] None,
      [Token(Token = "0x400F84D")] MapImage,
      [Token(Token = "0x400F84E")] MapName,
      [Token(Token = "0x400F84F")] MapDescription,
      [Token(Token = "0x400F850")] IsSelectImage,
      [Token(Token = "0x400F851")] IsHideImage,
      [Token(Token = "0x400F852")] DefenceMapBadge,
      [Token(Token = "0x400F853")] IsInvalid,
    }
  }
}
