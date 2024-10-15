// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SetRunMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001238")]
  [EventActionInfo("アクター/走りアニメーション変更", "ユニットの走りアニメーションを変更します。", 5592405, 4473992)]
  public class EventAction_SetRunMode : EventAction
  {
    [Token(Token = "0x4004303")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x4004304")]
    [FieldOffset(Offset = "0x1C")]
    public string AnimationName;

    [Token(Token = "0x17000894")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D2B"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D2C")]
    [Address(RVA = "0x122FC70", Offset = "0x122EA70", VA = "0x1122FC70", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D2D")]
    [Address(RVA = "0x122FBA0", Offset = "0x122E9A0", VA = "0x1122FBA0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D2E")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_SetRunMode()
    {
    }
  }
}
