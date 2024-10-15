// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.MasteryRewardGroupExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003479")]
  public class MasteryRewardGroupExhibit : 
    BaseExhibit,
    IRenderModel<MasteryRewardGroupModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8FD")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (MasteryRewardGroupExhibit.EKey), typeof (MasteryRewardGroupExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F8FE")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("拡張：報酬作成")]
    [CustomField("親：オブジェクト", CustomFieldAttribute.Type.GameObject)]
    public GameObject RewardParent;
    [Token(Token = "0x400F8FF")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("コピー元：ユニット", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("拡張：報酬作成")]
    public GameObject RewardUnit;
    [Token(Token = "0x400F900")]
    [FieldOffset(Offset = "0x40")]
    [CustomField("コピー元：アイテム", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("拡張：報酬作成")]
    public GameObject RewardItem;
    [Token(Token = "0x400F901")]
    [FieldOffset(Offset = "0x44")]
    [CustomGroup("拡張：報酬作成")]
    [CustomField("コピー元：コンセプトカード", CustomFieldAttribute.Type.GameObject)]
    public GameObject RewardCard;
    [Token(Token = "0x400F902")]
    [FieldOffset(Offset = "0x48")]
    [CustomGroup("拡張：報酬作成")]
    [CustomField("コピー元：武具", CustomFieldAttribute.Type.GameObject)]
    public GameObject RewardArtifact;
    [Token(Token = "0x400F903")]
    [FieldOffset(Offset = "0x4C")]
    [CustomField("コピー元：称号", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("拡張：報酬作成")]
    public GameObject RewardAward;
    [Token(Token = "0x400F904")]
    [FieldOffset(Offset = "0x50")]
    [CustomGroup("拡張：報酬作成")]
    [CustomField("コピー元：ゼニー", CustomFieldAttribute.Type.GameObject)]
    public GameObject RewardGold;
    [Token(Token = "0x400F905")]
    [FieldOffset(Offset = "0x54")]
    [CustomField("コピー元：幻晶石", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("拡張：報酬作成")]
    public GameObject RewardCoin;

    [Token(Token = "0x600E99D")]
    [Address(RVA = "0xAE3D50", Offset = "0xAE2B50", VA = "0x10AE3D50", Slot = "8")]
    public void Render(MasteryRewardGroupModel model)
    {
    }

    [Token(Token = "0x600E99E")]
    [Address(RVA = "0xAE3F90", Offset = "0xAE2D90", VA = "0x10AE3F90")]
    private void SetupRewardObject(MasteryRewardParam masteryRewardParam)
    {
    }

    [Token(Token = "0x600E99F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardGroupExhibit()
    {
    }

    [Token(Token = "0x200347A")]
    private enum EKey
    {
      [Token(Token = "0x400F907")] None,
      [Token(Token = "0x400F908")] SET_NORMAL_BG,
      [Token(Token = "0x400F909")] SET_ACHIEVEMENT_BG,
      [Token(Token = "0x400F90A")] SET_TEXT,
      [Token(Token = "0x400F90B")] SET_EMBLEM,
      [Token(Token = "0x400F90C")] COPY_REWARD,
      [Token(Token = "0x400F90D")] BADGE_RECEIVED,
      [Token(Token = "0x400F90E")] RECEIVED_COVER,
    }
  }
}
