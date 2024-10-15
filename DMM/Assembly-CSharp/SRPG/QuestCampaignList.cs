// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200288D")]
  [AddComponentMenu("UI/QuestCampaignList")]
  public class QuestCampaignList : MonoBehaviour
  {
    [Token(Token = "0x400C1D4")]
    [FieldOffset(Offset = "0xC")]
    public GameObject TemplateExpPlayer;
    [Token(Token = "0x400C1D5")]
    [FieldOffset(Offset = "0x10")]
    public GameObject TemplateExpUnit;
    [Token(Token = "0x400C1D6")]
    [FieldOffset(Offset = "0x14")]
    public GameObject TemplateExpUnitAll;
    [Token(Token = "0x400C1D7")]
    [FieldOffset(Offset = "0x18")]
    public GameObject TemplateDrapItem;
    [Token(Token = "0x400C1D8")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject TemplateAp;
    [Token(Token = "0x400C1D9")]
    [FieldOffset(Offset = "0x20")]
    public GameObject TemplateTrustUp;
    [Token(Token = "0x400C1DA")]
    [FieldOffset(Offset = "0x24")]
    public GameObject TemplateTrustIncidence;
    [Token(Token = "0x400C1DB")]
    [FieldOffset(Offset = "0x28")]
    public GameObject TemplateTrustSpecific;
    [Token(Token = "0x400C1DC")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject TemplateInspirationSkill;
    [Token(Token = "0x400C1DD")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    public Text TextConsumeAp;
    [Token(Token = "0x400C1DE")]
    [FieldOffset(Offset = "0x34")]
    public Color TextConsumeApColor;
    [Token(Token = "0x400C1DF")]
    [FieldOffset(Offset = "0x44")]
    public GameObject TemplateExpansionPurchaseDropUp;

    [Token(Token = "0x600B735")]
    [Address(RVA = "0x7DACD0", Offset = "0x7D9AD0", VA = "0x107DACD0")]
    public void RefreshIcons()
    {
    }

    [Token(Token = "0x600B736")]
    [Address(RVA = "0x7DB180", Offset = "0x7D9F80", VA = "0x107DB180")]
    private void Start()
    {
    }

    [Token(Token = "0x600B737")]
    [Address(RVA = "0x7DAF50", Offset = "0x7D9D50", VA = "0x107DAF50")]
    private void ResetTemplateActive()
    {
    }

    [Token(Token = "0x600B738")]
    [Address(RVA = "0x7DAAC0", Offset = "0x7D98C0", VA = "0x107DAAC0")]
    public void DrawDropUpIcon(QuestParam _current_quest = null)
    {
    }

    [Token(Token = "0x600B739")]
    [Address(RVA = "0x7DB1A0", Offset = "0x7D9FA0", VA = "0x107DB1A0")]
    public QuestCampaignList()
    {
    }
  }
}
