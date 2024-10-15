// Decompiled with JetBrains decompiler
// Type: SRPG.TowerPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B4A")]
  [AddComponentMenu("UI/TowerPlayerInfo")]
  public class TowerPlayerInfo : MonoBehaviour
  {
    [Token(Token = "0x400D3A2")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼現在のスコア")]
    public Text NowTurn;
    [Token(Token = "0x400D3A3")]
    [FieldOffset(Offset = "0x10")]
    public Text NowDied;
    [Token(Token = "0x400D3A4")]
    [FieldOffset(Offset = "0x14")]
    public Text NowRetire;
    [Token(Token = "0x400D3A5")]
    [FieldOffset(Offset = "0x18")]
    public Text NowRecover;
    [Token(Token = "0x400D3A6")]
    [FieldOffset(Offset = "0x1C")]
    public Text NowChallenge;
    [Token(Token = "0x400D3A7")]
    [FieldOffset(Offset = "0x20")]
    public Text NowLose;
    [Token(Token = "0x400D3A8")]
    [FieldOffset(Offset = "0x24")]
    public Text NowReset;
    [Token(Token = "0x400D3A9")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼ベストスコア")]
    public Text BestTurn;
    [Token(Token = "0x400D3AA")]
    [FieldOffset(Offset = "0x2C")]
    public Text BestDied;
    [Token(Token = "0x400D3AB")]
    [FieldOffset(Offset = "0x30")]
    public Text BestRetire;
    [Token(Token = "0x400D3AC")]
    [FieldOffset(Offset = "0x34")]
    public Text BestRecover;
    [Token(Token = "0x400D3AD")]
    [FieldOffset(Offset = "0x38")]
    public Text BestChallenge;
    [Token(Token = "0x400D3AE")]
    [FieldOffset(Offset = "0x3C")]
    public Text BestLose;
    [Token(Token = "0x400D3AF")]
    [FieldOffset(Offset = "0x40")]
    public Text BestReset;
    [Token(Token = "0x400D3B0")]
    [FieldOffset(Offset = "0x44")]
    [HeaderBar("▼ランキングの順位")]
    public Text SpdRank;
    [Token(Token = "0x400D3B1")]
    [FieldOffset(Offset = "0x48")]
    public Text TecRank;
    [Token(Token = "0x400D3B2")]
    [FieldOffset(Offset = "0x4C")]
    [HeaderBar("▼スコアのアートフォント")]
    public GameObject TurnScore;
    [Token(Token = "0x400D3B3")]
    [FieldOffset(Offset = "0x50")]
    public GameObject DiedScore;
    [Token(Token = "0x400D3B4")]
    [FieldOffset(Offset = "0x54")]
    public GameObject RetireScore;
    [Token(Token = "0x400D3B5")]
    [FieldOffset(Offset = "0x58")]
    public GameObject RecoverScore;
    [Token(Token = "0x400D3B6")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject ChallengeScore;
    [Token(Token = "0x400D3B7")]
    [FieldOffset(Offset = "0x60")]
    public GameObject LoseScore;
    [Token(Token = "0x400D3B8")]
    [FieldOffset(Offset = "0x64")]
    public GameObject ResetScore;
    [Token(Token = "0x400D3B9")]
    [FieldOffset(Offset = "0x68")]
    public GameObject TotalScore;
    [Token(Token = "0x400D3BA")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject PlusObj;
    [Token(Token = "0x400D3BB")]
    [FieldOffset(Offset = "0x70")]
    public GameObject MinusObj;
    [Token(Token = "0x400D3BC")]
    [FieldOffset(Offset = "0x74")]
    [HeaderBar("▼ユニット表示用オブジェクトの親")]
    public GameObject Leader;
    [Token(Token = "0x400D3BD")]
    [FieldOffset(Offset = "0x78")]
    private string NotSocreText;
    [Token(Token = "0x400D3BE")]
    [FieldOffset(Offset = "0x7C")]
    private SpriteSheet Icons;

    [Token(Token = "0x600C62E")]
    [Address(RVA = "0x8EB110", Offset = "0x8E9F10", VA = "0x108EB110")]
    private void Start()
    {
    }

    [Token(Token = "0x600C62F")]
    [Address(RVA = "0x8EAD70", Offset = "0x8E9B70", VA = "0x108EAD70")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600C630")]
    [Address(RVA = "0x8EBA60", Offset = "0x8EA860", VA = "0x108EBA60")]
    private void UpdateNowScore()
    {
    }

    [Token(Token = "0x600C631")]
    [Address(RVA = "0x8EB2E0", Offset = "0x8EA0E0", VA = "0x108EB2E0")]
    private void UpdateBestScore()
    {
    }

    [Token(Token = "0x600C632")]
    [Address(RVA = "0x8EBD50", Offset = "0x8EAB50", VA = "0x108EBD50")]
    private void UpdateTotalScore()
    {
    }

    [Token(Token = "0x600C633")]
    [Address(RVA = "0x8EAF60", Offset = "0x8E9D60", VA = "0x108EAF60")]
    private void SetRankIcon(GameObject obj, string rank)
    {
    }

    [Token(Token = "0x600C634")]
    [Address(RVA = "0x8EAEE0", Offset = "0x8E9CE0", VA = "0x108EAEE0")]
    private void SetDefault(GameObject obj)
    {
    }

    [Token(Token = "0x600C635")]
    [Address(RVA = "0x8EB0A0", Offset = "0x8E9EA0", VA = "0x108EB0A0")]
    private void SetText(Text text, string val)
    {
    }

    [Token(Token = "0x600C636")]
    [Address(RVA = "0x8EC210", Offset = "0x8EB010", VA = "0x108EC210")]
    public TowerPlayerInfo()
    {
    }
  }
}
