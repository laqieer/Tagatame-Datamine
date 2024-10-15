// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestRankList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200290E")]
  [AddComponentMenu("UI/RankingQuestRankList")]
  public class RankingQuestRankList : MonoBehaviour, ScrollListSetUp
  {
    [Token(Token = "0x400C5C2")]
    [FieldOffset(Offset = "0xC")]
    private float Space;
    [Token(Token = "0x400C5C3")]
    [FieldOffset(Offset = "0x10")]
    private int m_Max;
    [Token(Token = "0x400C5C4")]
    [FieldOffset(Offset = "0x14")]
    private RankingQuestUserData[] m_UserDatas;
    [Token(Token = "0x400C5C5")]
    [FieldOffset(Offset = "0x18")]
    private RankingQuestRankWindow m_RankingWindow;

    [Token(Token = "0x600B9DE")]
    [Address(RVA = "0x813080", Offset = "0x811E80", VA = "0x10813080")]
    private void Start()
    {
    }

    [Token(Token = "0x600B9DF")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SetData(RankingQuestUserData[] data)
    {
    }

    [Token(Token = "0x600B9E0")]
    [Address(RVA = "0x812B40", Offset = "0x811940", VA = "0x10812B40", Slot = "4")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600B9E1")]
    [Address(RVA = "0x812D70", Offset = "0x811B70", VA = "0x10812D70", Slot = "5")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600B9E2")]
    [Address(RVA = "0x812A30", Offset = "0x811830", VA = "0x10812A30")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B9E3")]
    [Address(RVA = "0x8130D0", Offset = "0x811ED0", VA = "0x108130D0")]
    public RankingQuestRankList()
    {
    }
  }
}
