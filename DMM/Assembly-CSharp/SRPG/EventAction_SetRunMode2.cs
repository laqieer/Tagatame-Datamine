// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SetRunMode2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200123A")]
  [EventActionInfo("New/アクター/走りアニメーション変更", "ユニットの走りアニメーションを変更します。", 5592405, 4473992)]
  public class EventAction_SetRunMode2 : EventAction
  {
    [Token(Token = "0x4004309")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x400430A")]
    [FieldOffset(Offset = "0x1C")]
    public string AnimationName;

    [Token(Token = "0x17000897")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D35"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D36")]
    [Address(RVA = "0x122F9F0", Offset = "0x122E7F0", VA = "0x1122F9F0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D37")]
    [Address(RVA = "0x122F920", Offset = "0x122E720", VA = "0x1122F920", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D38")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_SetRunMode2()
    {
    }
  }
}
