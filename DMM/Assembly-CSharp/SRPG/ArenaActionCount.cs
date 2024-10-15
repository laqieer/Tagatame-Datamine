// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaActionCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000B50")]
  [AddComponentMenu("Battle/ArenaActionCount")]
  public class ArenaActionCount : MonoBehaviour
  {
    [Token(Token = "0x4001B55")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GoWhiteFont;
    [Token(Token = "0x4001B56")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GoYellowFont;
    [Token(Token = "0x4001B57")]
    [FieldOffset(Offset = "0x14")]
    public GameObject GoRedFont;
    [Token(Token = "0x4001B58")]
    private const uint VALUE_OF_DISPLAY_IN_YELLOW_FONT = 20;
    [Token(Token = "0x4001B59")]
    private const uint VALUE_OF_DISPLAY_IN_RED_FONT = 5;
    [Token(Token = "0x4001B5A")]
    [FieldOffset(Offset = "0x18")]
    private ArenaActionCount.AnmCtrl mAnmCtrl;
    [Token(Token = "0x4001B5B")]
    [FieldOffset(Offset = "0x1C")]
    private uint mActionCount;
    [Token(Token = "0x4001B5C")]
    [FieldOffset(Offset = "0x20")]
    private uint mOldActionCount;
    [Token(Token = "0x4001B5D")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsInitialized;

    [Token(Token = "0x1700021D")]
    public uint ActionCount
    {
      [Token(Token = "0x6002B52"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new uint();
      }
      [Token(Token = "0x6002B53"), Address(RVA = "0xFC6AB0", Offset = "0xFC58B0", VA = "0x10FC6AB0")] set
      {
      }
    }

    [Token(Token = "0x6002B54")]
    [Address(RVA = "0xFC6920", Offset = "0xFC5720", VA = "0x10FC6920")]
    private void dispActionCount(int count)
    {
    }

    [Token(Token = "0x6002B55")]
    [Address(RVA = "0xFC6670", Offset = "0xFC5470", VA = "0x10FC6670")]
    public void PlayEffect()
    {
    }

    [Token(Token = "0x6002B56")]
    [Address(RVA = "0xFC6A40", Offset = "0xFC5840", VA = "0x10FC6A40")]
    private IEnumerator playEffect() => (IEnumerator) null;

    [Token(Token = "0x6002B57")]
    [Address(RVA = "0xFC66E0", Offset = "0xFC54E0", VA = "0x10FC66E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6002B58")]
    [Address(RVA = "0xFC68B0", Offset = "0xFC56B0", VA = "0x10FC68B0")]
    public ArenaActionCount()
    {
    }

    [Token(Token = "0x2000B51")]
    private enum eAnmState
    {
      [Token(Token = "0x4001B5F")] IDLE,
      [Token(Token = "0x4001B60")] INIT,
      [Token(Token = "0x4001B61")] WAIT_FRAME,
      [Token(Token = "0x4001B62")] PLAY_DROP,
      [Token(Token = "0x4001B63")] WAIT_DROP,
      [Token(Token = "0x4001B64")] PLAY_BEAT,
      [Token(Token = "0x4001B65")] WAIT_BEAT,
    }

    [Token(Token = "0x2000B52")]
    private class AnmCtrl
    {
      [Token(Token = "0x4001B66")]
      [FieldOffset(Offset = "0x8")]
      public ArenaActionCount.eAnmState mAnmState;
      [Token(Token = "0x4001B67")]
      [FieldOffset(Offset = "0xC")]
      public uint mWaitFrameCtr;
      [Token(Token = "0x4001B68")]
      [FieldOffset(Offset = "0x10")]
      public uint mPlayBeatCtr;
      [Token(Token = "0x4001B69")]
      [FieldOffset(Offset = "0x14")]
      public GameObject mGoSelf;
      [Token(Token = "0x4001B6A")]
      [FieldOffset(Offset = "0x18")]
      public Animator mAnmSelf;
      [Token(Token = "0x4001B6B")]
      [FieldOffset(Offset = "0x1C")]
      public GameObject mGoEffect;
      [Token(Token = "0x4001B6C")]
      [FieldOffset(Offset = "0x20")]
      public Animator mAnmEffect;

      [Token(Token = "0x6002B59")]
      [Address(RVA = "0xFC6650", Offset = "0xFC5450", VA = "0x10FC6650")]
      public AnmCtrl()
      {
      }
    }
  }
}
