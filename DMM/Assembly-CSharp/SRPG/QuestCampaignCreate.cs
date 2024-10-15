// Decompiled with JetBrains decompiler
// Type: SRPG.QuestCampaignCreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200288B")]
  [AddComponentMenu("UI/QuestCampaignCreate")]
  public class QuestCampaignCreate : MonoBehaviour
  {
    [Token(Token = "0x400C1D0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject QuestCampaignItem;
    [Token(Token = "0x400C1D1")]
    [FieldOffset(Offset = "0x10")]
    private GameObject mGoQuestCampaignItem;

    [Token(Token = "0x17001909")]
    public QuestCampaignList GetQuestCampaignList
    {
      [Token(Token = "0x600B72D"), Address(RVA = "0x7DA500", Offset = "0x7D9300", VA = "0x107DA500")] get
      {
        return (QuestCampaignList) null;
      }
    }

    [Token(Token = "0x600B72E")]
    [Address(RVA = "0x7DA340", Offset = "0x7D9140", VA = "0x107DA340")]
    private void Start()
    {
    }

    [Token(Token = "0x600B72F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestCampaignCreate()
    {
    }
  }
}
