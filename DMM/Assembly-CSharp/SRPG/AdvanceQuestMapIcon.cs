// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceQuestMapIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F5E")]
  [AddComponentMenu("UI/Advance/AdvanceQuestMapIcon")]
  public class AdvanceQuestMapIcon : MonoBehaviour
  {
    [Token(Token = "0x400844E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRefQuestIconImages;
    [Token(Token = "0x400844F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRefClearObject;
    [Token(Token = "0x4008450")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRefNextObject;
    [Token(Token = "0x4008451")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GameObject> mRefMissionStarLists;
    [Token(Token = "0x4008452")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mRefButton;
    [Token(Token = "0x4008453")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button mRefLockButton;
    [Token(Token = "0x4008454")]
    [FieldOffset(Offset = "0x24")]
    private AdvanceQuestMapSymbol.eQuestState mCurrentState;
    [Token(Token = "0x4008455")]
    [FieldOffset(Offset = "0x28")]
    private QuestParam mQuestParam;

    [Token(Token = "0x17001274")]
    public QuestParam QuestParam
    {
      [Token(Token = "0x60080C1"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (QuestParam) null;
      }
    }

    [Token(Token = "0x60080C2")]
    [Address(RVA = "0x4166F0", Offset = "0x4154F0", VA = "0x104166F0")]
    public bool SetIcon(
      QuestParam param,
      AdvanceQuestMapIcon.OnClickIcon onclick,
      AdvanceQuestMapIcon.OnClickLockedIcon onclick_locked)
    {
      return new bool();
    }

    [Token(Token = "0x60080C3")]
    [Address(RVA = "0x416AD0", Offset = "0x4158D0", VA = "0x10416AD0")]
    public void SetState(AdvanceQuestMapSymbol.eQuestState state)
    {
    }

    [Token(Token = "0x60080C4")]
    [Address(RVA = "0x416900", Offset = "0x415700", VA = "0x10416900")]
    public void SetMissionStar(QuestParam param)
    {
    }

    [Token(Token = "0x60080C5")]
    [Address(RVA = "0x416A90", Offset = "0x415890", VA = "0x10416A90")]
    public void SetSelected(bool flag)
    {
    }

    [Token(Token = "0x60080C6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceQuestMapIcon()
    {
    }

    [Token(Token = "0x2001F5F")]
    public delegate void OnClickIcon(AdvanceQuestMapIcon clicked, QuestParam param);

    [Token(Token = "0x2001F60")]
    public delegate void OnClickLockedIcon(AdvanceQuestMapIcon clicked);
  }
}
