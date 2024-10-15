// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestActionCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DA6")]
  [AddComponentMenu("Battle/RankingQuestActionCount")]
  public class RankingQuestActionCount : MonoBehaviour
  {
    [Token(Token = "0x400275D")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GoWhiteFont;
    [Token(Token = "0x400275E")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GoYellowFont;
    [Token(Token = "0x400275F")]
    [FieldOffset(Offset = "0x14")]
    public GameObject GoRedFont;
    [Token(Token = "0x4002760")]
    [FieldOffset(Offset = "0x18")]
    private RankingQuestActionCount.AnmCtrl mAnmCtrl;
    [Token(Token = "0x4002761")]
    [FieldOffset(Offset = "0x1C")]
    private uint mActionCount;
    [Token(Token = "0x4002762")]
    [FieldOffset(Offset = "0x20")]
    private uint mOldActionCount;
    [Token(Token = "0x4002763")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsInitialized;

    [Token(Token = "0x170003C1")]
    public uint ActionCount
    {
      [Token(Token = "0x600374E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new uint();
      }
      [Token(Token = "0x600374F"), Address(RVA = "0x10A3F50", Offset = "0x10A2D50", VA = "0x110A3F50")] set
      {
      }
    }

    [Token(Token = "0x6003750")]
    [Address(RVA = "0x10A3DD0", Offset = "0x10A2BD0", VA = "0x110A3DD0")]
    private void dispActionCount(int count)
    {
    }

    [Token(Token = "0x6003751")]
    [Address(RVA = "0x10A3B40", Offset = "0x10A2940", VA = "0x110A3B40")]
    public void PlayEffect()
    {
    }

    [Token(Token = "0x6003752")]
    [Address(RVA = "0x10A3EE0", Offset = "0x10A2CE0", VA = "0x110A3EE0")]
    private IEnumerator playEffect() => (IEnumerator) null;

    [Token(Token = "0x6003753")]
    [Address(RVA = "0x10A3BB0", Offset = "0x10A29B0", VA = "0x110A3BB0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003754")]
    [Address(RVA = "0x10A3D60", Offset = "0x10A2B60", VA = "0x110A3D60")]
    public RankingQuestActionCount()
    {
    }

    [Token(Token = "0x2000DA7")]
    private enum eAnmState
    {
      [Token(Token = "0x4002765")] IDLE,
      [Token(Token = "0x4002766")] INIT,
      [Token(Token = "0x4002767")] WAIT_FRAME,
      [Token(Token = "0x4002768")] PLAY_DROP,
      [Token(Token = "0x4002769")] WAIT_DROP,
      [Token(Token = "0x400276A")] PLAY_BEAT,
      [Token(Token = "0x400276B")] WAIT_BEAT,
    }

    [Token(Token = "0x2000DA8")]
    private class AnmCtrl
    {
      [Token(Token = "0x400276C")]
      [FieldOffset(Offset = "0x8")]
      public RankingQuestActionCount.eAnmState mAnmState;
      [Token(Token = "0x400276D")]
      [FieldOffset(Offset = "0xC")]
      public uint mWaitFrameCtr;
      [Token(Token = "0x400276E")]
      [FieldOffset(Offset = "0x10")]
      public uint mPlayBeatCtr;
      [Token(Token = "0x400276F")]
      [FieldOffset(Offset = "0x14")]
      public GameObject mGoSelf;
      [Token(Token = "0x4002770")]
      [FieldOffset(Offset = "0x18")]
      public Animator mAnmSelf;
      [Token(Token = "0x4002771")]
      [FieldOffset(Offset = "0x1C")]
      public GameObject mGoEffect;
      [Token(Token = "0x4002772")]
      [FieldOffset(Offset = "0x20")]
      public Animator mAnmEffect;

      [Token(Token = "0x6003755")]
      [Address(RVA = "0xFC6650", Offset = "0xFC5450", VA = "0x10FC6650")]
      public AnmCtrl()
      {
      }
    }
  }
}
