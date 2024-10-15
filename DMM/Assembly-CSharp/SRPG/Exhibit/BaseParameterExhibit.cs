// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.BaseParameterExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034CB")]
  public class BaseParameterExhibit : BaseExhibit, IRenderModel<BaseParameterModel>, IRenderModel
  {
    [Token(Token = "0x400FA81")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (BaseParameterExhibit.BaseEKey), typeof (BaseParameterExhibit))]
    public string m_BaseKeyName;
    [Token(Token = "0x400FA82")]
    [FieldOffset(Offset = "0x38")]
    private BaseParameterModel model;

    [Token(Token = "0x600EA1F")]
    [Address(RVA = "0xAE7380", Offset = "0xAE6180", VA = "0x10AE7380", Slot = "8")]
    public void Render(BaseParameterModel model)
    {
    }

    [Token(Token = "0x600EA20")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public BaseParameterExhibit()
    {
    }

    [Token(Token = "0x20034CC")]
    private enum BaseEKey
    {
      [Token(Token = "0x400FA84")] None,
      [Token(Token = "0x400FA85")] Parameter,
    }
  }
}
