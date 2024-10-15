// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtifactIconBlockContentNodeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033E3")]
  public class ArtifactIconBlockContentNodeExhibit : 
    BaseExhibit,
    IRenderModel<ArtifactIconBlockContentNodeModel>,
    IRenderModel
  {
    [Token(Token = "0x400F5E6")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtifactIconBlockContentNodeExhibit.EKey), typeof (ArtifactIconBlockContentNodeExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F5E7")]
    [FieldOffset(Offset = "0x38")]
    public ExhibitList m_ExhibitList;

    [Token(Token = "0x600E8B6")]
    [Address(RVA = "0xAC4C10", Offset = "0xAC3A10", VA = "0x10AC4C10", Slot = "8")]
    public void Render(ArtifactIconBlockContentNodeModel model)
    {
    }

    [Token(Token = "0x600E8B7")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ArtifactIconBlockContentNodeExhibit()
    {
    }

    [Token(Token = "0x20033E4")]
    private enum EKey
    {
      [Token(Token = "0x400F5E9")] None,
      [Token(Token = "0x400F5EA")] ArtifactIcon,
      [Token(Token = "0x400F5EB")] ItemIcon,
      [Token(Token = "0x400F5EC")] ItemNum,
      [Token(Token = "0x400F5ED")] ItemNeedNum,
      [Token(Token = "0x400F5EE")] ArtifactExchangeNum,
    }
  }
}
