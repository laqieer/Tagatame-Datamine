// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PointQuestRankingTabExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200348D")]
  public class PointQuestRankingTabExhibit : 
    BaseExhibit,
    IRenderModel<PointQuestRankingTabModel>,
    IRenderModel
  {
    [Token(Token = "0x400F965")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PointQuestRankingTabExhibit.EKey), typeof (PointQuestRankingTabExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9B7")]
    [Address(RVA = "0xAE6400", Offset = "0xAE5200", VA = "0x10AE6400", Slot = "8")]
    public void Render(PointQuestRankingTabModel model)
    {
    }

    [Token(Token = "0x600E9B8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestRankingTabExhibit()
    {
    }

    [Token(Token = "0x200348E")]
    private enum EKey
    {
      [Token(Token = "0x400F967")] None,
      [Token(Token = "0x400F968")] Text,
      [Token(Token = "0x400F969")] On,
    }
  }
}
