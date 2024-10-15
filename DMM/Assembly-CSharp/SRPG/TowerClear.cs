// Decompiled with JetBrains decompiler
// Type: SRPG.TowerClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B39")]
  [AddComponentMenu("UI/TowerClear")]
  public class TowerClear : MonoBehaviour
  {
    [Token(Token = "0x400D30E")]
    [FieldOffset(Offset = "0xC")]
    private readonly int RANKIN_SCORE;
    [Token(Token = "0x400D30F")]
    [FieldOffset(Offset = "0x10")]
    public Text TowerName;
    [Token(Token = "0x400D310")]
    [FieldOffset(Offset = "0x14")]
    public Text ArrivedNum;
    [Token(Token = "0x400D311")]
    [FieldOffset(Offset = "0x18")]
    public Text BigArrivedNum;
    [Token(Token = "0x400D312")]
    [FieldOffset(Offset = "0x1C")]
    public Text BigArrivedNumEff;
    [Token(Token = "0x400D313")]
    [FieldOffset(Offset = "0x20")]
    public GameObject RankInfo;
    [Token(Token = "0x400D314")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ResultInfo;
    [Token(Token = "0x400D315")]
    [FieldOffset(Offset = "0x28")]
    public Button BackButton;
    [Token(Token = "0x400D316")]
    [FieldOffset(Offset = "0x2C")]
    public Button NextButton;
    [Token(Token = "0x400D317")]
    [FieldOffset(Offset = "0x30")]
    public Text[] CountupText;
    [Token(Token = "0x400D318")]
    [FieldOffset(Offset = "0x34")]
    public GameObject[] ScoreObj;
    [Token(Token = "0x400D319")]
    [FieldOffset(Offset = "0x38")]
    public GameObject[] NewRecord;
    [Token(Token = "0x400D31A")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject[] ScoreContents;
    [Token(Token = "0x400D31B")]
    [FieldOffset(Offset = "0x40")]
    public GameObject SpeedRank;
    [Token(Token = "0x400D31C")]
    [FieldOffset(Offset = "0x44")]
    public GameObject TechRank;
    [Token(Token = "0x400D31D")]
    [FieldOffset(Offset = "0x48")]
    public GameObject RankInObj;
    [Token(Token = "0x400D31E")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject RankingObj;
    [Token(Token = "0x400D31F")]
    [FieldOffset(Offset = "0x50")]
    public GameObject ContinueObj;
    [Token(Token = "0x400D320")]
    [FieldOffset(Offset = "0x54")]
    public GameObject CongraObj;
    [Token(Token = "0x400D321")]
    [FieldOffset(Offset = "0x58")]
    public GameObject TotalScoreObj;
    [Token(Token = "0x400D322")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject PlusObj;
    [Token(Token = "0x400D323")]
    [FieldOffset(Offset = "0x60")]
    public GameObject MinusObj;
    [Token(Token = "0x400D324")]
    [FieldOffset(Offset = "0x64")]
    public Image TotalScoreImg;
    [Token(Token = "0x400D325")]
    [FieldOffset(Offset = "0x68")]
    public Text SpeedRankText;
    [Token(Token = "0x400D326")]
    [FieldOffset(Offset = "0x6C")]
    public Text TechRankText;
    [Token(Token = "0x400D327")]
    [FieldOffset(Offset = "0x70")]
    private TowerClear.CLEAR_FLOW Nowflow;
    [Token(Token = "0x400D328")]
    [FieldOffset(Offset = "0x74")]
    private int NowCount;
    [Token(Token = "0x400D329")]
    [FieldOffset(Offset = "0x78")]
    private Text NowText;
    [Token(Token = "0x400D32A")]
    [FieldOffset(Offset = "0x7C")]
    private bool NextState;
    [Token(Token = "0x400D32B")]
    [FieldOffset(Offset = "0x80")]
    private SpriteSheet Icons;
    [Token(Token = "0x400D32C")]
    [FieldOffset(Offset = "0x84")]
    private int CountupIndex;
    [Token(Token = "0x400D32D")]
    [FieldOffset(Offset = "0x88")]
    private int[] NowScore;
    [Token(Token = "0x400D32E")]
    [FieldOffset(Offset = "0x8C")]
    private int[] OldBestScore;
    [Token(Token = "0x400D32F")]
    [FieldOffset(Offset = "0x90")]
    private int CountValue;
    [Token(Token = "0x400D330")]
    [FieldOffset(Offset = "0x94")]
    private TowerParam m_TowerParam;
    [Token(Token = "0x400D331")]
    [FieldOffset(Offset = "0x98")]
    private readonly int EFF_TIME;

    [Token(Token = "0x17001A3F")]
    private TowerFloorParam TowerFloorParam
    {
      [Token(Token = "0x600C5D6"), Address(RVA = "0x8E6B50", Offset = "0x8E5950", VA = "0x108E6B50")] get
      {
        return (TowerFloorParam) null;
      }
    }

    [Token(Token = "0x17001A40")]
    private TowerResuponse TowerResuponse
    {
      [Token(Token = "0x600C5D7"), Address(RVA = "0x8E6BD0", Offset = "0x8E59D0", VA = "0x108E6BD0")] get
      {
        return (TowerResuponse) null;
      }
    }

    [Token(Token = "0x600C5D8")]
    [Address(RVA = "0x8E5C20", Offset = "0x8E4A20", VA = "0x108E5C20")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5D9")]
    [Address(RVA = "0x8E5EE0", Offset = "0x8E4CE0", VA = "0x108E5EE0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C5DA")]
    [Address(RVA = "0x8E5750", Offset = "0x8E4550", VA = "0x108E5750")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C5DB")]
    [Address(RVA = "0x8E5640", Offset = "0x8E4440", VA = "0x108E5640")]
    private void RefleshResult()
    {
    }

    [Token(Token = "0x600C5DC")]
    [Address(RVA = "0x8E5610", Offset = "0x8E4410", VA = "0x108E5610")]
    private void OnClickNext()
    {
    }

    [Token(Token = "0x600C5DD")]
    [Address(RVA = "0x8E6A90", Offset = "0x8E5890", VA = "0x108E6A90")]
    public TowerClear()
    {
    }

    [Token(Token = "0x2002B3A")]
    public enum TOWER_CLEAR_FLAG
    {
      [Token(Token = "0x400D333")] NOT_CLEAR,
      [Token(Token = "0x400D334")] CLEAR,
      [Token(Token = "0x400D335")] CLEAR_AND_SCORE,
    }

    [Token(Token = "0x2002B3B")]
    private enum CLEAR_FLOW
    {
      [Token(Token = "0x400D337")] NONE,
      [Token(Token = "0x400D338")] RANK_IN,
      [Token(Token = "0x400D339")] SCORE_IN,
      [Token(Token = "0x400D33A")] IN,
      [Token(Token = "0x400D33B")] LOOP,
      [Token(Token = "0x400D33C")] SCORE,
      [Token(Token = "0x400D33D")] TOTAL_SCORE,
      [Token(Token = "0x400D33E")] SPEED_RANK_IN,
      [Token(Token = "0x400D33F")] TECH_RANK_IN,
      [Token(Token = "0x400D340")] FINISH,
    }
  }
}
