// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideBoardBonusWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034D1")]
  public class RunePrideBoardBonusWindowExhibit : 
    BaseExhibit,
    IRenderModel<RunePrideBoardBonusWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FAA7")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideBoardBonusWindowExhibit.EKey), typeof (RunePrideBoardBonusWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA27")]
    [Address(RVA = "0xAF29A0", Offset = "0xAF17A0", VA = "0x10AF29A0", Slot = "8")]
    public void Render(RunePrideBoardBonusWindowModel _model)
    {
    }

    [Token(Token = "0x600EA28")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideBoardBonusWindowExhibit()
    {
    }

    [Token(Token = "0x20034D2")]
    private enum EKey
    {
      [Token(Token = "0x400FAA9")] None,
      [Token(Token = "0x400FAAA")] TitleText,
      [Token(Token = "0x400FAAB")] BonusNum,
      [Token(Token = "0x400FAAC")] AddBonusNum,
    }
  }
}
