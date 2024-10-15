// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardExtraRarityOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021D0")]
  public class ConceptCardExtraRarityOpen : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009465")]
    private const string ADD_LEVELCAP_TEXT = "sys.CONCEPTCARD_EXTRA_RARITY_OPEN_ADDLEVEL_TEXT";
    [Token(Token = "0x4009466")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ConceptCardTrustMaster conceptCardTrustMaster;
    [Token(Token = "0x4009467")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text beforeLimitLevelText;
    [Token(Token = "0x4009468")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text afterLimitLevelText;
    [Token(Token = "0x4009469")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text addLimitLevelText;

    [Token(Token = "0x6008EC1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008EC2")]
    [Address(RVA = "0x531D40", Offset = "0x530B40", VA = "0x10531D40")]
    public void Setup(ConceptCardData cardData)
    {
    }

    [Token(Token = "0x6008EC3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardExtraRarityOpen()
    {
    }
  }
}
