// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_PlayAnimation2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001223")]
  [EventActionInfo("New/アクター/アニメーション再生", "ユニットにアニメーションを再生させます。", 6702148, 11158596)]
  public class EventAction_PlayAnimation2 : EventAction
  {
    [Token(Token = "0x4004289")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x400428A")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public string AnimationName;
    [Token(Token = "0x400428B")]
    [FieldOffset(Offset = "0x20")]
    public EventAction_PlayAnimation2.AnimationTypes AnimationType;
    [Token(Token = "0x400428C")]
    [FieldOffset(Offset = "0x24")]
    public float Delay;
    [Token(Token = "0x400428D")]
    [FieldOffset(Offset = "0x28")]
    public float Interp;
    [Token(Token = "0x400428E")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public bool Loop;
    [Token(Token = "0x400428F")]
    [FieldOffset(Offset = "0x2D")]
    public bool Async;
    [Token(Token = "0x4004290")]
    [FieldOffset(Offset = "0x2E")]
    [HideInInspector]
    public bool ApplyRootBoneAtEnd;
    [Token(Token = "0x4004291")]
    [FieldOffset(Offset = "0x30")]
    private string mAnimationID;
    [Token(Token = "0x4004292")]
    [FieldOffset(Offset = "0x34")]
    private TacticsUnitController mController;

    [Token(Token = "0x1700088B")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004CF2"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004CF3")]
    [Address(RVA = "0x122D3F0", Offset = "0x122C1F0", VA = "0x1122D3F0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004CF4")]
    [Address(RVA = "0x122D220", Offset = "0x122C020", VA = "0x1122D220", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CF5")]
    [Address(RVA = "0x122D460", Offset = "0x122C260", VA = "0x1122D460", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CF6")]
    [Address(RVA = "0x122D370", Offset = "0x122C170", VA = "0x1122D370", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004CF7")]
    [Address(RVA = "0x122D7A0", Offset = "0x122C5A0", VA = "0x1122D7A0")]
    public EventAction_PlayAnimation2()
    {
    }

    [Token(Token = "0x2001224")]
    public enum AnimationTypes
    {
      [Token(Token = "0x4004294")] Custom,
      [Token(Token = "0x4004295")] Idle,
    }
  }
}
