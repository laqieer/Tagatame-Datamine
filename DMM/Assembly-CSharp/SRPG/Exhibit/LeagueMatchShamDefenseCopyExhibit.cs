// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchShamDefenseCopyExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200345F")]
  public class LeagueMatchShamDefenseCopyExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchShamDefenseCopyModel>,
    IRenderModel
  {
    [Token(Token = "0x400F86A")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchShamDefenseCopyExhibit.EKey), typeof (LeagueMatchShamDefenseCopyExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E97A")]
    [Address(RVA = "0xAE1FB0", Offset = "0xAE0DB0", VA = "0x10AE1FB0", Slot = "8")]
    public void Render(LeagueMatchShamDefenseCopyModel model)
    {
    }

    [Token(Token = "0x600E97B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchShamDefenseCopyExhibit()
    {
    }

    [Token(Token = "0x2003460")]
    private enum EKey
    {
      [Token(Token = "0x400F86C")] None,
      [Token(Token = "0x400F86D")] Message,
    }
  }
}
