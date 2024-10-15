// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRankItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B5F")]
  [AddComponentMenu("UI/TowerRankItem")]
  public class TowerRankItem : MonoBehaviour
  {
    [Token(Token = "0x400D44C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_UserName;
    [Token(Token = "0x400D44D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_UserLv;
    [Token(Token = "0x400D44E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_Rank;
    [Token(Token = "0x400D44F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_Score;

    [Token(Token = "0x600C6AF")]
    [Address(RVA = "0x8F2C00", Offset = "0x8F1A00", VA = "0x108F2C00")]
    public void Setup(TowerResuponse.TowerRankParam rankData)
    {
    }

    [Token(Token = "0x600C6B0")]
    [Address(RVA = "0x8F2B10", Offset = "0x8F1910", VA = "0x108F2B10")]
    private void SetText(Text text, int value)
    {
    }

    [Token(Token = "0x600C6B1")]
    [Address(RVA = "0x8F2B90", Offset = "0x8F1990", VA = "0x108F2B90")]
    private void SetText(Text text, string value)
    {
    }

    [Token(Token = "0x600C6B2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerRankItem()
    {
    }
  }
}
