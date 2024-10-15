// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.NamePlateExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200347F")]
  public class NamePlateExhibit : BaseExhibit, IRenderModel<NamePlateModel>, IRenderModel
  {
    [Token(Token = "0x400F91A")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (NamePlateExhibit.EKey), typeof (NamePlateExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E9A7")]
    [Address(RVA = "0xAE4AA0", Offset = "0xAE38A0", VA = "0x10AE4AA0", Slot = "8")]
    public void Render(NamePlateModel model)
    {
    }

    [Token(Token = "0x600E9A8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NamePlateExhibit()
    {
    }

    [Token(Token = "0x2003480")]
    private enum EKey
    {
      [Token(Token = "0x400F91C")] None,
      [Token(Token = "0x400F91D")] Element,
      [Token(Token = "0x400F91E")] Name,
      [Token(Token = "0x400F91F")] Birth,
      [Token(Token = "0x400F920")] HideElement,
      [Token(Token = "0x400F921")] HideName,
      [Token(Token = "0x400F922")] HideBirth,
    }
  }
}
