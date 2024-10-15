// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200290C")]
  [AddComponentMenu("UI/RankingQuestInfo")]
  public class RankingQuestInfo : MonoBehaviour
  {
    [Token(Token = "0x400C5BB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_UserName;
    [Token(Token = "0x400C5BC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_MainScore;
    [Token(Token = "0x400C5BD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_SubScore;
    [Token(Token = "0x400C5BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RankingQuestInfo.RankViewObject[] m_SpecialRankObject;
    [Token(Token = "0x400C5BF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RankingQuestInfo.RankViewObject m_CommonRankObject;

    [Token(Token = "0x600B9D8")]
    [Address(RVA = "0x8125D0", Offset = "0x8113D0", VA = "0x108125D0")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600B9D9")]
    [Address(RVA = "0x8124E0", Offset = "0x8112E0", VA = "0x108124E0")]
    private void Refrection_ActionCountRanking(RankingQuestUserData data)
    {
    }

    [Token(Token = "0x600B9DA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RankingQuestInfo()
    {
    }

    [Token(Token = "0x200290D")]
    [Serializable]
    public class RankViewObject
    {
      [Token(Token = "0x400C5C0")]
      [FieldOffset(Offset = "0x8")]
      [SerializeField]
      public GameObject m_RootObject;
      [Token(Token = "0x400C5C1")]
      [FieldOffset(Offset = "0xC")]
      [SerializeField]
      public Text m_TextObject;

      [Token(Token = "0x600B9DB")]
      [Address(RVA = "0x811D70", Offset = "0x810B70", VA = "0x10811D70")]
      public void SetActive(bool value)
      {
      }

      [Token(Token = "0x600B9DC")]
      [Address(RVA = "0x811DE0", Offset = "0x810BE0", VA = "0x10811DE0")]
      public void SetRank(string value)
      {
      }

      [Token(Token = "0x600B9DD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RankViewObject()
      {
      }
    }
  }
}
