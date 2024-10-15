// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PointQuestChapterSelectorExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003485")]
  public class PointQuestChapterSelectorExhibit : 
    BaseExhibit,
    IRenderModel<PointQuestChapterSelectorModel>,
    IRenderModel
  {
    [Token(Token = "0x400F938")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PointQuestChapterSelectorExhibit.EKey), typeof (PointQuestChapterSelectorExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9AE")]
    [Address(RVA = "0xAE5970", Offset = "0xAE4770", VA = "0x10AE5970", Slot = "8")]
    public void Render(PointQuestChapterSelectorModel _model)
    {
    }

    [Token(Token = "0x600E9AF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestChapterSelectorExhibit()
    {
    }

    [Token(Token = "0x2003486")]
    private enum EKey
    {
      [Token(Token = "0x400F93A")] None,
      [Token(Token = "0x400F93B")] TitleText,
      [Token(Token = "0x400F93C")] ClearCount,
      [Token(Token = "0x400F93D")] QuestCount,
      [Token(Token = "0x400F93E")] LeftArrowButton,
      [Token(Token = "0x400F93F")] RightArrowButton,
    }
  }
}
