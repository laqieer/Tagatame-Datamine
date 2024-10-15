// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.AllUnitEquipBulkReleaseConfirmWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003427")]
  public class AllUnitEquipBulkReleaseConfirmWindowExhibit : 
    BaseExhibit,
    IRenderModel<AllUnitEquipBulkReleaseConfirmWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F769")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (AllUnitEquipBulkReleaseConfirmWindowExhibit.EKey), typeof (AllUnitEquipBulkReleaseConfirmWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E916")]
    [Address(RVA = "0xAD5760", Offset = "0xAD4560", VA = "0x10AD5760", Slot = "8")]
    public void Render(AllUnitEquipBulkReleaseConfirmWindowModel model)
    {
    }

    [Token(Token = "0x600E917")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AllUnitEquipBulkReleaseConfirmWindowExhibit()
    {
    }

    [Token(Token = "0x2003428")]
    private enum EKey
    {
      [Token(Token = "0x400F76B")] None,
      [Token(Token = "0x400F76C")] TitleText,
      [Token(Token = "0x400F76D")] MainText,
      [Token(Token = "0x400F76E")] SubTextVisible,
      [Token(Token = "0x400F76F")] OKButtonIntaractable,
    }
  }
}
