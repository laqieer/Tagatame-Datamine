// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.NeedItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003443")]
  public class NeedItemExhibit : BaseItemExhibit, IRenderModel<NeedItemModel>, IRenderModel
  {
    [Token(Token = "0x400F7C4")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (NeedItemExhibit.EKey), typeof (NeedItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E956")]
    [Address(RVA = "0xAE5100", Offset = "0xAE3F00", VA = "0x10AE5100", Slot = "9")]
    public void Render(NeedItemModel _model)
    {
    }

    [Token(Token = "0x600E957")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NeedItemExhibit()
    {
    }

    [Token(Token = "0x2003444")]
    private enum EKey
    {
      [Token(Token = "0x400F7C6")] None,
      [Token(Token = "0x400F7C7")] NeedCount,
      [Token(Token = "0x400F7C8")] DispReplace,
    }
  }
}
