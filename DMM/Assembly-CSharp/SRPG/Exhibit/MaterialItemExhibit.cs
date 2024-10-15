// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.MaterialItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003441")]
  public class MaterialItemExhibit : BaseItemExhibit, IRenderModel<MaterialItemModel>, IRenderModel
  {
    [Token(Token = "0x400F7C0")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (MaterialItemExhibit.EKey), typeof (MaterialItemExhibit))]
    public string materialItem_KeyName;

    [Token(Token = "0x600E954")]
    [Address(RVA = "0xAE4970", Offset = "0xAE3770", VA = "0x10AE4970", Slot = "9")]
    public void Render(MaterialItemModel model)
    {
    }

    [Token(Token = "0x600E955")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MaterialItemExhibit()
    {
    }

    [Token(Token = "0x2003442")]
    private enum EKey
    {
      [Token(Token = "0x400F7C2")] None,
      [Token(Token = "0x400F7C3")] RequiredAmout,
    }
  }
}
