// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDisassemblyResultExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034AA")]
  public class RuneDisassemblyResultExhibit : 
    BaseExhibit,
    IRenderModel<RuneDisassemblyResultModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA08")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDisassemblyResultExhibit.EKey), typeof (RuneDisassemblyResultExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E9F0")]
    [Address(RVA = "0xAF0C60", Offset = "0xAEFA60", VA = "0x10AF0C60", Slot = "8")]
    public void Render(RuneDisassemblyResultModel model)
    {
    }

    [Token(Token = "0x600E9F1")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDisassemblyResultExhibit()
    {
    }

    [Token(Token = "0x20034AB")]
    private enum EKey
    {
      [Token(Token = "0x400FA0A")] None,
      [Token(Token = "0x400FA0B")] Icon,
      [Token(Token = "0x400FA0C")] Title,
      [Token(Token = "0x400FA0D")] Num,
    }
  }
}
