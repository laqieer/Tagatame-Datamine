// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SetRunMode3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200123C")]
  [EventActionInfo("New/アクター/走りアニメーション変更2", "ユニットの走りアニメーションを変更します。", 5592405, 4473992)]
  public class EventAction_SetRunMode3 : EventAction
  {
    [Token(Token = "0x400430F")]
    private const string MOVIE_PATH = "Movies/";
    [Token(Token = "0x4004310")]
    private const string DEMO_PATH = "Demo/";
    [Token(Token = "0x4004311")]
    [FieldOffset(Offset = "0x18")]
    public EventAction_SetRunMode3.PREFIX_PATH Path;
    [Token(Token = "0x4004312")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x4004313")]
    [FieldOffset(Offset = "0x20")]
    public string AnimationName;

    [Token(Token = "0x1700089A")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D3F"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D40")]
    [Address(RVA = "0x122FB30", Offset = "0x122E930", VA = "0x1122FB30", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D41")]
    [Address(RVA = "0x122FA60", Offset = "0x122E860", VA = "0x1122FA60", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D42")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_SetRunMode3()
    {
    }

    [Token(Token = "0x200123D")]
    public enum PREFIX_PATH
    {
      [Token(Token = "0x4004315")] Demo,
      [Token(Token = "0x4004316")] Movie,
    }
  }
}
