// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideLotteryDetailParameterExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034D5")]
  public class RunePrideLotteryDetailParameterExhibit : 
    BaseParameterExhibit,
    IRenderModel<RunePrideLotteryDetailParameterModel>,
    IRenderModel
  {
    [Token(Token = "0x400FAB3")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideLotteryDetailParameterExhibit.EKey), typeof (RunePrideLotteryDetailParameterExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA2B")]
    [Address(RVA = "0xAF2CD0", Offset = "0xAF1AD0", VA = "0x10AF2CD0", Slot = "9")]
    public void Render(RunePrideLotteryDetailParameterModel _model)
    {
    }

    [Token(Token = "0x600EA2C")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideLotteryDetailParameterExhibit()
    {
    }

    [Token(Token = "0x20034D6")]
    private enum EKey
    {
      [Token(Token = "0x400FAB5")] None,
      [Token(Token = "0x400FAB6")] Title,
      [Token(Token = "0x400FAB7")] Min,
      [Token(Token = "0x400FAB8")] Max,
    }
  }
}
