// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalIconExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003403")]
  public class CrystalIconExhibit : BaseExhibit, IRenderModel<CrystalIconModel>, IRenderModel
  {
    [Token(Token = "0x400F69D")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalIconExhibit.EKey), typeof (CrystalIconExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8E6")]
    [Address(RVA = "0xADA570", Offset = "0xAD9370", VA = "0x10ADA570", Slot = "8")]
    public void Render(CrystalIconModel _model)
    {
    }

    [Token(Token = "0x600E8E7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalIconExhibit()
    {
    }

    [Token(Token = "0x2003404")]
    private enum EKey
    {
      [Token(Token = "0x400F69F")] None,
      [Token(Token = "0x400F6A0")] IconImage,
      [Token(Token = "0x400F6A1")] RankDisp,
      [Token(Token = "0x400F6A2")] PlusDisp,
      [Token(Token = "0x400F6A3")] NoHavingMaskDisp,
      [Token(Token = "0x400F6A4")] RankFrameDisp,
      [Token(Token = "0x400F6A5")] FrameDispDummy,
    }
  }
}
