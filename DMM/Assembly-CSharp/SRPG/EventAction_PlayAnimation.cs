// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_PlayAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001220")]
  [EventActionInfo("アクター/アニメーション再生", "ユニットにアニメーションを再生させます。", 6702148, 11158596)]
  public class EventAction_PlayAnimation : EventAction
  {
    [Token(Token = "0x400427C")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x400427D")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public string AnimationName;
    [Token(Token = "0x400427E")]
    [FieldOffset(Offset = "0x20")]
    public EventAction_PlayAnimation.AnimationTypes AnimationType;
    [Token(Token = "0x400427F")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public bool Loop;
    [Token(Token = "0x4004280")]
    [FieldOffset(Offset = "0x25")]
    public bool Async;
    [Token(Token = "0x4004281")]
    [FieldOffset(Offset = "0x28")]
    private string mAnimationID;
    [Token(Token = "0x4004282")]
    [FieldOffset(Offset = "0x2C")]
    private TacticsUnitController mController;

    [Token(Token = "0x17000888")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004CE5"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004CE6")]
    [Address(RVA = "0x1220450", Offset = "0x121F250", VA = "0x11220450", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004CE7")]
    [Address(RVA = "0x12202C0", Offset = "0x121F0C0", VA = "0x112202C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CE8")]
    [Address(RVA = "0x12204B0", Offset = "0x121F2B0", VA = "0x112204B0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CE9")]
    [Address(RVA = "0x12203D0", Offset = "0x121F1D0", VA = "0x112203D0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004CEA")]
    [Address(RVA = "0x12201D0", Offset = "0x121EFD0", VA = "0x112201D0", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004CEB")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_PlayAnimation()
    {
    }

    [Token(Token = "0x2001221")]
    public enum AnimationTypes
    {
      [Token(Token = "0x4004284")] Custom,
      [Token(Token = "0x4004285")] Idle,
    }
  }
}
