// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneReplaceFilterCategoryExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034BF")]
  public class RuneReplaceFilterCategoryExhibit : 
    BaseExhibit,
    IRenderModel<RuneReplaceFilterCategoryModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA59")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneReplaceFilterCategoryExhibit.EKey), typeof (RuneReplaceFilterCategoryExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA0F")]
    [Address(RVA = "0xAF5A10", Offset = "0xAF4810", VA = "0x10AF5A10", Slot = "8")]
    public void Render(RuneReplaceFilterCategoryModel model)
    {
    }

    [Token(Token = "0x600EA10")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneReplaceFilterCategoryExhibit()
    {
    }

    [Token(Token = "0x20034C0")]
    private enum EKey
    {
      [Token(Token = "0x400FA5B")] None,
      [Token(Token = "0x400FA5C")] HeaderText,
    }
  }
}
