// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.NameSearchBoxExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003481")]
  public class NameSearchBoxExhibit : BaseExhibit, IRenderModel<NameSearchBoxModel>, IRenderModel
  {
    [Token(Token = "0x400F923")]
    [FieldOffset(Offset = "0x34")]
    private readonly string NAMESEARCHBOX_BTN_OPEN_TEXT;
    [Token(Token = "0x400F924")]
    [FieldOffset(Offset = "0x38")]
    private readonly string NAMESEARCHBOX_BTN_CLOSE_TEXT;
    [Token(Token = "0x400F925")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (NameSearchBoxExhibit.EKey), typeof (NameSearchBoxExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E9A9")]
    [Address(RVA = "0xAE4D50", Offset = "0xAE3B50", VA = "0x10AE4D50", Slot = "6")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600E9AA")]
    [Address(RVA = "0xAE4E80", Offset = "0xAE3C80", VA = "0x10AE4E80", Slot = "8")]
    public void Render(NameSearchBoxModel model)
    {
    }

    [Token(Token = "0x600E9AB")]
    [Address(RVA = "0xAE5090", Offset = "0xAE3E90", VA = "0x10AE5090")]
    public NameSearchBoxExhibit()
    {
    }

    [Token(Token = "0x2003482")]
    private enum EKey
    {
      [Token(Token = "0x400F927")] None,
      [Token(Token = "0x400F928")] SUB_WINDOW,
      [Token(Token = "0x400F929")] OPEN_BUTTON,
      [Token(Token = "0x400F92A")] OPEN_BUTTON_IMAGE,
      [Token(Token = "0x400F92B")] OPEN_BUTTON_TEXT_EMPTY,
      [Token(Token = "0x400F92C")] OPEN_BUTTON_TEXT_INPUT,
      [Token(Token = "0x400F92D")] CLOSE_BUTTON,
      [Token(Token = "0x400F92E")] CLOSE_BUTTON_IMAGE,
      [Token(Token = "0x400F92F")] CLOSE_BUTTON_TEXT_EMPTY,
      [Token(Token = "0x400F930")] CLOSE_BUTTON_TEXT_INPUT,
      [Token(Token = "0x400F931")] OPEN_BUTTON_TEXT,
      [Token(Token = "0x400F932")] CLOSE_BUTTON_TEXT,
    }
  }
}
