// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.QuestArchiveExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003493")]
  public class QuestArchiveExhibit : BaseExhibit, IRenderModel<QuestArchiveModel>, IRenderModel
  {
    [Token(Token = "0x400F982")]
    [FieldOffset(Offset = "0x34")]
    private QuestArchiveModel _model;
    [Token(Token = "0x400F983")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (QuestArchiveExhibit.EKey), typeof (QuestArchiveExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F984")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("GameObject")]
    [CustomField("TimeRemaining", CustomFieldAttribute.Type.GameObject)]
    public GameObject TimeRemaining;
    [Token(Token = "0x400F985")]
    [FieldOffset(Offset = "0x40")]
    [CustomGroup("残り時間")]
    [CustomField("QuestTimeLimit", CustomFieldAttribute.Type.Component, typeof (QuestTimeLimit), null)]
    public QuestTimeLimit m_QuestTimeLimit;
    [Token(Token = "0x400F986")]
    [FieldOffset(Offset = "0x44")]
    [CustomGroup("表示切り替え")]
    [CustomField("Lock", CustomFieldAttribute.Type.GameObject)]
    public GameObject Lock;
    [Token(Token = "0x400F987")]
    [FieldOffset(Offset = "0x48")]
    [CustomGroup("表示切り替え")]
    [CustomField("OpenButton", CustomFieldAttribute.Type.GameObject)]
    public GameObject OpenButton;
    [Token(Token = "0x400F988")]
    [FieldOffset(Offset = "0x4C")]
    [CustomGroup("表示切り替え")]
    [CustomField("ChallengeButton", CustomFieldAttribute.Type.GameObject)]
    public GameObject ChallengeButton;
    [Token(Token = "0x400F989")]
    [FieldOffset(Offset = "0x50")]
    [CustomGroup("報酬ユニットアイコン")]
    [CustomField("Unit1_ExhibitList", CustomFieldAttribute.Type.Component, typeof (ExhibitList), null)]
    public ExhibitList unit1ExhibitList;
    [Token(Token = "0x400F98A")]
    [FieldOffset(Offset = "0x54")]
    [CustomGroup("報酬ユニットアイコン")]
    [CustomField("Unit2_ExhibitList", CustomFieldAttribute.Type.Component, typeof (ExhibitList), null)]
    public ExhibitList unit2ExhibitList;
    [Token(Token = "0x400F98B")]
    [FieldOffset(Offset = "0x58")]
    [CustomGroup("報酬その他アイコン")]
    [CustomField("ItemIcon", CustomFieldAttribute.Type.Component, typeof (ItemIcon), null)]
    public ItemIcon itemIcon;
    [Token(Token = "0x400F98C")]
    [FieldOffset(Offset = "0x5C")]
    [CustomField("ArtifactIcon", CustomFieldAttribute.Type.Component, typeof (ArtifactIcon), null)]
    [CustomGroup("報酬その他アイコン")]
    public ArtifactIcon artifactIcon;
    [Token(Token = "0x400F98D")]
    [FieldOffset(Offset = "0x60")]
    [CustomGroup("報酬その他アイコン")]
    [CustomField("ConceptCardIcon", CustomFieldAttribute.Type.Component, typeof (ConceptCardIcon), null)]
    public ConceptCardIcon conceptCardIcon;
    [Token(Token = "0x400F98E")]
    [FieldOffset(Offset = "0x64")]
    [CustomField("item_count", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("消費素材個数表示")]
    public GameObject item_count;
    [Token(Token = "0x400F98F")]
    [FieldOffset(Offset = "0x68")]
    [CustomField("BaseItemExhibit", CustomFieldAttribute.Type.Component, typeof (ExhibitList), null)]
    [CustomGroup("解放素材")]
    public ExhibitList baseItemExhibit;
    [Token(Token = "0x400F990")]
    [FieldOffset(Offset = "0x6C")]
    [CustomGroup("ロック中の文言設定")]
    [CustomField("Text", CustomFieldAttribute.Type.GameObject)]
    public GameObject FreeTextObject;

    [Token(Token = "0x1700216E")]
    public QuestArchiveModel ModelData
    {
      [Token(Token = "0x600E9C1"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (QuestArchiveModel) null;
      }
    }

    [Token(Token = "0x600E9C2")]
    [Address(RVA = "0xAED540", Offset = "0xAEC340", VA = "0x10AED540", Slot = "8")]
    public void Render(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C3")]
    [Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x10AEDD70")]
    private void SetQuestTime(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C4")]
    [Address(RVA = "0xAED9E0", Offset = "0xAEC7E0", VA = "0x10AED9E0")]
    private void SetBanner(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C5")]
    [Address(RVA = "0xAED2A0", Offset = "0xAEC0A0", VA = "0x10AED2A0")]
    private void RefreshUIState(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C6")]
    [Address(RVA = "0xAEE510", Offset = "0xAED310", VA = "0x10AEE510")]
    private void SetUnitIcon(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C7")]
    [Address(RVA = "0xAEDFC0", Offset = "0xAECDC0", VA = "0x10AEDFC0")]
    private void SetRewardOtherIcon(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C8")]
    [Address(RVA = "0xAEDCE0", Offset = "0xAECAE0", VA = "0x10AEDCE0")]
    private void SetKeyItemIcon(QuestArchiveModel model)
    {
    }

    [Token(Token = "0x600E9C9")]
    [Address(RVA = "0xAED290", Offset = "0xAEC090", VA = "0x10AED290")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600E9CA")]
    [Address(RVA = "0xAED440", Offset = "0xAEC240", VA = "0x10AED440")]
    private void RemoveQuestTimeLimit()
    {
    }

    [Token(Token = "0x600E9CB")]
    [Address(RVA = "0xAED230", Offset = "0xAEC030", VA = "0x10AED230")]
    private void EndQuestTimeLimit()
    {
    }

    [Token(Token = "0x600E9CC")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public QuestArchiveExhibit()
    {
    }

    [Token(Token = "0x2003494")]
    private enum EKey
    {
      [Token(Token = "0x400F992")] None,
      [Token(Token = "0x400F993")] QuestName,
      [Token(Token = "0x400F994")] QuestTimeLimit,
      [Token(Token = "0x400F995")] SetBanner,
      [Token(Token = "0x400F996")] RefreshUIState,
      [Token(Token = "0x400F997")] UnitIcon,
      [Token(Token = "0x400F998")] RewardOtherIcon,
      [Token(Token = "0x400F999")] MaterialItemCount,
      [Token(Token = "0x400F99A")] FreeCount,
      [Token(Token = "0x400F99B")] KeyItemIcon,
      [Token(Token = "0x400F99C")] LockPossible,
      [Token(Token = "0x400F99D")] SetMission,
    }
  }
}
