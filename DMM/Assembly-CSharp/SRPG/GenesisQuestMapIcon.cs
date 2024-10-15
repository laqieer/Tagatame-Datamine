// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisQuestMapIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024F7")]
  [AddComponentMenu("UI/Genesis/GenesisQuestMapIcon")]
  public class GenesisQuestMapIcon : MonoBehaviour
  {
    [Token(Token = "0x400A8F0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRefQuestIconImages;
    [Token(Token = "0x400A8F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRefClearObject;
    [Token(Token = "0x400A8F2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRefNextObject;
    [Token(Token = "0x400A8F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GameObject> mRefMissionStarLists;
    [Token(Token = "0x400A8F4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mRefButton;
    [Token(Token = "0x400A8F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button mRefLockButton;
    [Token(Token = "0x400A8F6")]
    [FieldOffset(Offset = "0x24")]
    private GenesisQuestMapSymbol.eQuestState mCurrentState;
    [Token(Token = "0x400A8F7")]
    [FieldOffset(Offset = "0x28")]
    private QuestParam mQuestParam;

    [Token(Token = "0x170016B9")]
    public QuestParam QuestParam
    {
      [Token(Token = "0x600A260"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (QuestParam) null;
      }
    }

    [Token(Token = "0x600A261")]
    [Address(RVA = "0x647ED0", Offset = "0x646CD0", VA = "0x10647ED0")]
    public bool SetIcon(
      QuestParam param,
      GenesisQuestMapIcon.OnClickIcon onclick,
      GenesisQuestMapIcon.OnClickLockedIcon onclick_locked)
    {
      return new bool();
    }

    [Token(Token = "0x600A262")]
    [Address(RVA = "0x416AD0", Offset = "0x4158D0", VA = "0x10416AD0")]
    public void SetState(GenesisQuestMapSymbol.eQuestState state)
    {
    }

    [Token(Token = "0x600A263")]
    [Address(RVA = "0x6480E0", Offset = "0x646EE0", VA = "0x106480E0")]
    public void SetMissionStar(QuestParam param)
    {
    }

    [Token(Token = "0x600A264")]
    [Address(RVA = "0x416A90", Offset = "0x415890", VA = "0x10416A90")]
    public void SetSelected(bool flag)
    {
    }

    [Token(Token = "0x600A265")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisQuestMapIcon()
    {
    }

    [Token(Token = "0x20024F8")]
    public delegate void OnClickIcon(GenesisQuestMapIcon clicked, QuestParam param);

    [Token(Token = "0x20024F9")]
    public delegate void OnClickLockedIcon(GenesisQuestMapIcon clicked);
  }
}
