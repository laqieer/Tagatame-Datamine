// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PointQuestChapterSelectorItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003487")]
  public class PointQuestChapterSelectorItemExhibit : 
    BaseExhibit,
    IRenderModel<PointQuestChapterSelectorItemModel>,
    IRenderModel
  {
    [Token(Token = "0x400F940")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PointQuestChapterSelectorItemExhibit.EKey), typeof (PointQuestChapterSelectorItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9B0")]
    [Address(RVA = "0xAE5B70", Offset = "0xAE4970", VA = "0x10AE5B70", Slot = "8")]
    public void Render(PointQuestChapterSelectorItemModel _model)
    {
    }

    [Token(Token = "0x600E9B1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestChapterSelectorItemExhibit()
    {
    }

    [Token(Token = "0x2003488")]
    private enum EKey
    {
      [Token(Token = "0x400F942")] None,
      [Token(Token = "0x400F943")] TitleText,
      [Token(Token = "0x400F944")] DispLock,
      [Token(Token = "0x400F945")] DispMesseageBox,
      [Token(Token = "0x400F946")] MesseageBoxText,
      [Token(Token = "0x400F947")] IconImage,
    }
  }
}
