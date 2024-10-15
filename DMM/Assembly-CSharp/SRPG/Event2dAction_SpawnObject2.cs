// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SpawnObject2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012AB")]
  [EventActionInfo("New/オブジェクト/配置(2D)", "シーンにオブジェクトを配置します。", 5592405, 4473992)]
  public class Event2dAction_SpawnObject2 : EventAction
  {
    [Token(Token = "0x4004567")]
    public const string ResourceDir = "EventAssets/";
    [Token(Token = "0x4004568")]
    [FieldOffset(Offset = "0x18")]
    [StringIsDemoResourcePath(typeof (GameObject), "EventAssets/")]
    public string ResourceID;
    [Token(Token = "0x4004569")]
    [FieldOffset(Offset = "0x1C")]
    public string ObjectID;
    [Token(Token = "0x400456A")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mResourceLoadRequest;
    [Token(Token = "0x400456B")]
    [FieldOffset(Offset = "0x24")]
    public bool Persistent;
    [Token(Token = "0x400456C")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 Position;
    [Token(Token = "0x400456D")]
    [FieldOffset(Offset = "0x34")]
    private GameObject mGO;

    [Token(Token = "0x6004F22")]
    [Address(RVA = "0x1244110", Offset = "0x1242F10", VA = "0x11244110", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F23")]
    [Address(RVA = "0x1244430", Offset = "0x1243230", VA = "0x11244430", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x170008DE")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004F24"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004F25")]
    [Address(RVA = "0x1244510", Offset = "0x1243310", VA = "0x11244510", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F26")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_SpawnObject2()
    {
    }
  }
}
