// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.MasteryRewardEntranceExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003475")]
  public class MasteryRewardEntranceExhibit : 
    BaseExhibit,
    IRenderModel<MasteryRewardEntranceModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8EA")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (MasteryRewardEntranceExhibit.EKey), typeof (MasteryRewardEntranceExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F8EB")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("表示切替：MasteryReward入口")]
    [CustomField("表示：一致", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_TrueObject;
    [Token(Token = "0x400F8EC")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("表示：不一致", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("表示切替：MasteryReward入口")]
    public GameObject m_FalseObject;

    [Token(Token = "0x600E997")]
    [Address(RVA = "0xAE34F0", Offset = "0xAE22F0", VA = "0x10AE34F0", Slot = "8")]
    public void Render(MasteryRewardEntranceModel model)
    {
    }

    [Token(Token = "0x600E998")]
    [Address(RVA = "0xAE3480", Offset = "0xAE2280", VA = "0x10AE3480")]
    public void MasteryRewardDisplay(bool flag)
    {
    }

    [Token(Token = "0x600E999")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardEntranceExhibit()
    {
    }

    [Token(Token = "0x2003476")]
    private enum EKey
    {
      [Token(Token = "0x400F8EE")] None,
      [Token(Token = "0x400F8EF")] MASTERY_REWARD_DISPLAY,
      [Token(Token = "0x400F8F0")] DISP_OBJECT,
    }
  }
}
