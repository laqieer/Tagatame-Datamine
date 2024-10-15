// Decompiled with JetBrains decompiler
// Type: SRPG.TowerScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B62")]
  [AddComponentMenu("UI/TowerScore")]
  public class TowerScore : MonoBehaviour
  {
    [Token(Token = "0x400D463")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼「スコア内訳」のテキスト")]
    [SerializeField]
    private Text m_ScoreTitle;
    [Token(Token = "0x400D464")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼スコア")]
    [SerializeField]
    private Text m_TurnNum;
    [Token(Token = "0x400D465")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_DiedNum;
    [Token(Token = "0x400D466")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_RetireNum;
    [Token(Token = "0x400D467")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text m_RecoveryNum;
    [Token(Token = "0x400D468")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_FloorResetNum;
    [Token(Token = "0x400D469")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text m_ChallengeNum;
    [Token(Token = "0x400D46A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text m_LoseNum;
    [Token(Token = "0x400D46B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [HeaderBar("▼ランキング")]
    private TowerRankItem m_SpdRankTop;
    [Token(Token = "0x400D46C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TowerRankItem m_TecRankTop;
    [Token(Token = "0x400D46D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject m_SpdRankHeader;
    [Token(Token = "0x400D46E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject m_TecRankHeader;
    [Token(Token = "0x400D46F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject m_NoRankData;
    [Token(Token = "0x400D470")]
    [FieldOffset(Offset = "0x40")]
    private string NotSocreText;

    [Token(Token = "0x600C6B7")]
    [Address(RVA = "0x8F6040", Offset = "0x8F4E40", VA = "0x108F6040")]
    public void SetScoreTitleText(string floorName)
    {
    }

    [Token(Token = "0x600C6B8")]
    [Address(RVA = "0x8F6260", Offset = "0x8F5060", VA = "0x108F6260")]
    public void Setup(
      TowerScore.ViewParam param,
      TowerResuponse.TowerRankParam[] spdRankData,
      TowerResuponse.TowerRankParam[] tecRankData)
    {
    }

    [Token(Token = "0x600C6B9")]
    [Address(RVA = "0x8F5F20", Offset = "0x8F4D20", VA = "0x108F5F20")]
    public void SetRankData(TowerRankItem rankItem, TowerResuponse.TowerRankParam[] rankData)
    {
    }

    [Token(Token = "0x600C6BA")]
    [Address(RVA = "0x8F61E0", Offset = "0x8F4FE0", VA = "0x108F61E0")]
    private static void SetText(Text text, int value)
    {
    }

    [Token(Token = "0x600C6BB")]
    [Address(RVA = "0x8F6170", Offset = "0x8F4F70", VA = "0x108F6170")]
    private static void SetText(Text text, string value)
    {
    }

    [Token(Token = "0x600C6BC")]
    [Address(RVA = "0x8F69F0", Offset = "0x8F57F0", VA = "0x108F69F0")]
    public TowerScore()
    {
    }

    [Token(Token = "0x2002B63")]
    public class ViewParam
    {
      [Token(Token = "0x400D471")]
      [FieldOffset(Offset = "0x8")]
      private int m_TurnNum;
      [Token(Token = "0x400D472")]
      [FieldOffset(Offset = "0xC")]
      private int m_DiedNum;
      [Token(Token = "0x400D473")]
      [FieldOffset(Offset = "0x10")]
      private int m_RetireNum;
      [Token(Token = "0x400D474")]
      [FieldOffset(Offset = "0x14")]
      private int m_RecoveryNum;
      [Token(Token = "0x400D475")]
      [FieldOffset(Offset = "0x18")]
      private int m_FloorResetNum;
      [Token(Token = "0x400D476")]
      [FieldOffset(Offset = "0x1C")]
      private int m_ChallengeNum;
      [Token(Token = "0x400D477")]
      [FieldOffset(Offset = "0x20")]
      private int m_LoseNum;

      [Token(Token = "0x17001A55")]
      public int TurnNum
      {
        [Token(Token = "0x600C6BD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6BE"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
        {
        }
      }

      [Token(Token = "0x17001A56")]
      public int DiedNum
      {
        [Token(Token = "0x600C6BF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6C0"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] set
        {
        }
      }

      [Token(Token = "0x17001A57")]
      public int RetireNum
      {
        [Token(Token = "0x600C6C1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6C2"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] set
        {
        }
      }

      [Token(Token = "0x17001A58")]
      public int RecoveryNum
      {
        [Token(Token = "0x600C6C3"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6C4"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] set
        {
        }
      }

      [Token(Token = "0x17001A59")]
      public int FloorResetNum
      {
        [Token(Token = "0x600C6C5"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6C6"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] set
        {
        }
      }

      [Token(Token = "0x17001A5A")]
      public int ChallengeNum
      {
        [Token(Token = "0x600C6C7"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6C8"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] set
        {
        }
      }

      [Token(Token = "0x17001A5B")]
      public int LoseNum
      {
        [Token(Token = "0x600C6C9"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C6CA"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
        {
        }
      }

      [Token(Token = "0x17001A5C")]
      public bool IsNoData
      {
        [Token(Token = "0x600C6CB"), Address(RVA = "0x90BB00", Offset = "0x90A900", VA = "0x1090BB00")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C6CC")]
      [Address(RVA = "0x90BAB0", Offset = "0x90A8B0", VA = "0x1090BAB0")]
      public ViewParam()
      {
      }
    }
  }
}
