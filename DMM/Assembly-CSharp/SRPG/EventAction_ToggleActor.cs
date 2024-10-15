// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_ToggleActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001251")]
  [EventActionInfo("アクター/表示切替", "シーン上のアクターの表示状態を切り替えます", 5592405, 4473992)]
  public class EventAction_ToggleActor : EventAction
  {
    [Token(Token = "0x4004383")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x4004384")]
    [FieldOffset(Offset = "0x1C")]
    public EventAction_ToggleActor.ToggleTypes Type;
    [Token(Token = "0x4004385")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mSummonEffect;

    [Token(Token = "0x170008B2")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D9A"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D9B")]
    [Address(RVA = "0x12322D0", Offset = "0x12310D0", VA = "0x112322D0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D9C")]
    [Address(RVA = "0x12320B0", Offset = "0x1230EB0", VA = "0x112320B0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D9D")]
    [Address(RVA = "0x1232000", Offset = "0x1230E00", VA = "0x11232000", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004D9E")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_ToggleActor()
    {
    }

    [Token(Token = "0x2001252")]
    public enum ToggleTypes
    {
      [Token(Token = "0x4004387")] Hide,
      [Token(Token = "0x4004388")] Show,
      [Token(Token = "0x4004389")] Summon,
    }
  }
}
