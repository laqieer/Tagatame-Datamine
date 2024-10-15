// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002910")]
  [AddComponentMenu("UI/RankingQuestResult")]
  public class RankingQuestResult : MonoBehaviour
  {
    [Token(Token = "0x400C5D1")]
    private const int HIGHER_RANK_TEXT_INDEX = 4;
    [Token(Token = "0x400C5D2")]
    private const int MIDDLE_RANK_TEXT_INDEX = 10;
    [Token(Token = "0x400C5D3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_HigherRankText;
    [Token(Token = "0x400C5D4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_MiddleRankText;
    [Token(Token = "0x400C5D5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_LowerRankText;
    [Token(Token = "0x400C5D6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject m_RankDecoration;
    [Token(Token = "0x400C5D7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject m_RankDecorationEffect;
    [Token(Token = "0x400C5D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text m_MainScoreText;
    [Token(Token = "0x400C5D9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text m_MainScoreValue;
    [Token(Token = "0x400C5DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text m_SubScoreValue;

    [Token(Token = "0x600B9EB")]
    [Address(RVA = "0x813710", Offset = "0x812510", VA = "0x10813710")]
    private void Start()
    {
    }

    [Token(Token = "0x600B9EC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankingQuestResult()
    {
    }
  }
}
