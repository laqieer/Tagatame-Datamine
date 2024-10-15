// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneReplaceFilterTabExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034C1")]
  public class RuneReplaceFilterTabExhibit : 
    BaseExhibit,
    IRenderModel<RuneReplaceFilterTabModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA5D")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneReplaceFilterTabExhibit.EKey), typeof (RuneReplaceFilterTabExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA11")]
    [Address(RVA = "0xAF5B20", Offset = "0xAF4920", VA = "0x10AF5B20", Slot = "8")]
    public void Render(RuneReplaceFilterTabModel model)
    {
    }

    [Token(Token = "0x600EA12")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneReplaceFilterTabExhibit()
    {
    }

    [Token(Token = "0x20034C2")]
    private enum EKey
    {
      [Token(Token = "0x400FA5F")] None,
      [Token(Token = "0x400FA60")] TabText,
      [Token(Token = "0x400FA61")] DefaultObject,
      [Token(Token = "0x400FA62")] FilteredObject,
    }
  }
}
