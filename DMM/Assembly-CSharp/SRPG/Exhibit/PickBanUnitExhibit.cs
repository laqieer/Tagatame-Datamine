// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PickBanUnitExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200347D")]
  public class PickBanUnitExhibit : BaseExhibit, IRenderModel<PickBanUnitModel>, IRenderModel
  {
    [Token(Token = "0x400F915")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PickBanUnitExhibit.EKey), typeof (PickBanUnitExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E9A2")]
    [Address(RVA = "0xAE5560", Offset = "0xAE4360", VA = "0x10AE5560", Slot = "8")]
    public void Render(PickBanUnitModel model)
    {
    }

    [Token(Token = "0x600E9A3")]
    [Address(RVA = "0xAE5530", Offset = "0xAE4330", VA = "0x10AE5530")]
    private void UnitLock(PickBanUnitModel model)
    {
    }

    [Token(Token = "0x600E9A4")]
    [Address(RVA = "0xAE5770", Offset = "0xAE4570", VA = "0x10AE5770")]
    private void SelectButton(PickBanUnitModel model)
    {
    }

    [Token(Token = "0x600E9A5")]
    [Address(RVA = "0xAE5530", Offset = "0xAE4330", VA = "0x10AE5530")]
    private void Mask(PickBanUnitModel model)
    {
    }

    [Token(Token = "0x600E9A6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PickBanUnitExhibit()
    {
    }

    [Token(Token = "0x200347E")]
    private enum EKey
    {
      [Token(Token = "0x400F917")] LOCK,
      [Token(Token = "0x400F918")] BUTTON,
      [Token(Token = "0x400F919")] MASK,
    }
  }
}
