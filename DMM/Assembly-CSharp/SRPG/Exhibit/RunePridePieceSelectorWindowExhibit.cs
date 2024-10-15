// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePridePieceSelectorWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034DD")]
  public class RunePridePieceSelectorWindowExhibit : 
    BaseExhibit,
    IRenderModel<RunePridePieceSelectorWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FAF7")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePridePieceSelectorWindowExhibit.EKey), typeof (RunePridePieceSelectorWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA44")]
    [Address(RVA = "0xAF4890", Offset = "0xAF3690", VA = "0x10AF4890", Slot = "8")]
    public void Render(RunePridePieceSelectorWindowModel _model)
    {
    }

    [Token(Token = "0x600EA45")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePridePieceSelectorWindowExhibit()
    {
    }

    [Token(Token = "0x20034DE")]
    private enum EKey
    {
      [Token(Token = "0x400FAF9")] None,
      [Token(Token = "0x400FAFA")] Title,
      [Token(Token = "0x400FAFB")] NeedAmount,
      [Token(Token = "0x400FAFC")] SelectAmount,
      [Token(Token = "0x400FAFD")] ClearButton,
      [Token(Token = "0x400FAFE")] MaxButton,
      [Token(Token = "0x400FAFF")] CancelButton,
      [Token(Token = "0x400FB00")] OkButton,
      [Token(Token = "0x400FB01")] ConfigButton,
    }
  }
}
