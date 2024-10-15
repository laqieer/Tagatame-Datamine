// Decompiled with JetBrains decompiler
// Type: SRPG.BattleResultMissionDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002083")]
  [AddComponentMenu("UI/BattleResultMissionDetail")]
  public class BattleResultMissionDetail : MonoBehaviour
  {
    [Token(Token = "0x4008C0D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private QuestMissionItem ItemTemplate;
    [Token(Token = "0x4008C0E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private QuestMissionItem UnitTemplate;
    [Token(Token = "0x4008C0F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private QuestMissionItem ArtifactTemplate;
    [Token(Token = "0x4008C10")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestMissionItem ConceptCardTemplate;
    [Token(Token = "0x4008C11")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private QuestMissionItem NothingRewardTemplate;
    [Token(Token = "0x4008C12")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ContentsParent;
    [Token(Token = "0x4008C13")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ScrollRect ScrollRect;
    [Token(Token = "0x4008C14")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private VerticalLayoutGroup VerticalLayout;
    [Token(Token = "0x4008C15")]
    [FieldOffset(Offset = "0x0")]
    private static readonly float WaitTime;
    [Token(Token = "0x4008C16")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> allStarObjects;
    [Token(Token = "0x4008C17")]
    [FieldOffset(Offset = "0x30")]
    private Coroutine lastCoroutine;
    [Token(Token = "0x4008C18")]
    [FieldOffset(Offset = "0x34")]
    private float m_ItemHeight;

    [Token(Token = "0x600874D")]
    [Address(RVA = "0x488B10", Offset = "0x487910", VA = "0x10488B10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600874E")]
    [Address(RVA = "0x488DB0", Offset = "0x487BB0", VA = "0x10488DB0")]
    private void RefreshQuestMissionReward(QuestParam questParam)
    {
    }

    [Token(Token = "0x600874F")]
    [Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")]
    public List<GameObject> GetObjectiveStars() => (List<GameObject>) null;

    [Token(Token = "0x6008750")]
    [Address(RVA = "0x488CA0", Offset = "0x487AA0", VA = "0x10488CA0")]
    public float MoveTo(int index) => new float();

    [Token(Token = "0x6008751")]
    [Address(RVA = "0x488C30", Offset = "0x487A30", VA = "0x10488C30")]
    private IEnumerator MoveScrollCoroutine(int index) => (IEnumerator) null;

    [Token(Token = "0x6008752")]
    [Address(RVA = "0x489340", Offset = "0x488140", VA = "0x10489340")]
    public BattleResultMissionDetail()
    {
    }

    [Token(Token = "0x6008753")]
    [Address(RVA = "0x489310", Offset = "0x488110", VA = "0x10489310")]
    static BattleResultMissionDetail()
    {
    }
  }
}
