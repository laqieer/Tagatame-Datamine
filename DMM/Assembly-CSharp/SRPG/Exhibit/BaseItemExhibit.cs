// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.BaseItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200343F")]
  public class BaseItemExhibit : BaseExhibit, IRenderModel<BaseItemModel>, IRenderModel
  {
    [Token(Token = "0x400F7B7")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("ベースタイプ", CustomFieldAttribute.Type.EnumString, typeof (BaseItemExhibit.BaseEKey), typeof (BaseItemExhibit))]
    public string m_BaseKeyName;

    [Token(Token = "0x600E951")]
    [Address(RVA = "0xAD74D0", Offset = "0xAD62D0", VA = "0x10AD74D0", Slot = "8")]
    public void Render(BaseItemModel model)
    {
    }

    [Token(Token = "0x600E952")]
    [Address(RVA = "0xAD7720", Offset = "0xAD6520", VA = "0x10AD7720")]
    private void ViewLimitedIcon(BaseItemModel model)
    {
    }

    [Token(Token = "0x600E953")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BaseItemExhibit()
    {
    }

    [Token(Token = "0x2003440")]
    private enum BaseEKey
    {
      [Token(Token = "0x400F7B9")] None,
      [Token(Token = "0x400F7BA")] BaseItemFrame,
      [Token(Token = "0x400F7BB")] BaseItemIconHideLimitedIcon,
      [Token(Token = "0x400F7BC")] BaseItemIconDisplayLimitedIcon,
      [Token(Token = "0x400F7BD")] BaseItemBadgeEquipUnit,
      [Token(Token = "0x400F7BE")] BaseItemAmount,
      [Token(Token = "0x400F7BF")] BaseItemName,
    }
  }
}
