// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtifactStoneEffectExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033E5")]
  public class ArtifactStoneEffectExhibit : 
    BaseExhibit,
    IRenderModel<ArtifactStoneEffectModel>,
    IRenderModel
  {
    [Token(Token = "0x400F5EF")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtifactStoneEffectExhibit.EKey), typeof (ArtifactStoneEffectExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8B8")]
    [Address(RVA = "0xAC4EE0", Offset = "0xAC3CE0", VA = "0x10AC4EE0", Slot = "8")]
    public void Render(ArtifactStoneEffectModel model)
    {
    }

    [Token(Token = "0x600E8B9")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ArtifactStoneEffectExhibit()
    {
    }

    [Token(Token = "0x20033E6")]
    private enum EKey
    {
      [Token(Token = "0x400F5F1")] None,
      [Token(Token = "0x400F5F2")] EffectName,
      [Token(Token = "0x400F5F3")] EffectExpr,
      [Token(Token = "0x400F5F4")] EffectIcon,
      [Token(Token = "0x400F5F5")] StoneEffectUnOpenObj,
      [Token(Token = "0x400F5F6")] StoneEffectOpenObj,
    }
  }
}
