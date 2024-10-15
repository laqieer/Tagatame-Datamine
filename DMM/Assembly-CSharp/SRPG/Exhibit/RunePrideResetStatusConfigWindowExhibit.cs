// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideResetStatusConfigWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034E3")]
  public class RunePrideResetStatusConfigWindowExhibit : 
    BaseExhibit,
    IRenderModel<RunePrideResetStatusConfigWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB0F")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideResetStatusConfigWindowExhibit.EKey), typeof (RunePrideResetStatusConfigWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA4A")]
    [Address(RVA = "0xAF4E60", Offset = "0xAF3C60", VA = "0x10AF4E60", Slot = "8")]
    public void Render(RunePrideResetStatusConfigWindowModel _model)
    {
    }

    [Token(Token = "0x600EA4B")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideResetStatusConfigWindowExhibit()
    {
    }

    [Token(Token = "0x20034E4")]
    private enum EKey
    {
      [Token(Token = "0x400FB11")] None,
      [Token(Token = "0x400FB12")] EffectName,
      [Token(Token = "0x400FB13")] Slider,
      [Token(Token = "0x400FB14")] TargetStatusNum,
    }
  }
}
