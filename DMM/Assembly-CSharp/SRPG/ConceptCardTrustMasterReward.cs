// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardTrustMasterReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002250")]
  [AddComponentMenu("UI/ConceptCardTrustMasterReward")]
  public class ConceptCardTrustMasterReward : MonoBehaviour
  {
    [Token(Token = "0x400983B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mItemName;
    [Token(Token = "0x400983C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mItemAmount;
    [Token(Token = "0x400983D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mItemlist;
    [Token(Token = "0x400983E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon mItemIcon;
    [Token(Token = "0x400983F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ArtifactIcon mArtifactIcon;
    [Token(Token = "0x4009840")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ConceptCardIcon mCardIcon;
    [Token(Token = "0x4009841")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Sprite CoinFrame;
    [Token(Token = "0x4009842")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite GoldFrame;

    [Token(Token = "0x6009240")]
    [Address(RVA = "0x5588F0", Offset = "0x5576F0", VA = "0x105588F0")]
    public void SetData(ConceptCardData data)
    {
    }

    [Token(Token = "0x6009241")]
    [Address(RVA = "0x558E30", Offset = "0x557C30", VA = "0x10558E30")]
    public void SetItem(ConceptCardTrustRewardItemParam reward_item)
    {
    }

    [Token(Token = "0x6009242")]
    [Address(RVA = "0x558660", Offset = "0x557460", VA = "0x10558660")]
    public void SetArtifact(ConceptCardTrustRewardItemParam reward_item)
    {
    }

    [Token(Token = "0x6009243")]
    [Address(RVA = "0x5587A0", Offset = "0x5575A0", VA = "0x105587A0")]
    public void SetConceptCard(ConceptCardTrustRewardItemParam reward_item)
    {
    }

    [Token(Token = "0x6009244")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardTrustMasterReward()
    {
    }
  }
}
