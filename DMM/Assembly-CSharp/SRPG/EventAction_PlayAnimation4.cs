// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_PlayAnimation4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200122A")]
  [EventActionInfo("New/アクター/アニメーション再生(複数)", "ユニットにアニメーションを再生させます。", 6702148, 11158596)]
  public class EventAction_PlayAnimation4 : EventAction
  {
    [Token(Token = "0x40042AE")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x40042AF")]
    [FieldOffset(Offset = "0x1C")]
    public bool Async;
    [Token(Token = "0x40042B0")]
    private const string MOVIE_PATH = "Movies/";
    [Token(Token = "0x40042B1")]
    private const string DEMO_PATH = "Demo/";
    [Token(Token = "0x40042B2")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public EventAction_PlayAnimation4.AnimationData[] AnimationDataArray;
    [Token(Token = "0x40042B3")]
    [FieldOffset(Offset = "0x24")]
    private bool foldout;
    [Token(Token = "0x40042B4")]
    [FieldOffset(Offset = "0x28")]
    private List<string> mAnimationIDList;
    [Token(Token = "0x40042B5")]
    [FieldOffset(Offset = "0x2C")]
    private TacticsUnitController mController;
    [Token(Token = "0x40042B6")]
    [FieldOffset(Offset = "0x30")]
    private int idx;
    [Token(Token = "0x40042B7")]
    [FieldOffset(Offset = "0x34")]
    private float mDelay;
    [Token(Token = "0x40042B8")]
    [FieldOffset(Offset = "0x38")]
    private bool isPlay;

    [Token(Token = "0x17000891")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D0A"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D0B")]
    [Address(RVA = "0x122DC90", Offset = "0x122CA90", VA = "0x1122DC90", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D0C")]
    [Address(RVA = "0x122DB30", Offset = "0x122C930", VA = "0x1122DB30", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D0D")]
    [Address(RVA = "0x122DD00", Offset = "0x122CB00", VA = "0x1122DD00", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004D0E")]
    [Address(RVA = "0x122DBD0", Offset = "0x122C9D0", VA = "0x1122DBD0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004D0F")]
    [Address(RVA = "0x122E170", Offset = "0x122CF70", VA = "0x1122E170")]
    public EventAction_PlayAnimation4()
    {
    }

    [Token(Token = "0x200122B")]
    public enum AnimationTypes
    {
      [Token(Token = "0x40042BA")] Custom,
      [Token(Token = "0x40042BB")] Idle,
    }

    [Token(Token = "0x200122C")]
    [Serializable]
    public class AnimationData
    {
      [Token(Token = "0x40042BC")]
      [FieldOffset(Offset = "0x8")]
      public EventAction_PlayAnimation4.AnimationTypes Type;
      [Token(Token = "0x40042BD")]
      [FieldOffset(Offset = "0xC")]
      public string Name;
      [Token(Token = "0x40042BE")]
      [FieldOffset(Offset = "0x10")]
      public float Delay;
      [Token(Token = "0x40042BF")]
      [FieldOffset(Offset = "0x14")]
      public float Interp;
      [Token(Token = "0x40042C0")]
      [FieldOffset(Offset = "0x18")]
      public bool ApplyRootBoneAtEnd;
      [Token(Token = "0x40042C1")]
      [FieldOffset(Offset = "0x19")]
      public bool Loop;
      [Token(Token = "0x40042C2")]
      [FieldOffset(Offset = "0x1C")]
      public EventAction_PlayAnimation4.AnimationData.PREFIX_PATH Path;

      [Token(Token = "0x6004D10")]
      [Address(RVA = "0x1227AC0", Offset = "0x12268C0", VA = "0x11227AC0")]
      public AnimationData()
      {
      }

      [Token(Token = "0x200122D")]
      public enum PREFIX_PATH
      {
        [Token(Token = "0x40042C4")] Demo,
        [Token(Token = "0x40042C5")] Movie,
        [Token(Token = "0x40042C6")] Default,
      }
    }
  }
}
