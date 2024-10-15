// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRankInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B5E")]
  [AddComponentMenu("UI/TowerRankInfo")]
  public class TowerRankInfo : MonoBehaviour
  {
    [Token(Token = "0x400D435")]
    [FieldOffset(Offset = "0xC")]
    private readonly int SHOW_VIP_RANK;
    [Token(Token = "0x400D436")]
    [FieldOffset(Offset = "0x10")]
    public Text Ranking;
    [Token(Token = "0x400D437")]
    [FieldOffset(Offset = "0x14")]
    public Image OwnIcon;
    [Token(Token = "0x400D438")]
    [FieldOffset(Offset = "0x18")]
    public GameObject OwnObj;
    [Token(Token = "0x400D439")]
    [FieldOffset(Offset = "0x1C")]
    public Image OwnTotalScore;
    [Token(Token = "0x400D43A")]
    [FieldOffset(Offset = "0x20")]
    public Text OwnSpeedScore;
    [Token(Token = "0x400D43B")]
    [FieldOffset(Offset = "0x24")]
    public Text OwnTechScore;
    [Token(Token = "0x400D43C")]
    [FieldOffset(Offset = "0x28")]
    public GameObject OwnSpeedObj;
    [Token(Token = "0x400D43D")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject OwnTechObj;
    [Token(Token = "0x400D43E")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼「ランキング」表示用（最上階までクリア済み）")]
    public GameObject ClearPage;
    [Token(Token = "0x400D43F")]
    [FieldOffset(Offset = "0x34")]
    public GameObject ClearPageParent;
    [Token(Token = "0x400D440")]
    [FieldOffset(Offset = "0x38")]
    public ListItemEvents ClearTemplate;
    [Token(Token = "0x400D441")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("▼「ランキング」表示用（最上階まで未クリア）")]
    public GameObject NotClearPage;
    [Token(Token = "0x400D442")]
    [FieldOffset(Offset = "0x40")]
    public GameObject NotClearPageParent;
    [Token(Token = "0x400D443")]
    [FieldOffset(Offset = "0x44")]
    public ListItemEvents NotClearTemplate;
    [Token(Token = "0x400D444")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼「ランキング」表示用（集計中）")]
    public GameObject NotDataObj;
    [Token(Token = "0x400D445")]
    [FieldOffset(Offset = "0x4C")]
    [HeaderBar("▼「自分の戦績」表示用オブジェクトの親")]
    [SerializeField]
    private GameObject m_TowerPlayerInfoRoot;
    [Token(Token = "0x400D446")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼タブ")]
    public Toggle Speed;
    [Token(Token = "0x400D447")]
    [FieldOffset(Offset = "0x54")]
    public Toggle Tech;
    [Token(Token = "0x400D448")]
    [FieldOffset(Offset = "0x58")]
    public Toggle OwnStatus;
    [Token(Token = "0x400D449")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject Root;
    [Token(Token = "0x400D44A")]
    [FieldOffset(Offset = "0x60")]
    private SpriteSheet mSheet;
    [Token(Token = "0x400D44B")]
    [FieldOffset(Offset = "0x64")]
    private bool IsSpeed;

    [Token(Token = "0x600C6A4")]
    [Address(RVA = "0x8F1360", Offset = "0x8F0160", VA = "0x108F1360")]
    private void Start()
    {
    }

    [Token(Token = "0x600C6A5")]
    [Address(RVA = "0x8F1160", Offset = "0x8EFF60", VA = "0x108F1160")]
    private int GetSameRank(int score, int rank) => new int();

    [Token(Token = "0x600C6A6")]
    [Address(RVA = "0x8F1600", Offset = "0x8F0400", VA = "0x108F1600")]
    private void UpdateOwnValue()
    {
    }

    [Token(Token = "0x600C6A7")]
    [Address(RVA = "0x8F1BD0", Offset = "0x8F09D0", VA = "0x108F1BD0")]
    private void UpdateRankValue(bool isSpeedRank = true)
    {
    }

    [Token(Token = "0x600C6A8")]
    [Address(RVA = "0x8F2220", Offset = "0x8F1020", VA = "0x108F2220")]
    private void UpdateValue(
      ListItemEvents obj,
      int num,
      TowerResuponse.TowerRankParam param,
      bool isSpeed)
    {
    }

    [Token(Token = "0x600C6A9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C6AA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600C6AB")]
    [Address(RVA = "0x8F1280", Offset = "0x8F0080", VA = "0x108F1280")]
    public void OnChangeSpeed(bool val)
    {
    }

    [Token(Token = "0x600C6AC")]
    [Address(RVA = "0x8F12F0", Offset = "0x8F00F0", VA = "0x108F12F0")]
    public void OnChangeTech(bool val)
    {
    }

    [Token(Token = "0x600C6AD")]
    [Address(RVA = "0x8F1200", Offset = "0x8F0000", VA = "0x108F1200")]
    public void OnChangeOwnStatus(bool val)
    {
    }

    [Token(Token = "0x600C6AE")]
    [Address(RVA = "0x8F2AE0", Offset = "0x8F18E0", VA = "0x108F2AE0")]
    public TowerRankInfo()
    {
    }
  }
}
