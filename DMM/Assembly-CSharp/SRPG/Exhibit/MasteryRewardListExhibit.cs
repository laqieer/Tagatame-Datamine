// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.MasteryRewardListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200347B")]
  public class MasteryRewardListExhibit : 
    BaseExhibit,
    IRenderModel<MasteryRewardListModel>,
    IRenderModel
  {
    [Token(Token = "0x400F90F")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (MasteryRewardListExhibit.EKey), typeof (MasteryRewardListExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9A0")]
    [Address(RVA = "0xAE47E0", Offset = "0xAE35E0", VA = "0x10AE47E0", Slot = "8")]
    public void Render(MasteryRewardListModel model)
    {
    }

    [Token(Token = "0x600E9A1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardListExhibit()
    {
    }

    [Token(Token = "0x200347C")]
    private enum EKey
    {
      [Token(Token = "0x400F911")] None,
      [Token(Token = "0x400F912")] MASTERY_REWARD_TITLE,
      [Token(Token = "0x400F913")] MASTERY_REWARD_IMAGE_OLD,
      [Token(Token = "0x400F914")] MASTERY_REWARD_IMAGE_NEW,
    }
  }
}
