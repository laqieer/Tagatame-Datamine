// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.MasteryRewardEntranceButtonExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003473")]
  public class MasteryRewardEntranceButtonExhibit : 
    BaseExhibit,
    IRenderModel<MasteryRewardEntranceButtonModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8E2")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (MasteryRewardEntranceButtonExhibit.EKey), typeof (MasteryRewardEntranceButtonExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E995")]
    [Address(RVA = "0xAE3260", Offset = "0xAE2060", VA = "0x10AE3260", Slot = "8")]
    public void Render(MasteryRewardEntranceButtonModel model)
    {
    }

    [Token(Token = "0x600E996")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardEntranceButtonExhibit()
    {
    }

    [Token(Token = "0x2003474")]
    private enum EKey
    {
      [Token(Token = "0x400F8E4")] None,
      [Token(Token = "0x400F8E5")] NOW_EMBLEM,
      [Token(Token = "0x400F8E6")] NEXT_NUM,
      [Token(Token = "0x400F8E7")] NEXT_MAX,
      [Token(Token = "0x400F8E8")] NEXT_BAR,
      [Token(Token = "0x400F8E9")] BUTTON_FLASH,
    }
  }
}
