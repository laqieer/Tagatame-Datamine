// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneReplaceFilterWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034C3")]
  public class RuneReplaceFilterWindowExhibit : 
    BaseExhibit,
    IRenderModel<RuneReplaceFilterWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA63")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneReplaceFilterWindowExhibit.EKey), typeof (RuneReplaceFilterWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA13")]
    [Address(RVA = "0xAF5C70", Offset = "0xAF4A70", VA = "0x10AF5C70", Slot = "8")]
    public void Render(RuneReplaceFilterWindowModel model)
    {
    }

    [Token(Token = "0x600EA14")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneReplaceFilterWindowExhibit()
    {
    }

    [Token(Token = "0x20034C4")]
    public enum EKey
    {
      [Token(Token = "0x400FA65")] None,
      [Token(Token = "0x400FA66")] Rarity,
      [Token(Token = "0x400FA67")] SetEff,
      [Token(Token = "0x400FA68")] ActivateSetEff,
      [Token(Token = "0x400FA69")] EvoStatus,
    }
  }
}
