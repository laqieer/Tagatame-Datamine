// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_PlayAnimation3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001226")]
  [EventActionInfo("New/アクター/アニメーション再生2", "ユニットにアニメーションを再生させます。", 6702148, 11158596)]
  public class EventAction_PlayAnimation3 : EventAction
  {
    [Token(Token = "0x4004299")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x400429A")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public EventAction_PlayAnimation3.PREFIX_PATH Path;
    [Token(Token = "0x400429B")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public string AnimationName;
    [Token(Token = "0x400429C")]
    [FieldOffset(Offset = "0x24")]
    public EventAction_PlayAnimation3.AnimationTypes AnimationType;
    [Token(Token = "0x400429D")]
    [FieldOffset(Offset = "0x28")]
    public float Delay;
    [Token(Token = "0x400429E")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public bool Loop;
    [Token(Token = "0x400429F")]
    [FieldOffset(Offset = "0x2D")]
    public bool Async;
    [Token(Token = "0x40042A0")]
    [FieldOffset(Offset = "0x30")]
    private string mAnimationID;
    [Token(Token = "0x40042A1")]
    [FieldOffset(Offset = "0x34")]
    private TacticsUnitController mController;
    [Token(Token = "0x40042A2")]
    private const string MOVIE_PATH = "Movies/";
    [Token(Token = "0x40042A3")]
    private const string DEMO_PATH = "Demo/";

    [Token(Token = "0x1700088E")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004CFE"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004CFF")]
    [Address(RVA = "0x122D990", Offset = "0x122C790", VA = "0x1122D990", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D00")]
    [Address(RVA = "0x122D7C0", Offset = "0x122C5C0", VA = "0x1122D7C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D01")]
    [Address(RVA = "0x122DA00", Offset = "0x122C800", VA = "0x1122DA00", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004D02")]
    [Address(RVA = "0x122D910", Offset = "0x122C710", VA = "0x1122D910", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004D03")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_PlayAnimation3()
    {
    }

    [Token(Token = "0x2001227")]
    public enum PREFIX_PATH
    {
      [Token(Token = "0x40042A5")] Demo,
      [Token(Token = "0x40042A6")] Movie,
      [Token(Token = "0x40042A7")] Default,
    }

    [Token(Token = "0x2001228")]
    public enum AnimationTypes
    {
      [Token(Token = "0x40042A9")] Custom,
      [Token(Token = "0x40042AA")] Idle,
    }
  }
}
