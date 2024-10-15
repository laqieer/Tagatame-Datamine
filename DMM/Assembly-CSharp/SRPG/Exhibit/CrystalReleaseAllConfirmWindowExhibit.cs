// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalReleaseAllConfirmWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003425")]
  public class CrystalReleaseAllConfirmWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalReleaseAllConfirmWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F75F")]
    [FieldOffset(Offset = "0x34")]
    public ExhibitList mExhibitList;
    [Token(Token = "0x400F760")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalReleaseAllConfirmWindowExhibit.EKey), typeof (CrystalReleaseAllConfirmWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E914")]
    [Address(RVA = "0xADB110", Offset = "0xAD9F10", VA = "0x10ADB110", Slot = "8")]
    public void Render(CrystalReleaseAllConfirmWindowModel _model)
    {
    }

    [Token(Token = "0x600E915")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalReleaseAllConfirmWindowExhibit()
    {
    }

    [Token(Token = "0x2003426")]
    private enum EKey
    {
      [Token(Token = "0x400F762")] None,
      [Token(Token = "0x400F763")] UnitIcon,
      [Token(Token = "0x400F764")] QuestBadge,
      [Token(Token = "0x400F765")] ArenaBadge,
      [Token(Token = "0x400F766")] SupportBadge,
      [Token(Token = "0x400F767")] GvGBadge,
      [Token(Token = "0x400F768")] LeagueMatchBadge,
    }
  }
}
