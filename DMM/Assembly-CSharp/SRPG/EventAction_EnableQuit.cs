// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_EnableQuit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011FF")]
  [EventActionInfo("強制終了/許可", "スクリプトの強制終了を有効にします。", 5592405, 4473992)]
  public class EventAction_EnableQuit : EventAction
  {
    [Token(Token = "0x4004181")]
    [FieldOffset(Offset = "0x0")]
    protected static EventQuit mQuit;
    [Token(Token = "0x4004182")]
    [FieldOffset(Offset = "0x18")]
    private LoadRequest mResource;
    [Token(Token = "0x4004183")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string AssetPath;

    [Token(Token = "0x1700087F")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004C86"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004C87")]
    [Address(RVA = "0x1219570", Offset = "0x1218370", VA = "0x11219570", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004C88")]
    [Address(RVA = "0x12192A0", Offset = "0x12180A0", VA = "0x112192A0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004C89")]
    [Address(RVA = "0x12195E0", Offset = "0x12183E0", VA = "0x112195E0")]
    private void SkipButtonAction(
      EventScript.Sequence inEventScriptSequence,
      GameObject inSkipButtonGameObject)
    {
    }

    [Token(Token = "0x6004C8A")]
    [Address(RVA = "0x1219120", Offset = "0x1217F20", VA = "0x11219120", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C8B")]
    [Address(RVA = "0x1219240", Offset = "0x1218040", VA = "0x11219240", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004C8C")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_EnableQuit()
    {
    }

    [Token(Token = "0x6004C8D")]
    [Address(RVA = "0x12197B0", Offset = "0x12185B0", VA = "0x112197B0")]
    static EventAction_EnableQuit()
    {
    }
  }
}
