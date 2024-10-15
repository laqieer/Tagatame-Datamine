// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePridePotentialBonusParameterExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034DF")]
  public class RunePridePotentialBonusParameterExhibit : 
    BaseParameterExhibit,
    IRenderModel<RunePridePotentialBonusParameterModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB02")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePridePotentialBonusParameterExhibit.EKey), typeof (RunePridePotentialBonusParameterExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA46")]
    [Address(RVA = "0xAF4B20", Offset = "0xAF3920", VA = "0x10AF4B20", Slot = "9")]
    public void Render(RunePridePotentialBonusParameterModel _model)
    {
    }

    [Token(Token = "0x600EA47")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePridePotentialBonusParameterExhibit()
    {
    }

    [Token(Token = "0x20034E0")]
    private enum EKey
    {
      [Token(Token = "0x400FB04")] None,
      [Token(Token = "0x400FB05")] Opened,
      [Token(Token = "0x400FB06")] CanOpen,
      [Token(Token = "0x400FB07")] CannotOpen,
      [Token(Token = "0x400FB08")] OnSelect,
    }
  }
}
