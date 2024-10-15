// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_ToggleActor2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001254")]
  [EventActionInfo("New/アクター/表示切替", "シーン上のアクターの表示状態を切り替えます", 5592405, 4473992)]
  public class EventAction_ToggleActor2 : EventAction
  {
    [Token(Token = "0x400438E")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x400438F")]
    [FieldOffset(Offset = "0x1C")]
    public EventAction_ToggleActor2.ToggleTypes Type;
    [Token(Token = "0x4004390")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mSummonEffect;

    [Token(Token = "0x170008B5")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004DA5"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004DA6")]
    [Address(RVA = "0x1231F80", Offset = "0x1230D80", VA = "0x11231F80", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004DA7")]
    [Address(RVA = "0x1231D60", Offset = "0x1230B60", VA = "0x11231D60", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004DA8")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_ToggleActor2()
    {
    }

    [Token(Token = "0x2001255")]
    public enum ToggleTypes
    {
      [Token(Token = "0x4004392")] Hide,
      [Token(Token = "0x4004393")] Show,
      [Token(Token = "0x4004394")] Summon,
    }
  }
}
