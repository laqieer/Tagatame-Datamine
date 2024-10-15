// Decompiled with JetBrains decompiler
// Type: SRPG.MissionDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002720")]
  [AddComponentMenu("UI/MissionDetail")]
  public class MissionDetail : MonoBehaviour
  {
    [Token(Token = "0x400B855")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private QuestMissionItem ItemTemplate;
    [Token(Token = "0x400B856")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private QuestMissionItem UnitTemplate;
    [Token(Token = "0x400B857")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private QuestMissionItem ArtifactTemplate;
    [Token(Token = "0x400B858")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestMissionItem ConceptCardTemplate;
    [Token(Token = "0x400B859")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private QuestMissionItem NothingRewardTemplate;
    [Token(Token = "0x400B85A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ContentsParent;
    [Token(Token = "0x400B85B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400B85C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect ScrollRect;
    [Token(Token = "0x400B85D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject Scrollbar;

    [Token(Token = "0x600AF6D")]
    [Address(RVA = "0x738BA0", Offset = "0x7379A0", VA = "0x10738BA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AF6E")]
    [Address(RVA = "0x738EE0", Offset = "0x737CE0", VA = "0x10738EE0")]
    private void RefreshQuestMissionReward(QuestParam questParam)
    {
    }

    [Token(Token = "0x600AF6F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MissionDetail()
    {
    }
  }
}
