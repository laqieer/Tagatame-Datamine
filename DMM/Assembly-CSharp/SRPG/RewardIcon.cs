// Decompiled with JetBrains decompiler
// Type: SRPG.RewardIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021B9")]
  [FlowNode.Pin(101, "ユニットアイコンBTNデフォルト", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "アイテムアイコンBTNデフォルト", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "念装アイコンBTNデフォルト", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "武具アイコンBTNデフォルト", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(105, "称号アイコンBTNデフォルト", FlowNode.PinTypes.Output, 105)]
  [AddComponentMenu("UI/Common/RewardIcon")]
  public class RewardIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40093C2")]
    private const int PIN_OUTPUT_UNIT_BTN = 101;
    [Token(Token = "0x40093C3")]
    private const int PIN_OUTPUT_ITEM_BTN = 102;
    [Token(Token = "0x40093C4")]
    private const int PIN_OUTPUT_CONCEPTCARD_BTN = 103;
    [Token(Token = "0x40093C5")]
    private const int PIN_OUTPUT_ARTIFACT_BTN = 104;
    [Token(Token = "0x40093C6")]
    private const int PIN_OUTPUT_AWARD_BTN = 105;
    [Token(Token = "0x40093C7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardUnit;
    [Token(Token = "0x40093C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardItem;
    [Token(Token = "0x40093C9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRewardCard;
    [Token(Token = "0x40093CA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardArtifact;
    [Token(Token = "0x40093CB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRewardAward;
    [Token(Token = "0x40093CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRewardGold;
    [Token(Token = "0x40093CD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRewardCoin;
    [Token(Token = "0x40093CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mRewardItemCommonIcon;
    [Token(Token = "0x40093CF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private string mAmountObj;
    [Token(Token = "0x40093D0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string mTextAmount;

    [Token(Token = "0x6008E0F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008E10")]
    [Address(RVA = "0x51D650", Offset = "0x51C450", VA = "0x1051D650")]
    public void RewardReset()
    {
    }

    [Token(Token = "0x6008E11")]
    [Address(RVA = "0x51CD20", Offset = "0x51BB20", VA = "0x1051CD20")]
    public void Initialize(
      RewardIcon.eType type,
      string iname,
      int num,
      bool is_count = true,
      RewardIcon.RewardIconEvent _event = null)
    {
    }

    [Token(Token = "0x6008E12")]
    [Address(RVA = "0x51D720", Offset = "0x51C520", VA = "0x1051D720")]
    public void SetItemCommonPieceItem(bool is_active)
    {
    }

    [Token(Token = "0x6008E13")]
    [Address(RVA = "0x51D290", Offset = "0x51C090", VA = "0x1051D290")]
    public void Initialize(GiftData reward)
    {
    }

    [Token(Token = "0x6008E14")]
    [Address(RVA = "0x51D770", Offset = "0x51C570", VA = "0x1051D770")]
    public RewardIcon()
    {
    }

    [Token(Token = "0x20021BA")]
    public enum eType
    {
      [Token(Token = "0x40093D2")] Item,
      [Token(Token = "0x40093D3")] Gold,
      [Token(Token = "0x40093D4")] Coin,
      [Token(Token = "0x40093D5")] Award,
      [Token(Token = "0x40093D6")] Unit,
      [Token(Token = "0x40093D7")] ConceptCard,
      [Token(Token = "0x40093D8")] Artifact,
      [Token(Token = "0x40093D9")] GuildEmblem,
    }

    [Token(Token = "0x20021BB")]
    public delegate void RewardIconEvent();
  }
}
