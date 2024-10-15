// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchMapListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200345B")]
  public class LeagueMatchMapListExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchMapListModel>,
    IRenderModel
  {
    [Token(Token = "0x400F854")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchMapListExhibit.EKey), typeof (LeagueMatchMapListExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E974")]
    [Address(RVA = "0xADFEA0", Offset = "0xADECA0", VA = "0x10ADFEA0", Slot = "8")]
    public void Render(LeagueMatchMapListModel model)
    {
    }

    [Token(Token = "0x600E975")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchMapListExhibit()
    {
    }

    [Token(Token = "0x200345C")]
    private enum EKey
    {
      [Token(Token = "0x400F856")] None,
      [Token(Token = "0x400F857")] NowPage,
      [Token(Token = "0x400F858")] PageMax,
      [Token(Token = "0x400F859")] PrevBtn,
      [Token(Token = "0x400F85A")] NextBtn,
    }
  }
}
