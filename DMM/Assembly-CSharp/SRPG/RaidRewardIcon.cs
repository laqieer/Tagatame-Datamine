// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028EE")]
  [AddComponentMenu("UI/Raid/RaidRewardIcon")]
  public class RaidRewardIcon : MonoBehaviour
  {
    [Token(Token = "0x400C4C9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardUnit;
    [Token(Token = "0x400C4CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardItem;
    [Token(Token = "0x400C4CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRewardCard;
    [Token(Token = "0x400C4CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardArtifact;
    [Token(Token = "0x400C4CD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRewardAward;
    [Token(Token = "0x400C4CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRewardGold;
    [Token(Token = "0x400C4CF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mRewardCoin;
    [Token(Token = "0x400C4D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mBadgeDisassembly;
    [Token(Token = "0x400C4D1")]
    [FieldOffset(Offset = "0x2C")]
    private GiftData _reward;
    [Token(Token = "0x400C4D2")]
    [FieldOffset(Offset = "0x30")]
    private RuneData _runeData;
    [Token(Token = "0x400C4D3")]
    [FieldOffset(Offset = "0x34")]
    private GameObject _activeGO;

    [Token(Token = "0x17001957")]
    public GiftData RewardData
    {
      [Token(Token = "0x600B940"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (GiftData) null;
      }
    }

    [Token(Token = "0x17001958")]
    public RuneData RuneData
    {
      [Token(Token = "0x600B941"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (RuneData) null;
      }
    }

    [Token(Token = "0x600B942")]
    [Address(RVA = "0x80AC10", Offset = "0x809A10", VA = "0x1080AC10")]
    public void Initialize(GiftData reward)
    {
    }

    [Token(Token = "0x600B943")]
    [Address(RVA = "0x80A840", Offset = "0x809640", VA = "0x1080A840")]
    public void Initialize(RaidReward reward)
    {
    }

    [Token(Token = "0x600B944")]
    [Address(RVA = "0x80B090", Offset = "0x809E90", VA = "0x1080B090")]
    public void Initialize(int raid_reward_type, string iname, int num)
    {
    }

    [Token(Token = "0x600B945")]
    [Address(RVA = "0x80B770", Offset = "0x80A570", VA = "0x1080B770")]
    public void SetRune(RuneData runeData)
    {
    }

    [Token(Token = "0x600B946")]
    [Address(RVA = "0x80B4D0", Offset = "0x80A2D0", VA = "0x1080B4D0")]
    public static void SetIcon(RaidRewardType type, string iname, int num, GameObject target)
    {
    }

    [Token(Token = "0x600B947")]
    [Address(RVA = "0x80B230", Offset = "0x80A030", VA = "0x1080B230")]
    public static void SetIcon(RewardIcon.eType type, string iname, int num, GameObject target)
    {
    }

    [Token(Token = "0x600B948")]
    [Address(RVA = "0x80B130", Offset = "0x809F30", VA = "0x1080B130")]
    private static void SetAmountText(GameObject target, int amount)
    {
    }

    [Token(Token = "0x600B949")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidRewardIcon()
    {
    }
  }
}
