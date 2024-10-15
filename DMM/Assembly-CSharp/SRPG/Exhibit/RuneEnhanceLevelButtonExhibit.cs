// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneEnhanceLevelButtonExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034B9")]
  public class RuneEnhanceLevelButtonExhibit : 
    BaseExhibit,
    IRenderModel<RuneEnhanceLevelButtonModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA44")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneEnhanceLevelButtonExhibit.EKey), typeof (RuneEnhanceLevelButtonExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA07")]
    [Address(RVA = "0xAF1EC0", Offset = "0xAF0CC0", VA = "0x10AF1EC0", Slot = "8")]
    public void Render(RuneEnhanceLevelButtonModel model)
    {
    }

    [Token(Token = "0x600EA08")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneEnhanceLevelButtonExhibit()
    {
    }

    [Token(Token = "0x20034BA")]
    private enum EKey
    {
      [Token(Token = "0x400FA46")] None,
      [Token(Token = "0x400FA47")] Button,
      [Token(Token = "0x400FA48")] ImageArray,
    }
  }
}
